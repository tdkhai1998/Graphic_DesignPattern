using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public class Rec : Shape
    {
        public Rec(ShapeInfo f) : base(f) { }
        public override void Draw(CommonGraphics g)
        {
            Point start = ShapeInfo.start;
            Point end = ShapeInfo.end;
            g.DrawRectangle(start.X, start.Y, Math.Abs(start.X-end.X), Math.Abs(start.Y - end.Y));
        }
    }
}