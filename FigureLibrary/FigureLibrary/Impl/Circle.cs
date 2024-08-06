using FigureLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Impl
{
    public class Circle : IShape
    {
        public double Radius {  get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("radius must be non-zero positive.");
            }
            Radius = radius;
        }
        public double CalcArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
