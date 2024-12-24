using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium;
using static Microsoft.IO.RecyclableMemoryStreamManager;


namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class finish
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()

        {
            //launch edge browser
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web drive
            driver = new EdgeDriver();

        }

        [Test]
        public void testSauce()
        {
            //launch application URL
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");

            //locator
            driver.Manage().Window.Maximize();

           Actions action = new Actions(driver);
            Thread.Sleep(1000);
            IWebElement Username = driver.FindElement(By.Id("user-name"));
            Username.SendKeys("standard_user");

            Thread.Sleep(1000);
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("secret_sauce");

            Thread.Sleep(1000);
            IWebElement Login = driver.FindElement(By.XPath("//input[@id='login-button']"));
            Login.Click();
            Thread.Sleep(5000);

            Thread.Sleep(5000);
            IWebElement AddItem = driver.FindElement(By.XPath("//div[@class='inventory_list']//div[1]//div[3]//button[1]"));
            AddItem.Click();
            Thread.Sleep(5000);

            IWebElement Cart = driver.FindElement(By.XPath("//*[name()='path' and contains(@fill,'currentCol')]"));
            Cart.Click();
            Thread.Sleep(5000);

            IWebElement content = driver.FindElement(By.LinkText("Sauce Labs Backpack"));
            string check = "Sauce Labs Backpack";
            Assert.AreEqual(check, content.Text);

            Thread.Sleep(5000);
            IWebElement Checkout = driver.FindElement(By.XPath("//a[normalize-space()='CHECKOUT']"));
            action.MoveToElement(Checkout)
            .Pause(TimeSpan.FromSeconds(5))
            .Click()
            .Perform();
            Thread.Sleep(3000);

            IWebElement FirstName = driver.FindElement(By.XPath("//input[@id='first-name']"));
            FirstName.SendKeys("safd");
            Thread.Sleep(5000);

           

            IWebElement LastName = driver.FindElement(By.XPath("//input[@id='last-name']"));
            LastName.SendKeys("adsf");
            Thread.Sleep(5000);


            IWebElement Zip = driver.FindElement(By.XPath("//input[@id='postal-code']"));
            Zip.SendKeys("3253645");
            Thread.Sleep(5000);

            Thread.Sleep(5000);
            IWebElement Continue = driver.FindElement(By.XPath("//input[@value='CONTINUE']"));
            action.MoveToElement(Continue)
            .Pause(TimeSpan.FromSeconds(5))
            .Click()
            .Perform();
            Thread.Sleep(3000);

            IWebElement Finish = driver.FindElement(By.XPath("//a[normalize-space()='FINISH']"));
            action.MoveToElement(Finish)
            .Pause(TimeSpan.FromSeconds(5))
            .Click()
            .Perform();
            Thread.Sleep(3000);
            Console.WriteLine("done");

        }
        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
