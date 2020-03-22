using NetNotes.Business.Elements;
using NetNotes.Business.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace NetNotes.Business
{
    public class MusicXmlScoreReader
    {
        public Score ParseString(string xmlString)
        {
            var doc = XElement.Parse(xmlString);
            return ParseScoreElement(doc);
        }


        public Score ParseFile(string fileName)
        {
            var doc = XElement.Load(fileName);
            return ParseScoreElement(doc);
        }


        private Score ParseScoreElement(XElement doc)
        {
            var score = new Score();

            var scoreElement = doc.Element("score-partwise") ?? doc;
            score.Title = scoreElement.Element("work")?.Element("work-title")?.Value;

            ParseIdentification(scoreElement.Element("identification"), score);
            ParseStaves(scoreElement, score);

            return score;
        }

        private void ParseIdentification(XElement identification, Score score)
        {
            var creators = identification.Elements("creator");
            score.Composer = creators.First(c => c.Attribute("type").Value.Equals("composer")).Value;
            score.Lyricist = creators.First(c => c.Attribute("type").Value.Equals("lyricist")).Value;
            score.Copyright = identification.Element("rights").Value;
        }

        private void ParseStaves(XElement scoreElement, Score score)
        {
            score.Staves = new List<Staff>();
            var partList = scoreElement.Element("part-list");
            foreach (var scorePart in partList.Elements("score-part"))
            {
                var staff = new Staff();
                var scorePartId = scorePart.Attribute("id").Value;
                staff.PartName = scorePart.Element("part-name").Value;
                staff.AbbreviatedName = scorePart.Element("part-abbreviation").Value;
                var part = scoreElement.Elements("part")
                    .FirstOrDefault(p => p.Attribute("id").Value == scorePartId);
                ParseMeasures(part, staff);
                score.Staves.Add(staff);
            }
        }

        private void ParseMeasures(XElement partElement, Staff staff)
        {
            staff.Measures = new List<Measure>();
            var measureElements = partElement.Elements("measure");
            foreach (var msElement in measureElements)
            {
                var ms = new Measure();
                ParseMeasureAttributes(msElement, ms);
                ParseNotes(msElement, ms);
                staff.Measures.Add(ms);
            }
        }

        private void ParseMeasureAttributes(XElement msElement, Measure ms)
        {
            var attributeElement = msElement.Element("attributes");
            var keyAttr = attributeElement.Element("key");
            if (keyAttr != null)
            {
                ms.KeySignature = ParseKeyAttribute(keyAttr);
                ms.ShowKey = true;
            }

            var clefAttr = attributeElement.Element("clef");
            if (clefAttr != null)
            {
                var sign = clefAttr.Element("sign")?.Value;
                var line = clefAttr.Element("line")?.Value;
                int.TryParse(line, out var lineNum);
                ms.Clef = Clefs.GetClef(lineNum, sign[0]);
                ms.ShowClef = true;
            }

            var timeAttr = attributeElement.Element("time");
            if (timeAttr != null)
            {
                ms.ShowTime = timeAttr.Attribute("print-object")?.Value == "yes";
                int.TryParse(timeAttr.Element("beats").Value, out var top);
                int.TryParse(timeAttr.Element("beat-type").Value, out var bottom);
                ms.TimeSignature = new TimeSignature(top, bottom);
            }
        }

        private KeySignature ParseKeyAttribute(XElement keyAttribute)
        {
            var fifths = keyAttribute.Element("fifths")?.Value;
            var numFlats = 0;
            var numSharps = 0;
            if (int.TryParse(fifths, out var circleOffset))
            {
                if (circleOffset < 0)
                {
                    numFlats = Math.Abs(circleOffset);
                }
                else
                {
                    numSharps = circleOffset;
                }
            }
            return new KeySignature(numSharps, numFlats);
        }


        private void ParseNotes(XElement msElement, Measure ms)
        {
            var noteElements = msElement.Elements("note");
            ms.Pattern = new List<IRhythmUnit>();
            foreach (var noteElement in noteElements)
            {
                var durationType = noteElement.Element("type")?.Value;
                var dotCount = noteElement.Elements("dot").Count();
                var duration = new Duration(durationType, dotCount);
                
                if (noteElement.Element("rest") != null)
                {
                    ms.Pattern.Add(new Rest(duration));
                    continue;
                }

                var beamList = new List<Beam>();
                if (noteElement.Element("beam") != null)
                {
                    var beamElements = noteElement.Elements("beam")
                        .OrderBy(b => b.Attribute("number").Value);
                    int.TryParse(beamElements.Last().Attribute("number").Value, out var lastIndex);
                    for (var i = 1; i <= lastIndex; i++)
                    {
                        var beamElement = beamElements.FirstOrDefault(b => b.Attribute("number").Value == i.ToString());

                        switch (beamElement?.Value)
                        {
                            case "begin":
                                beamList.Add(Beam.Start);
                                break;
                            case "continue":
                                beamList.Add(Beam.Continue);
                                break;
                            case "end":
                                beamList.Add(Beam.End);
                                break;
                            default:
                                beamList.Add(Beam.None);
                                break;
                        }
                    }
                }

                var pitchElement = noteElement.Element("pitch");

                if (pitchElement != null)
                {
                    var letterName = pitchElement.Element("step")?.Value;
                    int.TryParse(pitchElement.Element("octave")?.Value, out var octave);
                    int.TryParse(pitchElement.Element("alter")?.Value, out var alter);

                    var pitch = new Pitch(letterName[0], octave, alter);
                    ms.Pattern.Add(new Note(pitch, duration, beamList));
                    continue;
                }

                ms.Pattern.Add(new Note(null, duration, beamList));
            }
        }
    }
}
