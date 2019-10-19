using System;
using System.Linq;

namespace NoteSystem.Business.Elements
{
    public struct Pitch
    {
        internal Pitch(string name)
        {
            try
            {
                var cleanName = name.ToUpperInvariant().Replace("-", "").Replace("FLAT", "♭").Replace("#", "♯")
                .Replace("SHARP", "♯");
                LetterName = cleanName[0];

                var flats = cleanName.Count(c => c == '♭');
                var sharps = cleanName.Count(c => c == '♯');

                Accidental = sharps - flats;

                var octaveString = cleanName.Replace(LetterName.ToString(), "").Replace("♭", "").Replace("♯", "");
                if (int.TryParse(octaveString, out var o))
                {
                    Octave = o;
                }
                else
                {
                    Octave = 4;
                }
            }
            catch
            {
                throw new UnknownPitchException();
            }
        }

        public Pitch(char letterName, int octave, int accidental)
        {
            LetterName = letterName;
            Octave = octave;
            Accidental = accidental;
        }


        public char LetterName { get; }
        public int Octave { get; }
        
        // Accidental 0 == natural, -1 == flat, +1 == sharp
        public int Accidental { get; }
        
        // Position 0 is middle C (C4)
        public int StaffLocation { 
            get {
                var pitchLocation = LetterName - 'C';
                if (pitchLocation < 0)
                {
                    pitchLocation += 7;
                }
                var octaveOffset = (Octave - 4) * 7;
                return octaveOffset + pitchLocation;
            } 
        }


        public string Name { 
            get {
                var accidentalString = "";
                if (Accidental < 0)
                {
                    for (var i = 0; i > Accidental; i--)
                    {
                        accidentalString += "♭";
                    }
                }
                else
                {
                    for (var j = 0; j < Accidental; j++)
                    {
                        accidentalString += "♯";
                    }
                }
                return $"{LetterName}{accidentalString}{Octave}";
            } 
        }
        
        
        public Pitch Enharmonic(bool higher = false)
        {
            char newLetter;
            int newOctave = Octave;
            int newAccidental;

            switch (Accidental)
            {
                case -2:
                    newLetter = (char)((int)LetterName - 1);
                    newAccidental = 0;
                    switch (LetterName)
                    {
                        case 'A':
                            newLetter = 'G';
                            break;
                        case 'C':
                            newOctave = Octave - 1;
                            newAccidental = -1;
                            break;
                        case 'F':
                            newAccidental = -1;
                            break;
                    }
                    break;
                case -1:
                    newLetter = (char)((int)LetterName - 1);
                    newAccidental = 1;
                    switch (LetterName)
                    {
                        case 'A':
                            newLetter = 'G';
                            break;
                        case 'C':
                            newOctave = Octave - 1;
                            newAccidental = 0;
                            break;
                        case 'F':
                            newAccidental = 0;
                            break;
                    }
                    break;
                case 0:
                    switch (LetterName) 
                    {
                        case 'C':
                            newLetter = 'B';
                            newOctave = Octave - 1;
                            newAccidental = 1;
                            break;
                        case 'F':
                            newLetter = 'E';
                            newAccidental = 1;
                            break;
                        case 'B':
                            newLetter = 'C';
                            newOctave = Octave + 1;
                            newAccidental = -1;
                            break;
                        case 'E':
                            newLetter = 'F';
                            newAccidental = -1;
                            break;
                        default:
                            if (higher)
                            {
                                newLetter = (char)((int)LetterName + 1);
                                newAccidental = -2;
                            }
                            else
                            {
                                newLetter = (char)((int)LetterName - 1);
                                newAccidental = 2;
                            }
                            break;
                    }
                    break;
                case 1:
                    newLetter = (char)((int)LetterName + 1);
                    newAccidental = -1;

                    switch (LetterName) 
                    {
                        case 'B':
                            newOctave = Octave + 1;
                            newAccidental = 0;
                            break;
                        case 'G':
                            newLetter = 'A';
                            break;
                        case 'E':
                            newAccidental = 0;
                            break;
                    }
                    break;
                case 2:
                    newLetter = (char)((int)LetterName + 1);
                    newAccidental = 0;

                    switch (LetterName)
                    {
                        case 'B':
                            newOctave = Octave + 1;
                            newAccidental = 1;
                            break;
                        case 'G':
                            newLetter = 'A';
                            break;
                        case 'E':
                            newAccidental = 1;
                            break;
                    }
                    break;
                default:
                    throw new UnknownPitchException();
            }

            return new Pitch(newLetter, newOctave, newAccidental);
        }
    }


    public static class Pitches
    {
        public static Pitch C0 => new Pitch("C0");
        public static Pitch CSharp0 => new Pitch("CSharp0");
        public static Pitch DFlat0 => new Pitch("DFlat0");
        public static Pitch D0 => new Pitch("D0");
        public static Pitch DSharp0 => new Pitch("DSharp0");
        public static Pitch EFlat0 => new Pitch("EFlat0");
        public static Pitch E0 => new Pitch("E0");
        public static Pitch F0 => new Pitch("F0");
        public static Pitch FSharp0 => new Pitch("FSharp0");
        public static Pitch GFlat0 => new Pitch("GFlat0");
        public static Pitch G0 => new Pitch("G0");
        public static Pitch GSharp0 => new Pitch("GSharp0");
        public static Pitch AFlat0 => new Pitch("AFlat0");
        public static Pitch A0 => new Pitch("A0");
        public static Pitch ASharp0 => new Pitch("ASharp0");
        public static Pitch BFlat0 => new Pitch("BFlat0");
        public static Pitch B0 => new Pitch("B0");
        public static Pitch C1 => new Pitch("C1");
        public static Pitch CSharp1 => new Pitch("CSharp1");
        public static Pitch DFlat1 => new Pitch("DFlat1");
        public static Pitch D1 => new Pitch("D1");
        public static Pitch DSharp1 => new Pitch("DSharp1");
        public static Pitch EFlat1 => new Pitch("EFlat1");
        public static Pitch E1 => new Pitch("E1");
        public static Pitch F1 => new Pitch("F1");
        public static Pitch FSharp1 => new Pitch("FSharp1");
        public static Pitch GFlat1 => new Pitch("GFlat1");
        public static Pitch G1 => new Pitch("G1");
        public static Pitch GSharp1 => new Pitch("GSharp1");
        public static Pitch AFlat1 => new Pitch("AFlat1");
        public static Pitch A1 => new Pitch("A1");
        public static Pitch ASharp1 => new Pitch("ASharp1");
        public static Pitch BFlat1 => new Pitch("BFlat1");
        public static Pitch B1 => new Pitch("B1");
        public static Pitch C2 => new Pitch("C2");
        public static Pitch CSharp2 => new Pitch("CSharp2");
        public static Pitch DFlat2 => new Pitch("DFlat2");
        public static Pitch D2 => new Pitch("D2");
        public static Pitch DSharp2 => new Pitch("DSharp2");
        public static Pitch EFlat2 => new Pitch("EFlat2");
        public static Pitch E2 => new Pitch("E2");
        public static Pitch F2 => new Pitch("F2");
        public static Pitch FSharp2 => new Pitch("FSharp2");
        public static Pitch GFlat2 => new Pitch("GFlat2");
        public static Pitch G2 => new Pitch("G2");
        public static Pitch GSharp2 => new Pitch("GSharp2");
        public static Pitch AFlat2 => new Pitch("AFlat2");
        public static Pitch A2 => new Pitch("A2");
        public static Pitch ASharp2 => new Pitch("ASharp2");
        public static Pitch BFlat2 => new Pitch("BFlat2");
        public static Pitch B2 => new Pitch("B2");
        public static Pitch C3 => new Pitch("C3");
        public static Pitch CSharp3 => new Pitch("CSharp3");
        public static Pitch DFlat3 => new Pitch("DFlat3");
        public static Pitch D3 => new Pitch("D3");
        public static Pitch DSharp3 => new Pitch("DSharp3");
        public static Pitch EFlat3 => new Pitch("EFlat3");
        public static Pitch E3 => new Pitch("E3");
        public static Pitch F3 => new Pitch("F3");
        public static Pitch FSharp3 => new Pitch("FSharp3");
        public static Pitch GFlat3 => new Pitch("GFlat3");
        public static Pitch G3 => new Pitch("G3");
        public static Pitch GSharp3 => new Pitch("GSharp3");
        public static Pitch AFlat3 => new Pitch("AFlat3");
        public static Pitch A3 => new Pitch("A3");
        public static Pitch ASharp3 => new Pitch("ASharp3");
        public static Pitch BFlat3 => new Pitch("BFlat3");
        public static Pitch B3 => new Pitch("B3");
        public static Pitch C4 => new Pitch("C4");
        public static Pitch CSharp4 => new Pitch("CSharp4");
        public static Pitch DFlat4 => new Pitch("DFlat4");
        public static Pitch D4 => new Pitch("D4");
        public static Pitch DSharp4 => new Pitch("DSharp4");
        public static Pitch EFlat4 => new Pitch("EFlat4");
        public static Pitch E4 => new Pitch("E4");
        public static Pitch F4 => new Pitch("F4");
        public static Pitch FSharp4 => new Pitch("FSharp4");
        public static Pitch GFlat4 => new Pitch("GFlat4");
        public static Pitch G4 => new Pitch("G4");
        public static Pitch GSharp4 => new Pitch("GSharp4");
        public static Pitch AFlat4 => new Pitch("AFlat4");
        public static Pitch A4 => new Pitch("A4");
        public static Pitch ASharp4 => new Pitch("ASharp4");
        public static Pitch BFlat4 => new Pitch("BFlat4");
        public static Pitch B4 => new Pitch("B4");
        public static Pitch C5 => new Pitch("C5");
        public static Pitch CSharp5 => new Pitch("CSharp5");
        public static Pitch DFlat5 => new Pitch("DFlat5");
        public static Pitch D5 => new Pitch("D5");
        public static Pitch DSharp5 => new Pitch("DSharp5");
        public static Pitch EFlat5 => new Pitch("EFlat5");
        public static Pitch E5 => new Pitch("E5");
        public static Pitch F5 => new Pitch("F5");
        public static Pitch FSharp5 => new Pitch("FSharp5");
        public static Pitch GFlat5 => new Pitch("GFlat5");
        public static Pitch G5 => new Pitch("G5");
        public static Pitch GSharp5 => new Pitch("GSharp5");
        public static Pitch AFlat5 => new Pitch("AFlat5");
        public static Pitch A5 => new Pitch("A5");
        public static Pitch ASharp5 => new Pitch("ASharp5");
        public static Pitch BFlat5 => new Pitch("BFlat5");
        public static Pitch B5 => new Pitch("B5");
        public static Pitch C6 => new Pitch("C6");
        public static Pitch CSharp6 => new Pitch("CSharp6");
        public static Pitch DFlat6 => new Pitch("DFlat6");
        public static Pitch D6 => new Pitch("D6");
        public static Pitch DSharp6 => new Pitch("DSharp6");
        public static Pitch EFlat6 => new Pitch("EFlat6");
        public static Pitch E6 => new Pitch("E6");
        public static Pitch F6 => new Pitch("F6");
        public static Pitch FSharp6 => new Pitch("FSharp6");
        public static Pitch GFlat6 => new Pitch("GFlat6");
        public static Pitch G6 => new Pitch("G6");
        public static Pitch GSharp6 => new Pitch("GSharp6");
        public static Pitch AFlat6 => new Pitch("AFlat6");
        public static Pitch A6 => new Pitch("A6");
        public static Pitch ASharp6 => new Pitch("ASharp6");
        public static Pitch BFlat6 => new Pitch("BFlat6");
        public static Pitch B6 => new Pitch("B6");
        public static Pitch C7 => new Pitch("C7");
        public static Pitch CSharp7 => new Pitch("CSharp7");
        public static Pitch DFlat7 => new Pitch("DFlat7");
        public static Pitch D7 => new Pitch("D7");
        public static Pitch DSharp7 => new Pitch("DSharp7");
        public static Pitch EFlat7 => new Pitch("EFlat7");
        public static Pitch E7 => new Pitch("E7");
        public static Pitch F7 => new Pitch("F7");
        public static Pitch FSharp7 => new Pitch("FSharp7");
        public static Pitch GFlat7 => new Pitch("GFlat7");
        public static Pitch G7 => new Pitch("G7");
        public static Pitch GSharp7 => new Pitch("GSharp7");
        public static Pitch AFlat7 => new Pitch("AFlat7");
        public static Pitch A7 => new Pitch("A7");
        public static Pitch ASharp7 => new Pitch("ASharp7");
        public static Pitch BFlat7 => new Pitch("BFlat7");
        public static Pitch B7 => new Pitch("B7");
    }


    public class UnknownPitchException: Exception { }
}
