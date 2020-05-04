using OpenQA.Selenium;

namespace Task_Advansed_1.Base
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