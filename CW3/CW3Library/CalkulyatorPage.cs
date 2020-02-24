using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CW3
{
    public class CalkulyatorPage
    {
        private IWebDriver driver;
        private string url = @"http://calkulyator.ru";
        private string displayXPath = "//td[contains(@class,\"display\")]";
        readonly Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {            
            {"+" , "//div[contains(@id,\"nmr_22\")]" },
            {"-" , "//div[contains(@id,\"nmr_17\")]" },
            {"=" , "//div[contains(@id,\"nmr_23\")]" },
            {"*" , "//div[contains(@id,\"nmr_16\")]" },
            {"/" , "//div[contains(@id,\"nmr_10\")]" },
            {"%" , "//div[contains(@id,\"nmr_11\")]" },
            {"1" , "//div[contains(@id,\"nmr_19\")]" },
            {"2" , "//div[contains(@id,\"nmr_20\")]" },
            {"3" , "//div[contains(@id,\"nmr_21\")]" },
            {"4" , "//div[contains(@id,\"nmr_13\")]" },
            {"5" , "//div[contains(@id,\"nmr_14\")]" },
            {"6" , "//div[contains(@id,\"nmr_15\")]" },
            {"7" , "//div[contains(@id,\"nmr_7\")]" },
            {"8" , "//div[contains(@id,\"nmr_8\")]" },
            {"9" , "//div[contains(@id,\"nmr_9\")]" },
            {"0" , "//div[contains(@id,\"nmr_25\")]" },
            {"AC", "//div[contains(@id,\"nmr_18\")]" }
        };

        public Dictionary<string, IWebElement> buttons = new Dictionary<string, IWebElement>();

        public CalkulyatorPage(IWebDriver browser)
        {
            driver = browser;
            driver.Manage().Window.Maximize();
            driver.Url = url;            
        }

        public void Init()
        {
            foreach (var item in dictionary)
            {
                IWebElement element = driver.FindElement(By.XPath(item.Value));
                buttons.Add(item.Key,element);
            }

            Display = driver.FindElement(By.XPath(displayXPath));

        }
        public CalkulyatorPage()
        {
        }       

       
        public IWebElement Display { get; set; }
          
        

       

    }
}
