using System;
using NUnit.Framework;

namespace TestOfWorkWithString
{
    [TestFixture]
    public class StringRepeatedSymbolsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(" uuuhg", 3)]
        [TestCase("      ", 6)]      
        [TestCase("    h ", 4)]
        [TestCase("22222j", 5)]
        [TestCase("uu5uiiiu", 3)]
        [TestCase("hjnjdckkkk", 4)]
        [TestCase("aaaa", 4)]
        [TestCase("uuuuijfgsrhgkjuuuuuuuuuuuialrjgnas;krgjna;srjgna;rjgn;arbgn;lrbga;lorg'pwi'werokipweogjq3pro", 11)]
        [TestCase("", 0)]
        [TestCase("hjklfg", 1)]
        [TestCase("s", 1)]
        public void RepeatingSymbolsOfString_positive(string testString, int expected)
        {
            var myString = new Dev1.WorkWithString();
            int actual = myString.GetNumberOfMaxRepeatingSymbols(testString);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void RepeatingSymbolsOfString_negative(string testString)
        {
            var myString = new Dev1.WorkWithString();
            // int actual = myString.GetNumberOfMaxRepeatingSymbols(testString);

            Assert.Throws<Exception>(() => myString.GetNumberOfMaxRepeatingSymbols(testString));

        }

    }
}