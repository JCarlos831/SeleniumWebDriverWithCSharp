using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Threading.Tasks;

class EntryPoint
{
    // Initializing the web driver
    static IWebDriver driver = new ChromeDriver();

    static IAlert alert;
    static IWebElement image;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        Console.WriteLine(alert.Text);

        alert.Accept();

        Thread.Sleep(3000);

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

        try
        {
            if (image.Displayed)
                Console.WriteLine("Found the image after the alert box was accepted.");
        }
        catch(NoSuchElementException)
        { 
            Console.WriteLine("Where's the image at?");
        }

        driver.Quit();
    }
}

