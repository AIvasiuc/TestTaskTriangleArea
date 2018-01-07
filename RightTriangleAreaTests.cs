using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RightTriangleAreaLib.Tests
{
    [TestClass]
    public class RightTriangleAreaTests
    {
        [TestMethod]
        public void Area_3and4and5_6returned()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            // act
            RightTriangleArea s = new RightTriangleArea();
            double actual = s.Area(a, b, c);

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}
