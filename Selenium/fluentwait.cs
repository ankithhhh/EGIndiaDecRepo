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
    internal class fluentwait
    {
        IWebDriver driver;

        public IWebElement Password { get; private set; }

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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement Browse = driver.FindElement(By.Id("file-upload"));
            Browse.SendKeys("C:\\Users\\anami\\Pictures\\Screenshots\\Screenshot 2024-12-05 120111.png");
            Thread.Sleep(2000);
            IWebElement upload = driver.FindElement(By.Id("file-submit"));

            upload.Click();
            Thread.Sleep(2000);
            IWebElement upload2 = driver.FindElement(By.XPath("//h3[normalize-space()='File Uploaded!']"));
            Assert.AreEqual(upload2.Text, "File Uploaded!");

           

            









        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
