using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public class FcStartBlock : Block
    {
        public FcStartBlock(ShapeInfo f) : base(f)
        {
        }

        public override void Draw(CommonGraphics g)
        {
            Point start = ShapeInfo.start;
            Point end = ShapeInfo.end;
            int CenterX = (start.X + end.X) / 2;
            int CenterY = (start.Y + end.Y) / 2;
            int v = Math.Abs(start.Y - end.Y);
            int h = Math.Abs(start.X - end.X);
            g.DrawElipse(CenterX, CenterY, h, v);
        }
    }
}