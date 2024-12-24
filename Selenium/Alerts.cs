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
    internal class Alerts
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //initialize the web driver
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void testcase1()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");

            Thread.Sleep(5000);


            //Handling Informational Alerts
            IWebElement InformationalAlert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Alert']"));
            InformationalAlert.Click();
            IAlert alt = driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            //clicking OK button
            alt.Accept();
            Thread.Sleep(3000);

            //Handling Confirmational Alerts
            IWebElement ConfirmationalAlert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Confirm']"));
            ConfirmationalAlert.Click();
            Thread.Sleep(3000);
            //clicking cancel button
            alt.Dismiss();
            Thread.Sleep(3000);

            //Handling Prompt Alerts
            IWebElement PromptAlert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Prompt']"));
            PromptAlert.Click();
            Thread.Sleep(3000);
            //sending keys
            string alertText = alt.Text;
            alt.SendKeys("hi");
            Thread.Sleep(3000);
            alt.Accept();


        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}

