using FigureLibrary.Calculators;
using FigureLibrary.Interfaces;
using FigureLibrary.Impl;

namespace FigureLibrary.Tests
{
    [TestClass]
    public class ShapeCalcTests
    {
        [TestMethod]
        public void CalcAreaWithCircle()
        {
            IShape circle = new Circle(7);
            double expectedArea = Math.PI * Math.Pow(7, 2);

            double actualArea = ShapeCalculator.CalcArea(circle);

            Assert.AreEqual(expectedArea, actualArea, 1e-9);
        }

        [TestMethod]
        public void CalcAreaWithTriangle()
        {
            IShape triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;

            double actualArea = ShapeCalculator.CalcArea(triangle);

            Assert.AreEqual(expectedArea, actualArea, 1e-9);
        }
    }
}