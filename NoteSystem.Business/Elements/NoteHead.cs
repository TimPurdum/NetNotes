using System;

namespace NoteSystem.Business.Elements
{
    public struct NoteHead
    {
        public NoteHead(NoteHeadShape shape)
        {
            Shape = shape;
        }

        public NoteHeadShape Shape { get; set; }
    }

    public enum NoteHeadShape
    {
        OpenOval,
        ClosedOval,
        OpenCircle,
        ClosedCircle,
        X,
        Triangle
    }
}
