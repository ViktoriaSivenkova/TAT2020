using System;
using System.Linq;
using Task_Advansed_1.WebDriver;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace DriverContext
{
    public static class DriverContext
    {
        private static IWebDriver _driver;
        private static WebDriverFactory.BrowserType _currentBrowser;

        public static IWebDriver Driver
        {
            get
            {
                lock (TestContext.CurrentContext.Test.Name)
                {
                    if (BrowserAlreadyExist(_driver))
                    {
                        InitParameters();
                        _driver = WebDriverFactory.GetDriver(_currentBrowser, int.Parse(Configuration._elementTimeout));
                        TestExecutionContext.CurrentContext.CurrentTest.Properties.Add($"{TestContext.CurrentContext.Test.Name}_driver", _driver);
                    }
                }

                return TestContext.CurrentContext.GetDriver();
            }
        }

        private static void InitParameters()
        {
            Enum.TryParse(Configuration._selectedBrowser, out _currentBrowser);
        }

        /// <summary>
        /// Gets the driver.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>IWebDriver.</returns>
        private static IWebDriver GetDriver(this TestContext context)
        {
            return (IWebDriver)TestContext.CurrentContext.Test.Properties.Get($"{TestContext.CurrentContext.Test.Name}_driver");
        }

        /// <summary>
        /// Browsers the already exist.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private static bool BrowserAlreadyExist(IWebDriver driver)
        {
            var browserProperty = TestContext.CurrentContext.Test.Properties.Keys;
            return !browserProperty.Any(e => e.Contains($"{TestContext.CurrentContext.Test.Name}_driver")) ||
                   browserProperty.FirstOrDefault(e => e.Contains($"{TestContext.CurrentContext.Test.Name}_driver")) ==
                   null || driver == null;
        }
    }
}