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
    internal class Locators
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
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/selenium/practice/register.php");
            // locators 
            // Id
            IWebElement FirstName = driver.FindElement(By.Id("firstname"));
            FirstName.SendKeys("Harsha");
            // name 
            IWebElement LastName = driver.FindElement(By.Name("lastname"));
            LastName.SendKeys("Patil");
            // xpath 
            IWebElement UserName = driver.FindElement(By.XPath("//input[@id = 'username']"));
            UserName.SendKeys("Hk");
            // xpath
            IWebElement Password = driver.FindElement(By.XPath("//input[@name= 'password']"));
            Password.SendKeys("Hk123");
            // Link text 
            IWebElement Backtologin = driver.FindElement(By.LinkText("Back to Login"));
            Backtologin.Click();
            // Partial link text
            IWebElement Register = driver.FindElement(By.PartialLinkText("Back to Log"));
            Register.Click();
            //  Css selectorr
            IWebElement Elements = driver.FindElement(By.CssSelector("button[data-bs-target='#collapseOne']"));
            Elements.Click();
            // tag name 
            IWebElement input = driver.FindElement(By.TagName("(//input)[1]"));
            input.SendKeys("jkkj");
            // class name 
            IWebElement classname = driver.FindElement(By.ClassName("(//input[@class = 'form-control'])[1]"));
            classname.SendKeys("jkkj");






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
