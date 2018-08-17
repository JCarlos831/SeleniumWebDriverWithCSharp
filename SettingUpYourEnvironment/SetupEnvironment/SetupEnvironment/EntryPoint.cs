using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        // Initialize Driver
        IWebDriver driver = new ChromeDriver();

        // Navigate to page with Driver
        driver.Navigate().GoToUrl("http://testing.todorvachev.com");

        // Leave page open for 3 seconds
        Thread.Sleep(3000);

        // Quit Browser
        driver.Quit();
    }
}