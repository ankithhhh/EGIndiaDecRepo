using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class amazon
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //initialize the web driver
            driver = new EdgeDriver();
        }
        [Test]
        public void testcase1()
        {
            
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            
            Thread.Sleep(2000);
            IWebElement primes = driver.FindElement(By.XPath("//a[@id='nav-link-amazonprime']"));
            Thread.Sleep(2000);
           
            new Actions(driver)
                .MoveToElement(primes)
                .ClickAndHold()
                .Pause(TimeSpan.FromSeconds(1))
               
                .Click()
                .Perform();
            Thread.Sleep(2000);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
