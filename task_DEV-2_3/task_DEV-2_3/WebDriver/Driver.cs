using OpenQA.Selenium;

namespace GrowTask.WebDriver
{
    public class Driver
    {
        private static Driver _currentInstance;
        private static IWebDriver _driver => DriverContext.DriverContext.Driver;

        public static Driver Instance
        {
            get
            {
                var browser = _currentInstance;

                if (browser != null)
                {
                    return browser;
                }
                return _currentInstance = new Driver();
            }
        }


        /// <summary>
        /// Windows the maximize.
        /// </summary>
        public void WindowMaximize()
        {
            _driver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Gets the current page URL.
        /// </summary>
        /// <returns>System.String.</returns>
        public string GetCurrentPageUrl()
        {
            return _driver.Url;
        }

        /// <summary>
        /// Gets the current page title.
        /// </summary>
        /// <returns>System.String.</returns>
        public string GetCurrentPageTitle()
        {
            return _driver.Title;
        }

        /// <summary>
        /// Navigates to.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Quits this instance.
        /// </summary>
        public void Quit()
        {
            _driver.Quit();
        }

        /// <summary>
        /// Gets the driver.
        /// </summary>
        /// <returns>IWebDriver.</returns>
        public IWebDriver GetDriver()
        {
            return _driver;
        }
    }
}
