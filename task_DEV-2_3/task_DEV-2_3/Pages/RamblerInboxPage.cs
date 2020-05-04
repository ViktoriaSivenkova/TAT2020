using GrowTask.Base;
using OpenQA.Selenium;

namespace GrowTask
{
    public class RamblerInboxPage : BasePage
    {
        public RamblerInboxPage(IWebDriver driver) : base(driver)
        {
        }

        public BaseElement WriteMessageButton => new BaseElement(By.XPath("//span[@class='rui-Button-content' and text() = 'Написать']"));
        public BaseElement ReveiversInput => new BaseElement(By.Id("receivers"));
        public BaseElement MessageInput => new BaseElement(By.Id("tinymce"));
        public BaseElement SendButton => new BaseElement(By.XPath("(//span[@class='rui-Button-content' and text() = 'Отправить'])[2]"));

        public void SendMessage(string receiver, string message)
        {
            WriteMessageButton.Click();
            ReveiversInput.SendKeys(receiver);
            _webDriver.SwitchTo().Frame(_webDriver.FindElement(By.XPath("//iframe[@id = 'editor_ifr']")));
            MessageInput.SendKeys(message);
            _webDriver.SwitchTo().DefaultContent();
            SendButton.Click();
        }
    }
}
