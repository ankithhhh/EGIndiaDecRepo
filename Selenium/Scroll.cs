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
    [Parallelizable(ParallelScope.All)]
    [Allure.NUnit.AllureNUnit]
    internal class Scroll
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()

        {
            //launch chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web driver

            driver = new EdgeDriver();

        }

        [Test, Category("regression")]
        public void testcase1()

        {

            //launch application URL

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();


            IWebElement amazonScience = driver.FindElement(By.XPath("//a[normalize-space()='Amazon Science']"));

            new OpenQA.Selenium.Interactions.Actions(driver)
                .ScrollToElement(amazonScience)
                .Click(amazonScience)
                .Perform();

            Thread.Sleep(5000);



        }
        [Test]
        public void testcase()
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

            public void closeBrowser()

            {

                driver.Close();

            }

        }
    }

