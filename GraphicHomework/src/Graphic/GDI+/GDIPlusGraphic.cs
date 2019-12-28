using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;

namespace GraphicHomework
{
    public class GDIPlusGraphic : CommonGraphics
    {
        public GDIPlusGraphic(Graphics g) {
            this.lib = g;
        }

        protected  Graphics lib;
        public override void DrawElipse(int cx, int cy, int hradius, int vradius)
        {
            lib.DrawEllipse(Pens.Black, cx, cy, hradius, vradius);
        }

        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            lib.DrawLine(Pens.Black, x1, y1, x2, y2);
        }

        public override void DrawRectangle(int x, int y, int width, int height)
        {
            lib.DrawRectangle(Pens.Black, x, y, width, height);
        }

    
    }
}