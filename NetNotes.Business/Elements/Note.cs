using NetNotes.Business.Elements.Interfaces;
using System.Collections.Generic;

namespace NetNotes.Business.Elements
{
    public class Note: IRhythmUnit
    {
        public Note(Pitch pitch, Duration duration)
        {
            Pitch = pitch;
            Duration = duration;
        }

        public Note(string noteString)
        {
            var parts = noteString.Split('/', '\\');
            Pitch = new Pitch(parts[0]);
            if (parts.Length > 1)
            {
                Duration = new Duration(parts[1]);
            }
            else
            {
                Duration = Durations.Quarter;
            }
        }

        public Pitch Pitch { get; set; }

        public Duration Duration { get; set; }

        public IList<IExpression> Expressions { get; set; }
    }
}
