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
    internal class BrowserCommanda
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
            //launch the browser

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
           // get tittle 
            String tittle = driver.Title;
            Console.WriteLine(tittle);
            //get url
            string Currenturl = driver.Url;
            Console.WriteLine(Currenturl);
            //page source
            string page = driver.PageSource;
            Console.WriteLine(page);

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
