using System;
using System.Linq;

namespace NetNotes.Business.Elements
{
    public struct KeySignature : IEquatable<KeySignature>
    {
        internal KeySignature(string name)
        {
            switch (name.ToUpperInvariant().Replace("-", "").Replace("MAJOR", "")
                .Replace("MINOR", "m").Replace("FLAT", "♭").Replace("#", "♯")
                .Replace("SHARP", "♯"))
            {
                case "C":
                case "Am":
                    MajorName = "C";
                    MinorName = "A";
                    NumberOfFlats = 0;
                    NumberOfSharps = 0;
                    break;
                case "F":
                case "Dm":
                    MajorName = "F";
                    MinorName = "D";
                    NumberOfFlats = 1;
                    NumberOfSharps = 0;
                    break;
                case "BB":
                case "B♭":
                case "Gm":
                    MajorName = "B♭";
                    MinorName = "G";
                    NumberOfFlats = 2;
                    NumberOfSharps = 0;
                    break;
                case "EB":
                case "E♭":
                case "Cm":
                    MajorName = "E♭";
                    MinorName = "C";
                    NumberOfFlats = 3;
                    NumberOfSharps = 0;
                    break;
                case "AB":
                case "A♭":
                case "Fm":
                    MajorName = "A♭";
                    MinorName = "F";
                    NumberOfFlats = 4;
                    NumberOfSharps = 0;
                    break;
                case "DB":
                case "D♭":
                case "B♭m":
                    MajorName = "D♭";
                    MinorName = "B♭";
                    NumberOfFlats = 5;
                    NumberOfSharps = 0;
                    break;
                case "GB":
                case "G♭":
                case "EBm":
                case "E♭m":
                    MajorName = "G♭";
                    MinorName = "E♭";
                    NumberOfFlats = 6;
                    NumberOfSharps = 0;
                    break;
                case "CB":
                case "C♭":
                case "ABm":
                case "A♭m":
                    MajorName = "C♭";
                    MinorName = "A♭";
                    NumberOfFlats = 7;
                    NumberOfSharps = 0;
                    break;
                case "G":
                case "Em":
                    MajorName = "G";
                    MinorName = "E";
                    NumberOfFlats = 0;
                    NumberOfSharps = 1;
                    break;
                case "D":
                case "Bm":
                    MajorName = "D";
                    MinorName = "B";
                    NumberOfFlats = 0;
                    NumberOfSharps = 2;
                    break;
                case "A":
                case "F♯m":
                    MajorName = "A";
                    MinorName = "F♯";
                    NumberOfFlats = 0;
                    NumberOfSharps = 3;
                    break;
                case "E":
                case "C♯m":
                    MajorName = "E";
                    MinorName = "C♯";
                    NumberOfFlats = 0;
                    NumberOfSharps = 4;
                    break;
                case "B":
                case "G♯m":
                    MajorName = "B";
                    MinorName = "G♯";
                    NumberOfFlats = 0;
                    NumberOfSharps = 5;
                    break;
                case "F♯":
                case "D♯m":
                    MajorName = "F♯";
                    MinorName = "D♯";
                    NumberOfFlats = 0;
                    NumberOfSharps = 6;
                    break;
                case "C♯":
                case "A♯m":
                    MajorName = "C♯";
                    MinorName = "A♯";
                    NumberOfFlats = 0;
                    NumberOfSharps = 7;
                    break;
                default:
                    throw new UnknownKeySignatureException();
            }
        }

        internal KeySignature(int numberOfSharps, int numberOfFlats)
        {
            NumberOfSharps = numberOfSharps;
            NumberOfFlats = numberOfFlats;
            MajorName = "C";
            MinorName = "A";

            switch (numberOfSharps)
            {
                case 1:
                    MajorName = "G";
                    MinorName = "E";
                    break;
                case 2:
                    MajorName = "D";
                    MinorName = "B";
                    break;
                case 3:
                    MajorName = "A";
                    MinorName = "F♯";
                    break;
                case 4:
                    MajorName = "E";
                    MinorName = "C♯";
                    break;
                case 5:
                    MajorName = "B";
                    MinorName = "G♯";
                    break;
                case 6:
                    MajorName = "F♯";
                    MinorName = "D♯";
                    break;
                case 7:
                    MajorName = "C♯";
                    MinorName = "A♯";
                    break;
            }
            switch (numberOfFlats)
            {
                case 1:
                    MajorName = "F";
                    MinorName = "D";
                    break;
                case 2:
                    MajorName = "B♭";
                    MinorName = "G";
                    break;
                case 3:
                    MajorName = "E♭";
                    MinorName = "C";
                    break;
                case 4:
                    MajorName = "A♭";
                    MinorName = "F";
                    break;
                case 5:
                    MajorName = "D♭";
                    MinorName = "B♭";
                    break;
                case 6:
                    MajorName = "G♭";
                    MinorName = "E♭";
                    break;
                case 7:
                    MajorName = "C♭";
                    MinorName = "A♭";
                    break;
            }
        }

        public int NumberOfSharps { get; }
        public int NumberOfFlats { get; }
        public string MajorName { get; }
        public string MinorName { get; }


        public bool Equals(KeySignature other)
        {
            return other.NumberOfFlats == NumberOfFlats && other.NumberOfSharps == NumberOfSharps;
        }
    }

    public static class KeySignatures
    {
        public static KeySignature CMajor => new KeySignature("C");
        public static KeySignature FMajor => new KeySignature("F");
        public static KeySignature BFlatMajor => new KeySignature("B♭");
        public static KeySignature EFlatMajor => new KeySignature("E♭");
        public static KeySignature AFlatMajor => new KeySignature("A♭");
        public static KeySignature DFlatMajor => new KeySignature("D♭");
        public static KeySignature GFlatMajor => new KeySignature("G♭");
        public static KeySignature GMajor => new KeySignature("G");
        public static KeySignature DMajor => new KeySignature("D");
        public static KeySignature AMajor => new KeySignature("A");
        public static KeySignature EMajor => new KeySignature("E");
        public static KeySignature BMajor => new KeySignature("B");
        public static KeySignature FSharpMajor => new KeySignature("F♯");
        public static KeySignature CSharpMajor => new KeySignature("C♯");
        public static KeySignature AMinor => CMajor;
        public static KeySignature DMinor => FMajor;
        public static KeySignature GMinor => BFlatMajor;
        public static KeySignature CMinor => EFlatMajor;
        public static KeySignature FMinor => AFlatMajor;
        public static KeySignature BFlatMinor => DFlatMajor;
        public static KeySignature EFlatMinor => GFlatMajor;
        public static KeySignature EMinor => GMajor;
        public static KeySignature BMinor => DMajor;
        public static KeySignature FSharpMinor => AMajor;
        public static KeySignature CSharpMinor => EMajor;
        public static KeySignature GSharpMinor => BMajor;
        public static KeySignature DSharpMinor => FSharpMajor;
        public static KeySignature ASharpMinor => CSharpMajor;

        public static KeySignature GetKey(string name)
        {
            name = name.ToUpperInvariant().Replace("-", "").Replace("MAJOR", "")
                .Replace("MINOR", "m").Replace("FLAT", "♭").Replace("#", "♯")
                .Replace("SHARP", "♯");

            if (name.StartsWith("BB"))
            {
                name = name.Replace("BB", "B♭");
            }
            else if (name.Substring(1).Contains('B'))
            {
                name = name.Replace('B', '♭');
            }

            if (name.Last() == 'm')
            {
                name = name.Trim('m');
                return AllKeys.First(k => k.MinorName.ToUpperInvariant().Equals(name.ToUpperInvariant()));
            }

            return AllKeys.First(k => k.MajorName.ToUpperInvariant().Equals(name.ToUpperInvariant()));
        }

        private static KeySignature[] AllKeys =
        {
            CMajor, FMajor, BFlatMajor, EFlatMajor, AFlatMajor, DFlatMajor, GFlatMajor,
            GMajor, DMajor, AMajor, EMajor, BMajor, FSharpMajor, CSharpMajor,
            AMinor, DMinor, GMinor, CMinor, FMinor, BFlatMinor, EFlatMinor,
            EMinor, BMinor, FSharpMinor, CSharpMinor, GSharpMinor, DSharpMinor, ASharpMinor
        };
    }

    public class UnknownKeySignatureException: Exception { }
}
