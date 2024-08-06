using FigureLibrary.Interfaces;
using FigureLibrary.Impl;
using FigureLibrary.Factories;

namespace FigureLibrary.Tests
{
    [TestClass]
    public class ShapeFactoryTests
    {
        [TestMethod]
        public void CreateShapeWithCircle()
        {
            IShape shape = ShapeFactory.CreateShape("circle", 5);

            Assert.IsInstanceOfType(shape, typeof(Circle));
            Assert.AreEqual(5, ((Circle)shape).Radius);
        }

        [TestMethod]
        public void CreateShapeWithTriangle()
        {
            IShape shape = ShapeFactory.CreateShape("triangle", 3, 4, 5);

            Assert.IsInstanceOfType(shape, typeof(Triangle));
            var triangle = (Triangle)shape;
            Assert.AreEqual(3, triangle.A);
            Assert.AreEqual(4, triangle.B);
            Assert.AreEqual(5, triangle.C);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateShapeWithInvalidCircleParams()
        {
            ShapeFactory.CreateShape("circle", 5, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateShapeWithInvalidTriangleParams()
        {
            ShapeFactory.CreateShape("triangle", 3, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateShapeWithUnknownShapeType()
        {
            ShapeFactory.CreateShape("hexagon", 5);
        }
    }
}