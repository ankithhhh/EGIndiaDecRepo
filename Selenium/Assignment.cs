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
    internal class Assignment
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
            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);
            IWebElement radio = driver.FindElement(By.XPath("(//input[@name='radioButton'])[3]"));
            if(radio.Enabled) 
                {
                Console.WriteLine("click on it");
                radio.Click();
                }
            Thread.Sleep(5000);
            IWebElement CheckBox = driver.FindElement(By.XPath("//input[@id='checkBoxOption1']"));
           
            if (CheckBox.Displayed)
            {
                //Console.WriteLine("click on it");
                CheckBox.Click();
                
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
