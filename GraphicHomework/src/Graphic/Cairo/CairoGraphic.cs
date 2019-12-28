using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cairo;
using System.Drawing;
using System.Reflection;
using System.Drawing.Drawing2D;

namespace GraphicHomework
{
    public class CairoGraphic : CommonGraphics
    {
        public CairoGraphic(System.Drawing.Graphics g)
        {
            Console.WriteLine("create Cairo");
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Surface1 = new Win32Surface(g.GetHdc());
            g.ReleaseHdc();
            lib = new Context(Surface1);
        }
        public Context lib;
        private readonly Win32Surface Surface1;

        public override void DrawElipse(int x, int y, int width, int height)
        {
 
            lib.Save();
            lib.Translate(x, y);
            lib.Scale(width / 2.0, height / 2.0);
            lib.Arc(0.0, 0.0, 1.0, 0.0, 2 * Math.PI);
            lib.Restore();
            lib.Stroke();
        }

        public override void DrawLine(int x1, int y1, int x2, int y2)
        {

            lib.MoveTo(x1, y1);
            lib.LineTo(x2, y2);
            lib.Stroke();
        }

        public override void DrawRectangle(int x, int y, int width, int height)
        {
            lib.Rectangle(x, y, width, height);
            lib.Stroke();

        }

        public override void Release() {
            Surface1.Dispose();
            lib.Dispose();
        } 
    }
}