using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public class Ellipse : Shape
    {
        Point start;
        Point end;
        public Ellipse(ShapeInfo f) : base(f) {
            this.start = start;
            this.end = end;
        }
        public override void Draw(CommonGraphics g)
        {
            
            int CenterX = (start.X + end.X)/2;
            int CenterY = (start.Y + end.Y)/2;
            int v = Math.Abs(start.Y - end.Y);
            int h = Math.Abs(start.X - end.X);
            g.DrawElipse(CenterX, CenterY, h, v);
          
        }

    
    }
}