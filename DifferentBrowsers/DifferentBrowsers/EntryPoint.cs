using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace DifferentBrowsers
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();

            if (driver.GetType().ToString().Contains("InternetExplorer"))
                driver.Navigate().GoToUrl("https://www.google.com");
            else if (driver.GetType().ToString().Contains("Chrome"))
                driver.Navigate().GoToUrl("https://www.gmail.com");
        }
    }
}
