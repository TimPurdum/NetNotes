using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetNotes.Business.Elements
{
    public struct Duration
    {
        internal Duration(string name, int dots = 0)
        {
            if (name.EndsWith(".") && dots == 0)
            {
                dots = name.Count(c => c == '.');
            }
            switch (name.ToUpperInvariant().Replace(".", ""))
            {
                case "QUARTER":
                case "Q":
                case "4":
                    Name = "Quarter";
                    CommonTimeBeatLength = 1.0;
                    TimeSymbol = 4;
                    Flags = 0;
                    break;
                case "HALF":
                case "H":
                case "2":
                    Name = "Half";
                    CommonTimeBeatLength = 2.0;
                    TimeSymbol = 2;
                    Flags = 0;
                    break;
                case "WHOLE":
                case "W":
                case "1":
                    Name = "Whole";
                    CommonTimeBeatLength = 4.0;
                    TimeSymbol = 1;
                    Flags = 0;
                    break;
                case "EIGHTH":
                case "E":
                case "8":
                case "8TH":
                    Name = "Eighth";
                    CommonTimeBeatLength = 0.5;
                    TimeSymbol = 8;
                    Flags = 1;
                    break;
                case "SIXTEENTH":
                case "S":
                case "16":
                case "16TH":
                    Name = "Quarter";
                    CommonTimeBeatLength = 0.25;
                    TimeSymbol = 16;
                    Flags = 2;
                    break;
                case "THIRTYSECOND":
                case "T":
                case "32":
                case "32ND":
                    Name = "ThirtySecond";
                    CommonTimeBeatLength = 0.125;
                    TimeSymbol = 32;
                    Flags = 3;
                    break;
                default:
                    throw new UnknownDurationException(name);
            }

            Dots = dots;
            if (Dots == 1)
            {
                CommonTimeBeatLength *= 1.5;
                Name = $"Dotted {Name}";
            }
            else if (Dots == 2)
            {
                CommonTimeBeatLength *= 2.25;
                Name = $"Double Dotted {Name}";
            }
        }

        public string Name { get; }
        public double CommonTimeBeatLength { get; }
        public int Dots { get; }
        public int TimeSymbol { get; }
        public int Flags { get; }

        public override string ToString()
        {
            var sb = new StringBuilder(TimeSymbol.ToString());
            for (var i = 0; i < Dots; i++)
            {
                sb.Append('.');
            }
            return sb.ToString();
        }
    }


    public static class Durations
    {
        public static Duration Quarter => new Duration("Quarter");
        public static Duration Half => new Duration("Half");
        public static Duration Whole => new Duration("Whole");
        public static Duration Eighth => new Duration("Eighth");
        public static Duration Sixteenth => new Duration("Sixteenth");
        public static Duration ThirtySecond => new Duration("ThirtySecond");
        public static Duration DottedQuarter => new Duration("Quarter", 1);
        public static Duration DottedHalf => new Duration("Half", 1);
        public static Duration DottedWhole => new Duration("Whole", 1);
        public static Duration DottedEighth => new Duration("Eighth", 1);
        public static Duration DottedSixteenth => new Duration("Sixteenth", 1);
        public static Duration DottedThirtySecond => new Duration("ThirtySecond", 1);

        public static IEnumerable<Duration> All()
        {
            return new Duration[]
            {
                Quarter, Half, Whole, Eighth, Sixteenth, ThirtySecond,
                DottedQuarter, DottedHalf, DottedWhole, DottedEighth, DottedSixteenth, DottedThirtySecond
            };
        }
    }


    public class UnknownDurationException : Exception 
    {
        public UnknownDurationException(string message) : base(message)
        {
        }
    }
}