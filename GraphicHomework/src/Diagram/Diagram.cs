using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public class Diagram : Shape
    {
        public Diagram(ShapeInfo f) : base(f)
        {
        }

        public List<GraphicHomework.Block> Block
        {
            get => default;
            set
            {
            }
        }

        public override void Draw(CommonGraphics g)
        {
            throw new NotImplementedException();
        }
    }
}