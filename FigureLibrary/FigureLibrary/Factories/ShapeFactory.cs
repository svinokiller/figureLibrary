using FigureLibrary.Impl;
using FigureLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Factories
{
    public static class ShapeFactory
    {
        public static IShape CreateShape(string shapeType, params double[] parameters)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    if (parameters.Length == 1)
                    {
                        return new Circle(parameters[0]);
                    }
                    throw new ArgumentException("сircle requires one parameter: radius.");

                case "triangle":
                    if (parameters.Length == 3)
                    {
                        return new Triangle(parameters[0], parameters[1], parameters[2]);
                    }
                    throw new ArgumentException("triangle requires three parameters: side A, side B, side C.");

                default:
                    throw new ArgumentException("unknown shape type.");
            }
        }
    }
}
