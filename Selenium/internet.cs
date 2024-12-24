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
    internal class internet
    {
        internal class Orange
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
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
                driver.Manage().Window.Maximize();
                IWebElement CheckBox2 = driver.FindElement(By.XPath("//input[2]"));
                if (CheckBox2.Selected)
                {
                    CheckBox2.Click();
                    Thread.Sleep(5000);
                }

                IReadOnlyList<IWebElement> chechbox1 = driver.FindElements(By.XPath("//input[@type='checkbox']"));

                foreach (IWebElement e in chechbox1)
                {
                    Console.WriteLine(e.Text);
                    e.Click();
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
    }


