using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
    {
        static void Main()
        {
            string url = "http://testing.todorvachev.com/selectors/id";
            string id = "testImage";
            
            // Initialize Driver
            IWebDriver driver = new ChromeDriver();

            // Go to URL
            driver.Navigate().GoToUrl(url);

            // Find Element by ID
            IWebElement element = driver.FindElement(By.Id(id));

            if (element.Displayed)
                GreenMessage("Yes, I can see it.");
            else
                RedMessage("I can't see it.");

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
