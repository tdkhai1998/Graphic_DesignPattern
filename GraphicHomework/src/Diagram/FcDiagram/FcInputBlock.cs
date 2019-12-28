using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public class FcInputBlock : Block
    {
        public FcInputBlock(ShapeInfo f) : base(f)
        {
        }

        public override void Draw(CommonGraphics g)
        {
            Point start = ShapeInfo.start;
            Point end = ShapeInfo.end;
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            int withDel = 20;
            g.DrawLine(start.X + withDel, start.Y, end.X, start.Y);
            g.DrawLine(start.X + withDel, start.Y, start.X, end.Y);
            g.DrawLine(start.X, end.Y, end.X - withDel, end.Y);
            g.DrawLine(end.X - withDel, end.Y, end.X, start.Y);
        }
    }
}