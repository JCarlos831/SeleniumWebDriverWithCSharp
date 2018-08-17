using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        // Initialize Driver
        IWebDriver driver = new ChromeDriver();

        // Open URL
        driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");

        // Find Name Element
        IWebElement element = driver.FindElement(By.Name("myName"));

        // Check if element is visible on page
        if(element.Displayed)
            GreenMessage("Yes! I can see the element");
        else
            RedMessage("I cannot see the element");

        // Quit Browser
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
