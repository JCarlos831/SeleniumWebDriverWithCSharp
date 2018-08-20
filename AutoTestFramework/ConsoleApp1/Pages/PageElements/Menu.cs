﻿namespace AutoFramework.Pages
{
    using AutoTestFramework;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class Menu
    {
        public Menu(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement Introduction { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-106")]
        public IWebElement Selectors { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-35")]
        public IWebElement SpecialElements { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-57")]
        public IWebElement TestCases { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-58")]
        public IWebElement TestScenarios { get; set; }

        [FindsBy(How = How.Id, Using = "menu-item-26")]
        public IWebElement About { get; set; }


    }
}
