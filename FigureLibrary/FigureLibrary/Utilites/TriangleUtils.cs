using FigureLibrary.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Utilites
{
    public static class TriangleUtils
    {
        public static bool IsRightTriangle(Triangle triangle)
        {
            var a = triangle.A;
            var b = triangle.B;
            var c = triangle.C;

            double[] sides = { a, b, c };
            Array.Sort(sides);

            //гипотенуза^2 - (катет^2 + катет^2)
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-9;
            
        }

    }
}
