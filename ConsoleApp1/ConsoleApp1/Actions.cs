using AutoTestFramework.UIElements;
using OpenQA.Selenium.Chrome;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
        }
        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys(username);
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.RepeatPasswordField.Clear();
            loginScenario.RepeatPasswordField.SendKeys(repeatPassword);
            loginScenario.LoginButton.Click();
        }
    }
}
