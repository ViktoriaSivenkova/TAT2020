using GrowTask.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium;

namespace GrowTask.Base
{
    public class BaseTest
    {
        protected IWebDriver _webDriver => DriverContext.DriverContext.Driver;
        protected Driver _browser;

        /// <summary>
        /// Initializes the test.
        /// </summary>
        [SetUp]
        public virtual void InitTest()
        {
            _browser = Driver.Instance;
        }

        /// <summary>
        /// Cleans the test.
        /// </summary>
        [TearDown]
        public virtual void CleanTest()
        {
            _browser.Quit();
        }
    }
}