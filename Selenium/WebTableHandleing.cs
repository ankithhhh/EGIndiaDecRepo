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
    [Allure.NUnit.AllureNUnit]
    internal class WebTableHandleing
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test,Category("Regression")]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            //Fetch the table
            IWebElement Table = driver.FindElement(By.XPath("//table[@id = 'table1']"));
            //Fetch Rows
            Thread.Sleep(2000);

            List<IWebElement> trRow = new List<IWebElement>(Table.FindElements(By.XPath("//table[@id = 'table1']/tbody/tr")));
            int rowcount = trRow.Count();
            Console.WriteLine(rowcount);
            Thread.Sleep(2000);


            List<IWebElement> tdCol = new List<IWebElement>(Table.FindElements(By.XPath("//table[@id = 'table1']/tbody/td")));
            int colCount = tdCol.Count();
            Console.WriteLine(colCount);
            Thread.Sleep(2000);


            //cell data
            IWebElement cellData = driver.FindElement(By.XPath("//table[@id = 'table1']/tbody/tr[3]/td[2]"));
            string text = cellData.Text;
            Console.WriteLine(text);
            Assert.AreEqual("Jason", text);
            Thread.Sleep(2000);


        }

        [TearDown]
        public void closebrowser()
        {
            //close browser
            driver.Close();
            //close all browser sessions
           // driver.Quit();
        }
    }
}

