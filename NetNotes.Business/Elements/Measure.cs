using NetNotes.Business.Elements.Interfaces;
using System.Collections.Generic;
using System.Text.Json;

namespace NetNotes.Business.Elements
{
    public class Measure
    {
        public Measure(Clef clef, TimeSignature time, KeySignature key, IList<IRhythmUnit> pattern)
        {
            Clef = clef;
            TimeSignature = time;
            KeySignature = key;
            Pattern = pattern;
        }

        public Measure(Clef clef, TimeSignature time, KeySignature key, string patternString)
        {
            Clef = clef;
            TimeSignature = time;
            KeySignature = key;
            var units = patternString.Split(',');
            Pattern = new List<IRhythmUnit>();
            foreach (var unit in units)
            {
                var p = unit.Trim().ToUpperInvariant();
                if ((!p.EndsWith("QUARTER") && p.EndsWith("R")) ||
                    p.EndsWith("REST"))
                {
                    Pattern.Add(new Rest(p));
                }
                else
                {
                    Pattern.Add(new Note(p));
                }
            }
        }

        public Measure(string measureJson)
        {
            JsonSerializer.Deserialize<Measure>(measureJson);
        }

        public TimeSignature TimeSignature { get; set; }
        public KeySignature KeySignature { get; set; }

        public IList<IRhythmUnit> Pattern { get; set; }

        public Clef Clef { get; set; }

        public IList<IExpression> Expressions { get; set; }

        public bool ShowClef { get; set; } = false;
        public bool ShowTime { get; set; } = false;
        public bool ShowKey { get; set; } = false;

        public Barline StartingBarline { get; set; } = Barline.Single;
        public Barline EndingBarline { get; set; } = Barline.Single;
    }
}
