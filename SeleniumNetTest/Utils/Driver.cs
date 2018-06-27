using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumNetTest.Utils
{
    public class Driver
    {
        private static IWebDriver _driver;

        private Driver()
        {
        }

        public static IWebDriver Instance =>  
            _driver ?? (_driver = new ChromeDriver(@"C:\Users\User\Source\Repos\SeleniumNetTest\SeleniumNetTest\"));
    }
}
