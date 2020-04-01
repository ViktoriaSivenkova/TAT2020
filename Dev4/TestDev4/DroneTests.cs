using Dev4;
using NUnit.Framework;
using System;

namespace TestDev4
{
    [TestFixture]
    public class DroneTests
    {
        [Test]
        public void TestGetDroneFlyTime_positive()
        {
            Point point1 = new Point(55, 5, 0);
            Point point2 = new Point(55, 5, 22);

            var actual = new Drone(point1).GetFlyTime(point2);
            var expected = new TimeSpan(0, 11, 0).NoMilliseconds();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestGetDroneFlyTime_negative()
        {
            Point point1 = new Point(0, 0, 0);
            Point point2 = new Point(2000, 1000, 1000);
            Assert.Throws<ArgumentException>(() => new Plane(point1).GetFlyTime(point2));
        }
    }
}
