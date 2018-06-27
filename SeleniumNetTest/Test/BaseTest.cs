using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumNetTest.Utils;

namespace SeleniumNetTest.Test
{
    [TestClass]
    public class BaseTest
    {
        protected static IWebDriver driver;

        public BaseTest()
        {
            driver = Driver.Instance;
        }

        [TestInitialize]
        public void SetUp()
        {
            System.Console.WriteLine("Test init");
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
