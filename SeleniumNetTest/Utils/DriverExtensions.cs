using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNetTest.Utils
{
    public class DriverExtensions
    {
        static WebDriverWait wait;


        static DriverExtensions()
        {
            wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
        }

        public static bool IsDisplayed(By by)
        {
            try
            {
                return wait.Until(c => c.FindElement(by).Displayed);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static IWebElement GetElement(IWebElement container, params By[] bys)
        {
            return wait.Until(c => container.FindElement(new ByChained(bys)));
        }
    }
}
