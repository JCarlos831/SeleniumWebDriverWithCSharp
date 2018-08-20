using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;

namespace OpenCloseTabs
{
    class EntryPoint
    {
        static void Main()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            //IWebDriver driver = new ChromeDriver(options);

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://google.com");

            Actions actions = new Actions(driver);

            actions.SendKeys(Keys.Control + "t").Build().Perform();

            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");

            List<string> handles = driver.WindowHandles.ToList();

            driver.SwitchTo().Window(handles[2]);
            driver.Navigate().GoToUrl("https://gmail.com");

            for (int i = 0; i < handles.Count; i++)
            {
                if (i != 2)
                {
                    driver.SwitchTo().Window(handles[i]);
                    driver.Close();
                }
            }
        }
    }
}
