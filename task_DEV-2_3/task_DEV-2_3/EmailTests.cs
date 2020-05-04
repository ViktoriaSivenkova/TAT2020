using GrowTask.Base;
using GrowTask.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;

namespace GrowTask
{
    public class EmailTests : BaseTest
    {
        [Test]
        [Parallelizable]
        public void TestLoginWithCorrectCredentials()
        {
           _browser.NavigateTo(Constants.RamblerLoginPageUrl);
            var ramblerLoginPage = new RamblerLoginPage(_webDriver);
            ramblerLoginPage.Login(Constants.RamblerEmail, Constants.RamblerPassword);

            var ramblerInboxPage = new RamblerInboxPage(_webDriver);

            Assert.IsTrue(ramblerInboxPage.WriteMessageButton.Displayed);
            Assert.AreEqual(Constants.RamblerInboxUrl, _webDriver.Url);

        }

        [Test]
        [Parallelizable]
        public void NegativeTestLoginWithIncorrectCredentials()
        {
           _browser.NavigateTo(Constants.RamblerLoginPageUrl);
            var ramblerLoginPage = new RamblerLoginPage(_webDriver);
            ramblerLoginPage.Login(Constants.RamblerEmail, Constants.RamblerPassword, true);

            string actualMessage = ramblerLoginPage.InvalidMailOrPasswordNotification.GetText();
            Assert.AreEqual(Constants.ExpectedInvalidEmailOrPasswordMessage, actualMessage);

        }
        [Test]
        [Parallelizable]
        public void NegativeTestLoginWithEmptyInputFields()
        {
            _browser.NavigateTo(Constants.RamblerLoginPageUrl);
            var ramblerLoginPage = new RamblerLoginPage(_webDriver);
            ramblerLoginPage.LoginWithEmptyFields();

            string actualEmptyEmailMessage = ramblerLoginPage.EmptyEmailNotification.GetText();
            string actualEmptyPasswordMessage = ramblerLoginPage.EmptyPasswordNotification.GetText();

            Assert.AreEqual(Constants.ExpectedEmptyEmailMessage, actualEmptyEmailMessage);
            Assert.AreEqual(Constants.ExpectedEmptyPasswordMessage, actualEmptyPasswordMessage);
        }

        [Test]
        [Parallelizable]
        public void TestSendMessage()
        {
            var expectedMessage = Faker.Lorem.Sentence(5);
            _browser.NavigateTo(Constants.RamblerLoginPageUrl);
            var ramblerLoginPage = new RamblerLoginPage(_webDriver);
            ramblerLoginPage.Login(Constants.RamblerEmail, Constants.RamblerPassword);
            
            var ramblerInboxPage = new RamblerInboxPage(_webDriver);
            ramblerInboxPage.SendMessage(Constants.YandexMailReceiver, expectedMessage);

            ((IJavaScriptExecutor)_webDriver).ExecuteScript("window.open();");
            _webDriver.SwitchTo().Window(_webDriver.WindowHandles.Last());

            _browser.NavigateTo(Constants.YandexMailUrl);
            var yandexMailMainPage = new YandexMailMainPage(_webDriver);
            yandexMailMainPage.GoToLoginPage();

            var yandexMailLoginPage = new YandexMailLoginPage(_webDriver);
            yandexMailLoginPage.Login(Constants.YandexEmail, Constants.YandexPassword);

            var yandexInboxPage = new YandexMailInboxPage(_webDriver);
            var actualMessage = yandexInboxPage.GetLastUnreadMessage(expectedMessage);
            Assert.AreEqual(expectedMessage, actualMessage);            
        }
    }
}
