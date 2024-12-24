﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class takeScreenshot
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

        [Test,Category("sanity")]
        public void testcase1()

        {

            //launch application URL

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            Screenshot ss = driver.TakeScreenshot();
            ss.SaveAsFile("C:\\Users\\anami\\Pictures\\Screenshots\\Screenshot 2024-12-05 120111.png");

        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}