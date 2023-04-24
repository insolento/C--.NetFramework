using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    internal class Triangle : GeometricFigure
    {
        public override double ComputeArea()
        {
            return Width*Height/2;
        }
    }
}
