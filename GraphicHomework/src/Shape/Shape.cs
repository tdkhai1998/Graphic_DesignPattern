using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public abstract class Shape
    {
        public Shape(ShapeInfo f)
        {
            this.ShapeInfo = f;
        }
        public ShapeInfo ShapeInfo;
      

        public abstract void Draw(CommonGraphics g);
        

    }
}