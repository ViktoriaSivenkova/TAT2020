using Task_Advansed_1.Base;
using Task_Advansed_1.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;


namespace Task_Advansed_1
{
    class FormTasts : BaseTest
    {
        [Test]        
        public void NegativeTestFormWithEmptyInputFields()
        {
            _browser.NavigateTo(Constants.DegaultPageUrl);
            var defaultPage = new DefaultPage(_webDriver);
            defaultPage.SendFormWithEmptyFields();

            string actualEmptyNameMessage = defaultPage.EmptyNameNotification.GetText();
            string actualEmptyEmailMessage = defaultPage.EmptyEmailNotification.GetText();
            string actualEmptyPhoneMessage = defaultPage.EmptyPhoneNotification.GetText();
            string actualEmptyAnswerMessage = defaultPage.EmptyAnswerNotification.GetText();

            Assert.AreEqual(Constants.ExpectedEmptyNameMessage, actualEmptyNameMessage);
            Assert.AreEqual(Constants.ExpectedEmptyEmailMessage, actualEmptyEmailMessage);
            Assert.AreEqual(Constants.ExpectedEmptyPhoneMessage, actualEmptyPhoneMessage);
            Assert.AreEqual(Constants.ExpectedEmptyAnswerMessage, actualEmptyAnswerMessage);
        }

        [Test]        
        public void PositiveTestFormWithPositiveAnswer()
        {
            _browser.NavigateTo(Constants.DegaultPageUrl);
            var defaultPage = new DefaultPage(_webDriver);
            defaultPage.SendForm(Constants.Name, Constants.Email, Constants.Phone, true);

            string actualPositiveAnswerMessageOne = defaultPage.ActualPositiveAnswerOne.GetText();
            string actualPositiveAnswerMessageTwo = defaultPage.ActualPositiveAnswerTwo.GetText();            

            Assert.AreEqual(Constants.ExpectedPositiveAnswerMessageOne, actualPositiveAnswerMessageOne);
            Assert.AreEqual(Constants.ExpectedPositiveAnswerMessageTwo, actualPositiveAnswerMessageTwo);           
        }
        [Test]
        //[Parallelizable]
        public void PositiveTestFormWithNegativeAnswer()
        {
            _browser.NavigateTo(Constants.DegaultPageUrl);
            var defaultPage = new DefaultPage(_webDriver);
            defaultPage.SendForm(Constants.Name, Constants.Email, Constants.Phone);

            string actualNegativeAnswerMessageOne = defaultPage.ActualNegativeAnswerOne.GetText();
            string actualNegativeAnswerMessageTwo = defaultPage.ActualNegativeAnswerTwo.GetText();

            Assert.AreEqual(Constants.ExpectedNegativeAnswerMessageOne, actualNegativeAnswerMessageOne);
            Assert.AreEqual(Constants.ExpectedNegativeAnswerMessageTwo, actualNegativeAnswerMessageTwo);
        }
    }
}
