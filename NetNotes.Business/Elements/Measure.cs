using NetNotes.Business.Elements.Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace NetNotes.Business.Elements
{
    public class Measure
    {
        public Measure()
        {
        }

        public Measure(Clef clef, TimeSignature time, KeySignature key, IList<IRhythmUnit> pattern)
        {
            Clef = clef;
            TimeSignature = time;
            KeySignature = key;
            Pattern = pattern;
        }

        public TimeSignature TimeSignature { get; set; } = TimeSignatures.CommonTime;
        public KeySignature KeySignature { get; set; } = KeySignatures.CMajor;

        public IList<IRhythmUnit> Pattern { get; set; } = new List<IRhythmUnit>();

        public Clef Clef { get; set; } = Clefs.Treble;

        public IList<IExpression> Expressions { get; set; } = new List<IExpression>();

        public bool ShowClef { get; set; } = false;
        public bool ShowTime { get; set; } = false;
        public bool ShowKey { get; set; } = false;

        public Barline StartingBarline { get; set; } = Barline.Single;
        public Barline EndingBarline { get; set; } = Barline.Single;

        public override string ToString()
        {
            var sb = new StringBuilder();
            if (ShowClef)
            {
                sb.Append($"Clef-{Clef.Name}:");
            }
            if (ShowKey)
            {
                sb.Append($"Key-{KeySignature.MajorName}:");
            }
            if (ShowTime)
            {
                sb.Append($"Time-{TimeSignature.Top}/{TimeSignature.Bottom}:");
            }
            sb.Append(string.Join(",", Pattern));

            return sb.ToString();
        }
    }
}
