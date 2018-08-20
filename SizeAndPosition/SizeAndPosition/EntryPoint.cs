using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace SizeAndPosition
{
    class EntryPoint
    {
        static void Main()
        {
            Size size = new Size();
            size.Width = 600;
            size.Height = 600;

            Point position = new Point();
            position.X = 20;
            position.Y = 400;

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://testing.todvachev.com");

            driver.Manage().Window.Size = size;
            //driver.Manage().Window.Size = new Size(600, 600);

            driver.Manage().Window.Position = position;
            //driver.Manage().Window.Position = new Point(0, 0);
        }
    }
}
