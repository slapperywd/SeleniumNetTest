using OpenQA.Selenium;
using SeleniumNetTest.Utils;

namespace SeleniumNetTest.Models
{
    class NewsEntry
    {
        private static readonly By DateLct = By.ClassName("news_date");
        private static readonly By TextLct = By.ClassName("_title");
        private static readonly By CountLct = By.ClassName("c_count");

        public NewsEntry(IWebElement container)
        {
            this.Container = container;
        }

        private readonly IWebElement Container;

        public string Date => DriverExtensions.GetElement(Container, DateLct).Text;

        public string Text => DriverExtensions.GetElement(Container, TextLct).Text;

        public int Count => int.Parse(DriverExtensions.GetElement(Container, CountLct).Text);
    }
}
