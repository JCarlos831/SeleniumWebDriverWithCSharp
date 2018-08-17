using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/class-name/";
        string className = "testClass";

        // Initialize the chrome driver
        IWebDriver driver = new ChromeDriver();

        // Go to URL
        driver.Navigate().GoToUrl(url);

        // Find Element
        IWebElement element = driver.FindElement(By.ClassName(className));

        // Check to see if element is visible
        if (element.Displayed)
            GreenMessage("I can see the element.");
        else
            RedMessage("I can't see the element.");

        // Output text from element to console
        Console.WriteLine(element.Text);

        // Quit
        driver.Quit();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
