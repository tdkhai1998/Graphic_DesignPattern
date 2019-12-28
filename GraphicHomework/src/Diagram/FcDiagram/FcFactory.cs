using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public class FcFactory : DiagramFactory
    {
        public override Block CreateInputBlock(ShapeInfo f)
        {
            return new FcInputBlock(f);
        }

        public override Block CreateStartBlock(ShapeInfo f)
        {
            return new FcInputBlock(f);
        }
    }
}
