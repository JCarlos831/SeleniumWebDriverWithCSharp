using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > fig img";
        string xPath = "//*[@id='post-108']/div/figure/img";

        // Initialize Driver
        IWebDriver driver = new ChromeDriver();

        // Go to URL
        driver.Navigate().GoToUrl(url);

        // Try Catch Block
        try
        {
            // Find Element by CSS Path
            IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));

            if (cssPathElement.Displayed)
                GreenMessage("I can see the CSS Path element.");
        }
        catch (NoSuchElementException)
        {

            RedMessage("I can't see the CSS Path element.");
        }

        try
        {
            // Find Element by XPath
            IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

            if (xPathElement.Displayed)
                GreenMessage("I can see the X Path element.");
        }
        catch (NoSuchElementException)
        {

            RedMessage("I can't see the X Path element.");
        }

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
