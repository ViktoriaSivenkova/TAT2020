using NUnit.Framework;
using Dev2;
using System;

namespace Dev2Tests
{
    [TestFixture]
    public class TestsForConvertingFromDecimalToAnotherSystem
    {
        [TestCase(10, 21)]
        [TestCase(10, 0)]
        [TestCase(10, 1)]
        [TestCase(10, -1)]
        public void ConvertingFromDecimalToAnotherSymbol_negative(int decimalNumber, int valueOfBaseOfNewSystem)
        {
            Assert.Throws<ArgumentException>(() => new ConvertingFromDecimalToAnotherSystem(decimalNumber, valueOfBaseOfNewSystem));
        }

        [TestCase("3D7", 6)]
        public void ConvertingFromDecimalToAnotherSymbol_FormatExeption(string decimalNumber, int valueOfBaseOfNewSystem)
        {
            Assert.Throws<FormatException>(() => new ConvertingFromDecimalToAnotherSystem(Convert.ToInt32(decimalNumber), valueOfBaseOfNewSystem));
        }

        [TestCase(int.MinValue, 11)]
        public void ConvertingFromDecimalToOtherNumeralSystem_OverflowException(int decimalNumber, int valueOfBaseOfNewSystem)
        {
            var converting = new ConvertingFromDecimalToAnotherSystem(decimalNumber, valueOfBaseOfNewSystem);

            Assert.Throws<OverflowException>(() => converting.ConvertDecimalNumberToAnotherSystem());
        }

        [TestCase(68, 2, "1000100")]
        [TestCase(27, 3, "1000")]
        [TestCase(0, 3, "0")]
        [TestCase(10, 10, "10")]
        [TestCase(-100, 16, "-64")]
        [TestCase(-16749, 17, "-36G4")]
        [TestCase(1111, 18, "37D")]
        [TestCase(6789, 19, "IF6")]
        [TestCase(-32768, 20, "-41I8")]
        [TestCase(int.MaxValue, 20, "1DB1F927")]
        [TestCase(int.MaxValue, 2, "1111111111111111111111111111111")]

        public void ConvertingFromDecimalToAnotherSymbol_positive(int decimalNumber, int valueOfBaseOfNewSystem, string expected)
        {
            var converting = new ConvertingFromDecimalToAnotherSystem(decimalNumber, valueOfBaseOfNewSystem);
            string actual = converting.ConvertDecimalNumberToAnotherSystem();

            Assert.AreEqual(expected, actual);
        }
    }
}