namespace AutoFramework.Pages
{
    using AutoTestFramework;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class SpecialElementsPage
    {
        public SpecialElementsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

    }
}
