using FigureLibrary.Calculators;
using FigureLibrary.Interfaces;
using FigureLibrary.Impl;
using FigureLibrary.Utilites;

namespace FigureLibrary.Tests
{
    [TestClass]
    public class TriangleUtilsTests
    {
        [TestMethod]
        public void IsRightTriangleWithRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            bool result = TriangleUtils.IsRightTriangle(triangle);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRightTriangleWithNonRightTriangle()
        {
            var triangle = new Triangle(5, 5, 5);

            bool result = TriangleUtils.IsRightTriangle(triangle);

            Assert.IsFalse(result);
        }
    }
}