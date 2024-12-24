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
    internal class filedownload
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement Browse = driver.FindElement(By.XPath("//a[normalize-space()='1734472065.txt']"));
            Browse.Click();
            Thread.Sleep(2000);
            string download= @"C:\Users\anami\Downloads\1734472065 (1).txt";
            if (File.Exists(download))
            {
                Console.WriteLine("File is downloaded successfully.");
            }
            else
            {
                Console.WriteLine("File download failed.");
            }


        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
