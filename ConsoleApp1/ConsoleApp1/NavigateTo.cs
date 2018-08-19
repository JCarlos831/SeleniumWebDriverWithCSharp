using AutoTestFramework.UIElements;
using System.Threading;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormThroughTheMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();
            Thread.Sleep(500);
        }

        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameCasePost ufPost = new UsernameCasePost();

            menu.TestCases.Click();
            Thread.Sleep(500);
            tcPage.UsernameField.Click();
            Thread.Sleep(500);
            ufPost.LoginFormLink.Click();
            Thread.Sleep(500);
        }

        public static void LoginFormScenarioTestCases()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();
            Thread.Sleep(500);
        }
    }
}
