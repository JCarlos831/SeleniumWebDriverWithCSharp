using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AutoTestFramework.Scenarios
{
    class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioTestCases();
        }

        [Test]
        public void LessThan5Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters);
            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertTexts.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters);

            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertTexts.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
