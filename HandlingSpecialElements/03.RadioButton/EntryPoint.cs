using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    // Initialize Web Driver
    static IWebDriver driver = new ChromeDriver();

    // Declare RadioButton Variable
    static IWebElement radioButton;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
        string option = "3";

        // Go to URL
        driver.Navigate().GoToUrl(url);

        // Initialize 1st Radio Button
        radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(" + option + ")"));

        if (radioButton.GetAttribute("checked") == "true")
            System.Console.WriteLine("The radio button is checked.");
        else
            System.Console.WriteLine("This is one of the unchecked radio buttons.");

        Thread.Sleep(3000);

        // Quit
        driver.Quit();
    }
}