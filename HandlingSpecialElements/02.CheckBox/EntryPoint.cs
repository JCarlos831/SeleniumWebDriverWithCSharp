using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    // Initialize Web Driver
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        //string option = "1";

        // Go to URL
        driver.Navigate().GoToUrl(url);

        // Find checkbox with Css Selector
        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(1)"));

        // Check if checkbox is checked
        //if (checkBox.GetAttribute("checked") == "true")
        //    Console.WriteLine("The checkbox is checked");
        //else
        //    Console.WriteLine("The checkbox is not checked");

        // Get text from checkbox
        //Console.WriteLine(checkBox.GetAttribute("value"));

        // Get text from checkbox
        //option = "3";
        //checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));
        //Console.WriteLine(checkBox.GetAttribute("value"));

        // Check checkBox
        checkBox.Click();
        Thread.Sleep(3000);

        // Quit
        driver.Quit();
    }
}