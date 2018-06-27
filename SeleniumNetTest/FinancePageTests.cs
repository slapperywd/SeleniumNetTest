using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumNetTest.PageObjects;
using SeleniumNetTest.Test;
using SeleniumNetTest.Utils;
using System.Linq;
using System.Threading;

namespace SeleniumNetTest
{
    [TestClass]
    public class FinancePageTests : BaseTest
    {

        [TestMethod]
        public void CheckVisibilityOfAdditionalNews()
        {
            FinancePage fp = new FinancePage();
            fp.Load();
            Assert.AreEqual(fp.AdditionalNewsCount, 5);
          //  Assert.IsFalse(fp.isSeachFormDisplayed);
            var news = fp.GetSideNews();
            string text = fp.GetSideNews().ElementAt(1).Text;
            string date = fp.GetSideNews().ElementAt(1).Date;
            int count = fp.GetSideNews().ElementAt(1).Count;
            Assert.IsTrue(news.First().Text.Contains("Forbes назвал богатейшего человека мира"));
            
        }

        [TestMethod]
        public void TestToBePassed()
        {
            FinancePage fp = new FinancePage();
            fp.Load();
            IWebElement container = Driver.Instance.FindElement(By.CssSelector("div.additional_news li"));
            By subElement = By.ClassName("_title");
            var test1 = container.FindElement(new ByChained(subElement)).Text;
            System.Console.WriteLine(test1);
            var test = DriverExtensions.GetElement(container, subElement).Text;
            System.Console.WriteLine(test);
            Assert.IsTrue(true);
        }

    }
}
