using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace SeleniumScreenshot
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();

            string screenshotsDirectory = Directory.GetCurrentDirectory() + @"\screenshots";


            driver.Navigate().GoToUrl("https://www.google.com");

            Screenshot googleScreenShot = ((ITakesScreenshot)driver).GetScreenshot();

            if (!Directory.Exists(screenshotsDirectory))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots\");
            }

            googleScreenShot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\googlescreenshot.png", ScreenshotImageFormat.Png);

            driver.Quit();
        }
    }
}
