using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string login1 = "test.account.alice";
            string password1 = "password19zalice";
            string login2 = "test.account2@tut.by";
            string password2 = "password219zalice";
            string mailText = "Hello World!!!";

            //first e-mail
            IWebDriver driver1 = new ChromeDriver("D:\\chromedriver");
            WebDriverWait wait = new WebDriverWait(driver1, new TimeSpan(0, 0, 15));
            driver1.Navigate().GoToUrl("http://mail.ru");
            driver1.Manage().Window.Maximize();

            driver1.FindElement(By.Id("mailbox:login")).SendKeys(login1 + Keys.Enter);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("mailbox:password")));
            driver1.FindElement(By.Id("mailbox:password")).SendKeys(password1 + Keys.Enter);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(@title,\"Написать письмо\")]")));
            driver1.FindElement(By.XPath("//span[contains(@title,\"Написать письмо\")]")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[contains(@tabindex,\"100\")]")));
            driver1.FindElement(By.XPath("//input[contains(@tabindex,\"100\")]")).SendKeys(login2 + Keys.Enter);
            driver1.FindElement(By.XPath("//div[contains(@role,\"textbox\")]")).SendKeys(mailText);
            driver1.FindElement(By.XPath("//span[text()=\"Отправить\"]")).Click();

            //second e-mail
            IWebDriver driver2 = new ChromeDriver("D:\\chromedriver");
            driver2.Navigate().GoToUrl("https://yandex.by");
           
            
            driver2.FindElement(By.XPath("//a[text()=\"Почта\"]")).Click();
            driver2.FindElement(By.Id("passp-field-login")).SendKeys(login2 + Keys.Enter);
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div//input[contains(@type,\"password\")]")));
            driver2.FindElement(By.XPath("//div//input[contains(@name,\"passwd\")]")).SendKeys(password2 + Keys.Enter);
        }
    }
}
