using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ElementLocations
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "http://testing.todvachev.com";

            driver.Navigate().GoToUrl(url);
            //driver.Manage().Window.Maximize();

            IWebElement content = driver.FindElement(By.CssSelector("#page-17 > div"));

            //System.Console.WriteLine(image.Location.X);
            //System.Console.WriteLine(image.Location.Y);
            //System.Console.WriteLine(image.Size.Width);
            //System.Console.WriteLine(image.Size.Height);

            SetStyle(driver, content, "color", "green");

        }

        static void SetStyle(IWebDriver driver, IWebElement element, string style, string styleValue)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            string script = String.Format("arguments[0].style[\"{0}\"] = \"{1}\"", style, styleValue);

            jsExecutor.ExecuteScript(script, element);
        }
    }
}
