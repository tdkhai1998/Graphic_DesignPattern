using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public abstract class CommonGraphics
    {
       
        public abstract void DrawLine(int x1, int y1, int x2, int y2);
        public abstract void DrawRectangle(int x, int y, int width, int height);
        public abstract void DrawElipse(int cx, int cy, int hradius, int vradius);

        public virtual void Release()
        {
            Console.WriteLine("Release graphic----------------------------------");
        }
    }
}