using OpenQA.Selenium;

namespace GrowTask.Base
{
    public abstract class BasePage
    {
        protected IWebDriver _webDriver;

        protected BasePage(IWebDriver driver)
        {
            _webDriver = driver;
        }
    }
}