using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace AutoTestFramework.Scenarios
{
    class LoginInvalidUsername
    {
        IAlert alert;

        public LoginInvalidUsername()
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
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Thread.Sleep(5000);
            Assert.AreEqual(Config.AlertTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
