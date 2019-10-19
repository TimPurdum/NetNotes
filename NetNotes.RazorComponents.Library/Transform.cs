using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace NetNotes.RazorComponents.Library
{
    public class Transform
    {
        public Point? Scale { get; set; }
        public Point? Translate { get; set; }
        public double? Rotate { get; set; }

        public override string ToString()
        {
            var s = "";
            if (Scale != null)
            {
                s += $"scale({Scale.Value.X}, {Scale.Value.Y}) ";
            }
            if (Translate != null)
            {
                s += $"translate({Translate.Value.X}px, {Translate.Value.Y}px) ";
            }
            if (Rotate != null)
            {
                s += $"rotate({Rotate.Value}deg)";
            }
            return s.Trim();
        }
    }
}
