using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaOfRightTriangleModule
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculteAreaOfRightTriangleTest1_1()
        {
            Area.CalculteAreaOfRightTriangle(0, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculteAreaOfRightTriangleTest1_2()
        {
            Area.CalculteAreaOfRightTriangle(-10, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculteAreaOfRightTriangleTest2_1()
        {
            Area.CalculteAreaOfRightTriangle(4, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculteAreaOfRightTriangleTest2_2()
        {
            Area.CalculteAreaOfRightTriangle(10, -5);
        }

        [TestMethod]
        public void CalculteAreaOfRightTriangleTest3()
        {
            var rezult = Area.CalculteAreaOfRightTriangle(2.5, 5);
            Assert.AreEqual(rezult, 6.25);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculteAreaOfRightTriangleTest4_1()
        {
            Area.CalculteAreaOfRightTriangle(0, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void CalculteAreaOfRightTriangleTest4_2()
        {
            Area.CalculteAreaOfRightTriangle(-1, -1);
        }
    }
}
