using System;
using System.Collections.Generic;
using System.Text;

namespace NetNotes.Business.Elements
{
    public enum Barline
    {
        Single,
        Double,
        End, // double barline with second, thicker line
        EndRepeat,
        StartRepeat
    }
}
