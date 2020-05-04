using Task_Advansed_1.Base;
using OpenQA.Selenium;

namespace Task_Advansed_1
{
    class DefaultPage : BasePage
    {
        public DefaultPage(IWebDriver driver) : base(driver)
        {
        }

        public BaseElement NameInput => new BaseElement(By.Id("name"));
        public BaseElement EmailInput => new BaseElement(By.Id("email"));
        public BaseElement PhoneInput => new BaseElement(By.Id("phone"));
        public BaseElement WillAttend => new BaseElement(By.XPath("//option[@value='true' and text() = 'Да']"));
        public BaseElement WillNotAttend => new BaseElement(By.XPath("//option[@value='false' and text() = 'Нет']"));
        public BaseElement SendInvitationButton => new BaseElement(By.XPath("//button[@type = 'submit' and text() = 'Отправить приглашение RSVP']"));
        public BaseElement InvalidMailOrPasswordNotification => new BaseElement(By.XPath("//div[@class='rui-InputStatus-message']/div"));
        public BaseElement EmptyNameNotification => new BaseElement(By.XPath("//div[@id='validationSummary']/ul/li[contains(text(), 'Name')]"));
        public BaseElement EmptyEmailNotification => new BaseElement(By.XPath("//div[@id='validationSummary']/ul/li[contains(text(), 'Email')]"));
        public BaseElement EmptyPhoneNotification => new BaseElement(By.XPath("//div[@id='validationSummary']/ul/li[contains(text(), 'Phone')]"));
        public BaseElement EmptyAnswerNotification => new BaseElement(By.XPath("//div[@id='validationSummary']/ul/li[contains(text(), 'придете ли вы')]"));
        public BaseElement ActualPositiveAnswerOne => new BaseElement(By.XPath("//h1"));
        public BaseElement ActualPositiveAnswerTwo => new BaseElement(By.XPath("//p"));
        public BaseElement ActualNegativeAnswerOne => new BaseElement(By.XPath("//h1"));
        public BaseElement ActualNegativeAnswerTwo => new BaseElement(By.XPath("//p"));

        public void SendForm(string name, string email, string phone, bool isInvalid = false)
        {
            NameInput.SendKeys(name);
            EmailInput.SendKeys(email);
            PhoneInput.SendKeys(phone);
            if (isInvalid == false)
            {
                WillNotAttend.Click();                
            }
            else
            {
                WillAttend.Click();
            }
            SendInvitationButton.Click();
        }

        public void SendFormWithEmptyFields()
        {            
            SendInvitationButton.Click();
        }
    }
}
