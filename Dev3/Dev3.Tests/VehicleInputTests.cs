using Dev3.VehicleComponents;
using Dev3.Vehicles;
using NUnit.Framework;
using System;

namespace Dev3.Tests
{
    /// <summary>
    /// Input tests for vehicle and vehicle components classes
    /// </summary>
    [TestFixture]
    public class VehicleInputTests
    {
        [Test]
        public void ArgumentExceptionLessThanMinimumValueTest()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<ArgumentException>(() => new Engine(0, 0, "Heat", "T34GDS543FDSH"));
                Assert.Throws<ArgumentException>(() => new Transmission("Automatic", 0, "ZF"));
                Assert.Throws<ArgumentException>(() => new Chassis(0, "FJDSJ3242", 0));
                Assert.Throws<ArgumentException>(() => new Bus(9, null, null, null));
                Assert.Throws<ArgumentException>(() => new Scooter(49, null, null, null));
                Assert.Throws<ArgumentException>(() => new Truck("BodyType", 0, null, null, null));
            });
        }

        [Test]
        public void ArgumentNullExceptionNullStringTest()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<ArgumentNullException>(() => new Engine(1, 1, null, null));
                Assert.Throws<ArgumentNullException>(() => new Transmission(null, 1, null));
                Assert.Throws<ArgumentNullException>(() => new Chassis(1, null, 1));
                Assert.Throws<ArgumentNullException>(() => new Truck(null, 1, null, null, null));
                Assert.Throws<ArgumentNullException>(() => new Car(null, null, null, null, null));
            });
        }

        [Test]
        public void FormatExceptioEmptyStringTest()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<FormatException>(() => new Engine(1, 1, string.Empty, string.Empty));
                Assert.Throws<FormatException>(() => new Transmission(string.Empty, 1, string.Empty));
                Assert.Throws<FormatException>(() => new Chassis(1, string.Empty, 1));
                Assert.Throws<FormatException>(() => new Truck(string.Empty, 1, null, null, null));
                Assert.Throws<FormatException>(() => new Car(string.Empty, string.Empty, null, null, null));
            });
        }

        [Test]
        public void FormatExceptionStringWithNonLatinNumericTest()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<FormatException>(() => new Engine(1, 1, "!@#$%^", "!@#$%^"));
                Assert.Throws<FormatException>(() => new Transmission("!@#$%^", 1, "!@#$%^"));
                Assert.Throws<FormatException>(() => new Chassis(1, "!@#$%^", 1));
                Assert.Throws<FormatException>(() => new Car("!@#$%^", "!@#$%^", null, null, null));
                Assert.Throws<FormatException>(() => new Truck("!@#$%^", 1, null, null, null));
            });
        }
    }
}