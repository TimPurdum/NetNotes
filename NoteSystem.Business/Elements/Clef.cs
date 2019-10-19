using System;

namespace NoteSystem.Business.Elements
{
    public struct Clef: IEquatable<Clef>
    {
        internal Clef(int line, char note, string name)
        {
            KeyLine = line;
            KeyNote = note;
            Name = name;
        }

        public int KeyLine { get; }
        public char KeyNote { get; }
        public string Name { get; }

        public bool Equals(Clef other)
        {
            return other.KeyLine == KeyLine &&
                other.KeyNote == KeyNote &&
                other.Name == Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Clef other)
            {
                return Equals(other);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(KeyLine, KeyNote, Name);
        }

        public static bool operator ==(Clef left, Clef right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Clef left, Clef right)
        {
            return !(left == right);
        }
    }


    public static class Clefs
    {
        public static Clef Treble => new Clef(2, 'G', "Treble");
        public static Clef Bass => new Clef(4, 'F', "Bass");
        public static Clef Alto => new Clef(3, 'C', "Alto");
        public static Clef Tenor => new Clef(4, 'C', "Tenor");
        public static Clef FrenchViolin => new Clef(1, 'G', "French Violin");
        public static Clef Soprano => new Clef(1, 'C', "Soprano");
        public static Clef MezzoSoprano => new Clef(2, 'C', "Mezzo-Soprano");
        public static Clef Baritone => new Clef(3, 'F', "Baritone");
        public static Clef SubBass => new Clef(5, 'F', "SubBass");
    }
}