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
    internal class MultiSelect
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
            //launch application URL
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");

            //locator
            IReadOnlyList<IWebElement> chechbox = driver.FindElements(By.XPath("//input[@type='checkbox']"));

            foreach (IWebElement element in chechbox)
            {
                Console.WriteLine(element.Text);
                element.Click();
                Thread.Sleep(2000);

            }



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

