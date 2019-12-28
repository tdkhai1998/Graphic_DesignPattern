using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphicHomework
{
    public class DfdDiagramFactory : DiagramFactory
    {
        public  override Block CreateInputBlock(ShapeInfo f)
        {
            return new DFInputBlock(f);
        }

        public override Block CreateStartBlock(ShapeInfo f)
        {
            return new DFStartBlock(f);
        }
    }
}