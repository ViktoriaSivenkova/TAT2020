using NUnit.Framework;
using Dev4;
using System;

namespace TestDev4
{
    [TestFixture]
    public class PlaneTests
    {
        [Test]
        public void TestGePlaneFlyTime_positive()
        {
            Point firstPlanePoint1 = new Point(0, 0, 0);
            Point firstPlanePoint2 = new Point(8, 6, 0);
            var firstPlaneActual = new Plane(firstPlanePoint1).GetFlyTime(firstPlanePoint2);
            var FirstPlaneExpected = new TimeSpan(0, 3, 0).NoMilliseconds();
            Assert.AreEqual(FirstPlaneExpected, firstPlaneActual);

            Point secondPlanePoint1 = new Point(5, 100, 0);
            Point secondPlatePoint2 = new Point(25, 100, 0);
            var secondPlaneActual = new Plane(secondPlanePoint1).GetFlyTime(secondPlatePoint2);
            var secondPlaneExpected = new TimeSpan(0, 5, 51).NoMilliseconds();
            Assert.AreEqual(secondPlaneExpected, secondPlaneActual);
        }

        [Test]
        public void TestGetPlaneFlyTime_negative()
        {
            Point point1 = new Point(0, 0, 0);
            Point point2 = new Point(1000, 1000, 1000);
            Assert.Throws<ArgumentException>(() => new Plane(point1).GetFlyTime(point2));
        }
    }
}