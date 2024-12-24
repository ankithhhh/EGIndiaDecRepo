using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using TestprojectdecBatchEGIndia.Utility;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace TestprojectdecBatchEGIndia.Selenium
{
    internal class horizontalScroll : Utility.Base
    {
        public horizontalScroll(IWebDriver driver) : base(driver)
        {
        }
        
       

        [Test]
        public void testcase1()

        {

            //launch application URL

            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(6000,0)", "");
            Thread.Sleep(10000);
        }

       
    }
}
