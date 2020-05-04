using GrowTask.Base;
using OpenQA.Selenium;

namespace GrowTask
{
    public class YandexMailMainPage : BasePage
    {
        public YandexMailMainPage(IWebDriver driver) : base(driver)
        {
        }

        public BaseElement EnterButton => new BaseElement(By.XPath("(//a[contains(@class, 'Button-Enter')])[1]"));

        public void GoToLoginPage()
        {
            EnterButton.Click();
        }
    }
}
