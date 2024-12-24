using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class DreopAssignment
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

            //launch application URL

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");

            //locators

            //ID
            driver.Manage().Window.Maximize();

            IWebElement Dropdown = driver.FindElement(By.Id("dropdown"));
            Assert.IsNotNull(Dropdown);
            var select = new SelectElement(Dropdown);
            //Thread.Sleep(2000);
            //select.SelectByText("Option 1");
            //Thread.Sleep(2000);
            //select.SelectByIndex(2);
            //Thread.Sleep(2000);
            //select.SelectByValue("1");
            //for (int i = 1; i <= 2; i++)
            //{
            //    select.SelectByIndex(i);
            //    Thread.Sleep(1000);
            //}



        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
