using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    // initialize web driver
    static IWebDriver driver = new ChromeDriver();

    static IWebElement dropDownMenu;
    static IWebElement elementFromDropDownMenu;

    static void Main()
    {
        // initialize url string
        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        // Open browser and go to url
        driver.Navigate().GoToUrl(url);

        // Create element
        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        // write to console
        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownElements));

        Console.WriteLine("The third option from the drop down menu is: " + elementFromDropDownMenu.GetAttribute("value"));

        elementFromDropDownMenu.Click();

        Console.WriteLine("The clicked value is: " + dropDownMenu.GetAttribute("value"));

        Thread.Sleep(3000);

        for(int i = 1; i <= 4; i++)
        {
            dropDownElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+i+")";
            elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownElements));

            Console.WriteLine("The " +i+ " option from the drop down menu is: " + elementFromDropDownMenu.GetAttribute("value"));
        }


        // Quit
        driver.Quit();
    }
}
