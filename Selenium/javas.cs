using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class javas
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

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            IJavaScriptExecutor js= (IJavaScriptExecutor)driver;
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(6000,0)", "");
            Thread.Sleep(10000);
        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
