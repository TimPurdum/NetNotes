using NetNotes.Business.Elements;
using NetNotes.Business.Elements.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetNotes.Business
{
    public class SimpleTextScoreReader
    {
        public Score CreateNewScore(string input)
        {
            var score = new Score();
            score.Staves.AddRange(ParseStaves(input));

            return score;
        }

        public void AddNewStaff(Score score, string staffInput)
        {
            score.Staves.AddRange(ParseStaves(staffInput));
        }


        private IList<Staff> ParseStaves(string input)
        {
            var staffInputs = input.Split('_');
            var staves = new List<Staff>();

            foreach (var staffInput in staffInputs)
            {
                var staff = new Staff();
                if (!string.IsNullOrWhiteSpace(staffInput))
                {
                    staff.Measures.AddRange(ParseMeasures(staffInput.Trim()));
                }
                else
                {
                    staff.Measures.Add(new Measure());
                }

                staves.Add(staff);
            }

            return staves;
        }


        private IList<Measure> ParseMeasures(string staffInput)
        {
            var measures = new List<Measure>();
            var inputMeasures = staffInput.Split('|');
            foreach (var inputMs in inputMeasures)
            {
                measures.Add(ParseMeasure(inputMs.Trim()));
            }
            if (measures.Any())
            {
                var first = measures.First();
                first.ShowTime = true;
                first.ShowClef = true;
                first.ShowKey = true;
            }

            return measures;
        }


        private Measure ParseMeasure(string input)
        {
            try
            {
                var ms = new Measure();

                if (input.Contains(":"))
                {
                    var options = input.Split(':');
                    foreach (var opt in options)
                    {
                        var info = opt.Trim();
                        if (info.StartsWith("Time-"))
                        {
                            ms.TimeSignature = TimeSignatures.GetTime(info.Substring(5));
                        }
                        else if (info.StartsWith("Key-"))
                        {
                            ms.KeySignature = KeySignatures.GetKey(info.Substring(4));
                        }
                        else if (info.StartsWith("Clef-"))
                        {
                            ms.Clef = Clefs.GetClef(info.Substring(5));
                        }
                    }

                    input = options.Last();
                }

                var units = input.Split(',');
                foreach (var unit in units)
                {
                    var p = unit.Trim().ToUpperInvariant();
                    if ((!p.EndsWith("QUARTER") && p.EndsWith("R")) ||
                        p.EndsWith("REST"))
                    {
                        ms.Pattern.Add(new Rest(p));
                    }
                    else
                    {
                        ms.Pattern.Add(new Note(p));
                    }
                }

                return ms;
            }
            catch (Exception ex)
            {
                throw new UnrecognizedPatternException($"Unrecognized Measure: {input}", ex);
            }
        }
    }
}
