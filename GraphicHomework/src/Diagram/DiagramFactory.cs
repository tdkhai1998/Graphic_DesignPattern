using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public  abstract class DiagramFactory
    {
        public  abstract Block CreateInputBlock(ShapeInfo f);
        public  abstract Block CreateStartBlock(ShapeInfo f);
    }
}