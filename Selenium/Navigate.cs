using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class Navigate
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

       

        [TearDown]
        public void closebrowser()
        {
            //close browser
            driver.Close();
            //close all browser sessions
            driver.Quit();
        }
    }
}
