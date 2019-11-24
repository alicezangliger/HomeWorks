using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver("D:\\chromedriver");     
            driver.Navigate().GoToUrl("http://mail.ru");

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 25));
            string login = "test.account.alice";
            string password = "password19zalice";
            driver.FindElement(By.Id("mailbox:login")).SendKeys(login + Keys.Enter);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));
            driver.FindElement(By.Id("mailbox:password")).SendKeys(password + Keys.Enter);

            
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[6]/div/div[1]/div[1]/div/div[2]/div[1]/div/div/div[1]/div[2]/div/div[1]/nav/a[1]/div/div[3]/span/span")));
            IWebElement unreadMessages = driver.FindElement(By.XPath("/html/body/div[6]/div/div[1]/div[1]/div/div[2]/div[1]/div/div/div[1]/div[2]/div/div[1]/nav/a[1]/div/div[3]/span/span"));
            Console.WriteLine("***********************************");
            Console.WriteLine("Number of unread messages: " + unreadMessages.GetAttribute("innerText"));
            

            driver.FindElement(By.XPath("/html/body/div[6]/div/div[1]/div[1]/div/div[2]/div[2]/div/div/div/div/div/div[1]/div/div/div/a[1]/div[4]/div")).Click();
            driver.FindElement(By.XPath("/html/body/div[6]/div/div[1]/div[1]/div/div[2]/div[1]/div/div/div[1]/div[2]/div/div[1]/nav/a[1]")).Click();
            Console.WriteLine("***********************************");
            Console.WriteLine("Number of unread messages after 1 been opened: " + unreadMessages.GetAttribute("innerText"));
           
            driver.Quit();
        }
    }
}
