using Dev4;
using NUnit.Framework;
using System;

namespace TestDev4
{
    [TestFixture]
    public class PointTests
    {
        [TestCase(1, 0, 0, null, null, null, 1)]
        [TestCase(6, 0, 0, 5, 0, 0, 1)]
        public void TestDistanceBetweenTwoPoints_positive(float x1, float y1, float z1, float x2, float y2, float z2, float expected)
        {
            Point point1 = new Point(x1, y1, z1);
            Point point2 = new Point(x2, y2, z2);

            double actual = point1.FindDistance(point1, point2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCreatePoint_negative()
        {
            Assert.Throws<ArgumentException>(() => new Point(-100, 0, 0));
        }
    }
}