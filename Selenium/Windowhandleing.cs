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
    internal class Windowhandleing
    {
        IWebDriver driver;

        

        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        [Test,Category("sanity")]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
            // fecth the parent window handle 
            string parenthandle = driver.CurrentWindowHandle;
            Console.WriteLine(parenthandle);
            Thread.Sleep(1000);
            IWebElement clickhere = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(2);
            clickhere.Click();
            Thread.Sleep(1000);
            // fecth the window handles of all the windows - two windows are opened
            IList<string> windowhandles = new List<string>(driver.WindowHandles);
            // move the control to child window
            driver.SwitchTo().Window(windowhandles[1]);
            string title = driver.Title;
            Console.WriteLine(title);
            driver.Close();

            Thread.Sleep(1000);
            driver.SwitchTo().Window(windowhandles[0]);
            //or
           // driver.SwitchTo().DefaultContent(); //window dosent close
            string parenttitle = driver.Title;
            Console.WriteLine(parenttitle);
            Assert.AreEqual("The Internet", parenttitle);








        }

        [TearDown]
        public void closebrowser()
        {
            //close browser
           
           // driver.Quit();
            driver.Close();

        }
    }
}
