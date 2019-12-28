using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public class Line : Shape
    {
        public Line(ShapeInfo f) : base(f) { }
        public override void Draw(CommonGraphics g)
        {
            g.DrawLine(ShapeInfo.start.X, ShapeInfo.start.Y, ShapeInfo.end.X, ShapeInfo.end.Y);
        }
    }
}