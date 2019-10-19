using System;
using System.Linq;

namespace NoteSystem.Business.Elements
{
    public struct TimeSignature
    {
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
    }


    public class UnknownTimeSignatureException: Exception { }
}
