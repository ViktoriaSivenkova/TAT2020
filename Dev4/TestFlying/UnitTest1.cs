using NUnit.Framework;
using Dev4;
using System;

namespace TestFlying
{
    [TestFixture]
    public class PointTests
    {
        [TestCase(1, 2, 3, 1, 2, 3, 0)]
        [TestCase(1, 0, 0, null, null, null, 1)]
        [TestCase(6, 0, 0, 5, 0, 0, 1)]
        public void TestDistanceBetweenTwoPoints(float x1, float y1, float z1, float x2, float y2, float z2, float expected)
        {
            Point point1 = new Point(x1, y1, z1);
            Point point2 = new Point(x2, y2, z2);

            double actual = point1.FindDistance(point1, point2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PointNegativeTest()
        {
            Assert.Throws <ArgumentException> (() => new Point(-100, 0, 0));
        }
    }

    [TestFixture]
    public class PlaneTests
    {
        [Test]
        public void PlanePositiveTest()
        {
            Point point1 = new Point(0, 0, 0);
            Point point2 = new Point(8, 6, 0);

            var actual = new Plane(point1).GetFlyTime(point2);
            var expected = new TimeSpan(0, 3, 0).NoMilliseconds();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlanePositiveTest1()
        {
            Point point1 = new Point(5, 100, 0);
            Point point2 = new Point(25, 100, 0);

            var actual = new Plane(point1).GetFlyTime(point2);
            var expected = new TimeSpan(0, 5, 51).NoMilliseconds();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlaneNegativeTest()
        {
            Point point1 = new Point(0, 0, 0);
            Point point2 = new Point(1000, 1000, 1000);
            Assert.Throws<ArgumentException>(() => new Plane(point1).GetFlyTime(point2));
        }
    }

    [TestFixture]
    public class DronTests
    {
        [Test]
        public void DronePositiveTest()
        {
            Point point1 = new Point(55, 5, 0);
            Point point2 = new Point(55, 5, 22);

            var actual = new Drone(point1).GetFlyTime(point2);
            var expected = new TimeSpan(0, 11, 0).NoMilliseconds();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DroneNegativeTest()
        {
            Point point1 = new Point(0, 0, 0);
            Point point2 = new Point(2000, 1000, 1000);
            Assert.Throws<ArgumentException>(() => new Plane(point1).GetFlyTime(point2));
        }
    }

}