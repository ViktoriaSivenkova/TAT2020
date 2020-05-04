using GrowTask.Base;
using OpenQA.Selenium;
using System.Linq;
using System.Text;

namespace GrowTask
{
    public class YandexMailInboxPage : BasePage
    {
        public YandexMailInboxPage(IWebDriver driver) : base(driver)
        {
        }

        public BaseElement LiteVersionLink => new BaseElement(By.XPath("//a[text() = 'Лёгкая версия']"));

        public string GetLastUnreadMessage(string expectedMessage)
        {
            StringBuilder textUnreadMessage = new StringBuilder();
            LiteVersionLink.Click();
            var listUnreadMessages = _webDriver.FindElements(By.XPath("//div[contains(@class, 'b-messages__message_unread')]")).ToList();
            listUnreadMessages.Select(element => element.FindElement(By.XPath($"//span[text() ='{expectedMessage}']"))).ToList().First().Click();
            _webDriver.FindElements(By.XPath("//div[@class= 'b-message-body__content']/div[contains(text(), '')]")).ToList().ForEach(el =>
            {
                textUnreadMessage.Append(el.Text);
            });

            return textUnreadMessage.ToString();
        }
    }
}
