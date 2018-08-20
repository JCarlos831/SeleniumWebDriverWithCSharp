namespace AutoFramework.Pages
{
    using AutoTestFramework;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class SpecialElementsPage
    {
        public SpecialElementsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

    }
}
