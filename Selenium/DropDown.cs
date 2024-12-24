using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class DropDown
    {
        IWebDriver driver;

        public DropDown(IWebDriver driver)
        {
            this.driver = driver;
        }

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

            //launch application URL

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            //locators

            //ID
            driver.Manage().Window.Maximize();

            IWebElement Dropdown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(Dropdown);
            var select = new SelectElement(Dropdown);

            //select by visible Text
            //option1
            Thread.Sleep(2000);
            select.SelectByText("Option3");

            //select by index
            //option2
            Thread.Sleep(2000);
            select.SelectByIndex(2);

            //option3  by value
            Thread.Sleep(3000);
            select.SelectByValue("option1");Thread.Sleep(3000);
        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
        
    }
}
