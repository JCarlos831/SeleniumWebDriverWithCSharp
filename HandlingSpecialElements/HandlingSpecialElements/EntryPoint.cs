using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    // Initialize Web Driver
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";
        
        // Go to URL
        driver.Navigate().GoToUrl(url);

        // Initialize Element
        textBox = driver.FindElement(By.Name("username"));

        // Type in textbox
        textBox.SendKeys("Test text");

        // Wait 3 seconds
        Thread.Sleep(3000);

        // Clear textBox
        // textBox.Clear();

        // Write out what is in textBox to console
        //Console.WriteLine(textBox.GetAttribute("value"));

        // Find max length of textbox and write to console
        Console.WriteLine(textBox.GetAttribute("maxlength"));

        // Wait 3 seconds
        Thread.Sleep(3000);

        // Quit
        driver.Quit();
    }
}
