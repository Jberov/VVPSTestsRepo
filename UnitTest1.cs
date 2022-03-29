using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SeleniumTest
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://demo.guru99.com/test/ajax.html";
            driver.FindElement(By.Id("no")).Click();
            driver.FindElement(By.Id("buttoncheck")).Click();
        }

        [Test]
        public void Test2()
        {
            driver.Url = "http://demo.guru99.com/test/ajax.html";
            ReadOnlyCollection<IWebElement> elements = driver.FindElements(By.Name("name"));

        

            Console.WriteLine("Number of elements", elements.Count);

            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine("Radio button text:" + elements.ElementAt(i).GetAttribute("value"));
            }
        }

        [Test]
        public void Test3()
        {
            driver.Url = "http://demo.guru99.com/test/login.html";

            IWebElement email = driver.FindElement(By.Id("email"));

            // Get the WebElement corresponding to the Password Field		
            IWebElement password = driver.FindElement(By.Name("passwd"));

            email.SendKeys("abcd@gmail.com");
            password.SendKeys("abcdefghlkjl");
            Console.WriteLine("Text Field Set");

            // Deleting values in the text box		
            email.Clear();
            password.Clear();
            Console.WriteLine("Text Field Cleared");

            // Find the submit button		
            IWebElement login = driver.FindElement(By.Name("SubmitLogin"));

            // Using click method to submit form		
            email.SendKeys("abcd@gmail.com");
            password.SendKeys("abcdefghlkjl");
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.Name("SubmitLogin"))).Click().Perform();
            Console.WriteLine("Login Done with Click");
          
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
