using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Task_Advansed_1.WebDriver
{
    public class WebDriverFactory
    {
        public enum BrowserType
        {
            Chrome,
            Firefox,
        }

        /// <summary>
        /// Gets the driver.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="timeOutSec">The time out sec.</param>
        /// <returns>IWebDriver.</returns>
        public static IWebDriver GetDriver(BrowserType type, int timeOutSec)
        {
            IWebDriver driver = null;

            switch (type)
            {
                case BrowserType.Chrome:
                    {
                        var service = ChromeDriverService.CreateDefaultService();
                        var chromeOptions = new ChromeOptions();
                        chromeOptions.AddExcludedArgument("enable-automation");
                        chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
                        chromeOptions.AddArguments("--disable-notifications");
                        chromeOptions.AddArgument("start-maximized");
                        chromeOptions.AddArgument("no-sandbox");
                        chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
                        chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
                        driver = new ChromeDriver(service, chromeOptions, TimeSpan.FromSeconds(timeOutSec));
                        break;
                    }
                case BrowserType.Firefox:
                    {
                        var service = FirefoxDriverService.CreateDefaultService();
                        var options = new FirefoxOptions();
                        driver = new FirefoxDriver(service, options, TimeSpan.FromSeconds(timeOutSec));
                        driver.Manage().Window.Maximize();
                        break;
                    }
            }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeOutSec);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(timeOutSec);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeOutSec);
            return driver;
        }
    }
}