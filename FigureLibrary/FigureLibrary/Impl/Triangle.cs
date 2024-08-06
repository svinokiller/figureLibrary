using FigureLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Impl
{
    public class Triangle : IShape
    {
        public double A {  get; }
        public double B { get; }
        public double C { get; }
        public Triangle(double a, double b, double c) {

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("sides must be non-zero positive.");
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("sum of any two sides must be greater than third side.");
            }
            A = a; B = b; C = c;
        }
        public double CalcArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        
    }
}
