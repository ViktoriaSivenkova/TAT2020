using System;
using NUnit.Framework;
using Dev1;

namespace TestOfWorkWithString
{
    [TestFixture]
    public class StringUnrepeatedSymbolsTests
    {
        [TestCase("", 0)]
        [TestCase("s", 1)]
        [TestCase("          ", 1)]
        [TestCase("s s s ", 6)]
        [TestCase("abcdefghij", 10)]
        [TestCase("aaaaabcdeeeeee", 5)]
        [TestCase("aa bcdffff", 6)]
        public void UnrepeatingSymbolsOfString_positive(string testString, int expectedNumberOfSymbols)
        {
            var stringWorker = new WorkWithString();
            int actualNumberOfSymbols = stringWorker.GetNumberOfMaxUnrepeatingSymbols(testString);
            
            Assert.AreEqual(expectedNumberOfSymbols, actualNumberOfSymbols);
        }

        [TestCase(null)]
        public void UnrepeatingSymbolsOfString_negative(string testString)
        {
            var stringWorker = new WorkWithString();

            Assert.Throws<NullReferenceException>(() => stringWorker.GetNumberOfMaxUnrepeatingSymbols(testString));
        }
    }
}