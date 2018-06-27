using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumNetTest.Models;
using SeleniumNetTest.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumNetTest.PageObjects
{
    class FinancePage
    {
        IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "div.side.additional_news ul li")]
        IList<IWebElement> AdditionalNews;

        private readonly By SearchForm = By.CssSelector("form#search");

        private readonly By FakeElem = By.CssSelector("ffffffffffff");

        private readonly By SideNewsContainer = By.CssSelector("div.additional_news li");

        public FinancePage()
        {
            this.driver = Driver.Instance;
            PageFactory.InitElements(driver, this);
        }

        public void Load()
        {
            driver.Navigate().GoToUrl("https://finance.tut.by/");
        }

        
        public bool isSeachFormDisplayed => DriverExtensions.IsDisplayed(FakeElem);

        public int AdditionalNewsCount
        {
            get
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(15))
                    .Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.CssSelector("div.side.additional_news ul li"))));
                return AdditionalNews.Count;
            }
        }

        public List<NewsEntry> GetSideNews()
        {
            return driver.FindElements(SideNewsContainer).Select(e => new NewsEntry(e)).ToList();
        }
    }
}
