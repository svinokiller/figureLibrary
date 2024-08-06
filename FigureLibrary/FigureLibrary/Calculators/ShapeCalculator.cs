using FigureLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Calculators
{
    public static class ShapeCalculator
    {
        public static double CalcArea(IShape shape)
        {
            return shape.CalcArea();
        }
    }
}
