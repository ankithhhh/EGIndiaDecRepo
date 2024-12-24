using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class Orange
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
        driver.Manage().Window.Maximize();
            Console.WriteLine(driver.Title);
            Thread.Sleep(6000);
            IWebElement Username = driver.FindElement(By.XPath("//input[@id='user-name']"));
        Username.SendKeys("standard_user");
            IWebElement Password = driver.FindElement(By.XPath("//input[@id='password']"));
        Password.SendKeys("secret_sauce");
            IWebElement Login = driver.FindElement(By.XPath("//input[@id='login-button']"));
        Login.Click();
            Thread.Sleep(6000);
            driver.Navigate().Back();
        Thread.Sleep(3000);
            driver.Navigate().Forward();
        Thread.Sleep(3000);
            driver.Navigate().Refresh();
 
        }
 
        [TearDown]
        public void tearDown()
        {
            driver.Close();
        }
    }
}
   
