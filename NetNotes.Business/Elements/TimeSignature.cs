using System;
using System.Linq;

namespace NetNotes.Business.Elements
{
    public struct TimeSignature
    {
        public TimeSignature(string input)
        {
            var parts = input.Split("/");
            if (int.TryParse(parts[0], out var top) &&
                int.TryParse(parts[1], out var bottom))
            {
                Top = top;
                Bottom = bottom;

                if (Top % 3 == 0 && (Bottom > 4 || Top > 3))
                {
                    MeterType = MeterType.Compound;
                    Beats = Top / 3;
                    var subBeat = Durations.All().FirstOrDefault(d => d.TimeSymbol == bottom && d.Dots == 0);
                    BeatDuration = Durations.All().FirstOrDefault(d => d.CommonTimeBeatLength == (subBeat.CommonTimeBeatLength * 3));
                }
                else if (Top % 2 == 1)
                {
                    MeterType = MeterType.Mixed;
                    Beats = ((Top % 3) / 2) + (Top / 3);
                    BeatDuration = null;
                }
                else
                {
                    MeterType = MeterType.Simple;
                    Beats = Top;
                    BeatDuration = Durations.All().FirstOrDefault(d => d.TimeSymbol == bottom && d.Dots == 0);
                }
            }
            else
            {
                throw new UnrecognizedTimeSignatureException();
            }
        }

        public TimeSignature(int top, int bottom)
        {
            try
            {
                Top = top;
                Bottom = bottom;

                if (Top % 3 == 0 && (Bottom > 4 || Top > 3))
                {
                    MeterType = MeterType.Compound;
                    Beats = Top / 3;
                    var subBeat = Durations.All().FirstOrDefault(d => d.TimeSymbol == bottom && d.Dots == 0);
                    BeatDuration = Durations.All().FirstOrDefault(d => d.CommonTimeBeatLength == (subBeat.CommonTimeBeatLength * 3));
                }
                else if (Top % 2 == 1)
                {
                    MeterType = MeterType.Mixed;
                    Beats = ((Top % 3) / 2) + (Top / 3);
                    BeatDuration = null;
                }
                else
                {
                    MeterType = MeterType.Simple;
                    Beats = Top;
                    BeatDuration = Durations.All().FirstOrDefault(d => d.TimeSymbol == bottom && d.Dots == 0);
                }
            }
            catch
            {
                throw new UnknownTimeSignatureException();
            }
        }

        public int Top { get; }
        public int Bottom { get; }
        public MeterType MeterType { get; }
        public int Beats { get; }
        public Duration? BeatDuration { get; }
    }

    public enum MeterType 
    {
        Simple,
        Compound,
        Mixed
    }


    public static class TimeSignatures
    {
        public static TimeSignature CommonTime => new TimeSignature(4, 4);
        public static TimeSignature CutTime => new TimeSignature(2, 2);
        public static TimeSignature _4_4 => CommonTime;
        public static TimeSignature _3_4 => new TimeSignature(3, 4);
        public static TimeSignature _2_4 => new TimeSignature(2, 4);
        public static TimeSignature _6_8 => new TimeSignature(6, 8);
        public static TimeSignature _9_8 => new TimeSignature(9, 8);
        public static TimeSignature _12_8 => new TimeSignature(12, 8);
        public static TimeSignature _5_4 => new TimeSignature(5, 4);
        public static TimeSignature _3_8 => new TimeSignature(3, 8);
        public static TimeSignature _2_2 => CutTime;
        public static TimeSignature _3_2 => new TimeSignature(3, 2);
        public static TimeSignature _4_2 => new TimeSignature(4, 2);

        public static TimeSignature GetTime(string input)
        {
            try
            {
                var timeParts = input.Split("/", StringSplitOptions.RemoveEmptyEntries);
                return AllTimes.FirstOrDefault(t => t.Top == int.Parse(timeParts[0]) && t.Bottom == int.Parse(timeParts[1]));
            }
            catch
            {
                return new TimeSignature(input);
            }

        }

        private static TimeSignature[] AllTimes =
        {
            _4_4, _3_4, _2_4, _6_8, _9_8, _12_8, _5_4, _3_8, _2_2, _3_2, _4_2
        };
    }


    public class UnknownTimeSignatureException: Exception { }
}
