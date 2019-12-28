using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public class DFInputBlock : Block
    {
        public DFInputBlock(ShapeInfo f) : base(f)
        {
        }

        public override void Draw(CommonGraphics g)
        {
            Point start = ShapeInfo.start;
            Point end = ShapeInfo.end;
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            float alpha = 0.2F;
            int withDel = 20;
            g.DrawRectangle(start.X, start.Y, width, height);
            g.DrawLine(start.X + withDel, start.Y, start.X + withDel, end.Y); 
            g.DrawLine(end.X - withDel, start.Y, end.X - withDel, end.Y);
        }
    }
}