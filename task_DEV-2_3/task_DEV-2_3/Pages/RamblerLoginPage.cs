using GrowTask.Base;
using OpenQA.Selenium;

namespace GrowTask
{
    public class RamblerLoginPage : BasePage
    {
        public RamblerLoginPage(IWebDriver driver) : base(driver)
        {
        }

        public BaseElement LoginInput => new BaseElement(By.Id("login"));
        public BaseElement PasswordInput => new BaseElement(By.Id("password"));
        public BaseElement SubmitButton => new BaseElement(By.XPath("//span[@class = 'rui-Button-content' and text() = 'Войти']"));
        public BaseElement InvalidMailOrPasswordNotification => new BaseElement(By.XPath("//div[@class='rui-InputStatus-message']/div"));
        public BaseElement EmptyEmailNotification => new BaseElement(By.XPath("//div[@class='rui-InputStatus-message']"));
        public BaseElement EmptyPasswordNotification => new BaseElement(By.XPath("//div[@class='rui-InputStatus-message']/div"));

        public void Login(string login,string password, bool isInvalid = false)
        {
            _webDriver.SwitchTo().Frame(_webDriver.FindElement(By.XPath("//iframe")));
            if (isInvalid == false)
            {                
                LoginInput.SendKeys(login);
                PasswordInput.SendKeys(password);
                SubmitButton.Click();
                _webDriver.SwitchTo().DefaultContent();
            }
            else
            {                
                LoginInput.SendKeys(Faker.Lorem.Word() + Faker.Number.RandomNumber(100,10000));
                PasswordInput.SendKeys(Faker.Lorem.Word());
                SubmitButton.Click();
            }
        }

        public void LoginWithEmptyFields()
        {
            _webDriver.SwitchTo().Frame(_webDriver.FindElement(By.XPath("//iframe")));
            SubmitButton.Click();
        }
    }
}
