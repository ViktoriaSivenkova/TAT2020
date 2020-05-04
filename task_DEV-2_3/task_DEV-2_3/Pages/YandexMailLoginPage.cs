using GrowTask.Base;
using OpenQA.Selenium;

namespace GrowTask
{
    public class YandexMailLoginPage : BasePage
    {
        public YandexMailLoginPage(IWebDriver driver) : base(driver)
        {
        }

        public BaseElement EmailInput => new BaseElement(By.Id("passp-field-login"));
        public BaseElement PasswordInput => new BaseElement(By.Id("passp-field-passwd"));
        public BaseElement SubmitButton => new BaseElement(By.XPath("//button[@type = 'submit']"));

        public void Login(string login, string password)
        {
            EmailInput.SendKeys(login);
            SubmitButton.Click();
            PasswordInput.SendKeys(password);
            SubmitButton.Click();
        }

    }
}
