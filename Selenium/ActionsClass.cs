using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class ActionsClass
    {
        IWebDriver driver;
        private object source;

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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();

            IWebElement Source = driver.FindElement(By.Id("column-a"));
            IWebElement Dest = driver.FindElement(By.Id("column-b"));
            new OpenQA.Selenium.Interactions.Actions(driver)
            
             .DragAndDrop(Source,Dest).Perform();   
             
            Thread.Sleep(2000);


        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
