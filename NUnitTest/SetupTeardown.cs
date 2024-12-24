using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestprojectdecBatchEGIndia.NUnitTest
{
    internal class SetupTeardown
    {
        [SetUp]
        public void LaunchBrowser()
        {
            Console.WriteLine("launching browser");
        }
       
       
        [TearDown]
        public void CloseBrowser()
        {
            Console.WriteLine("cloasing browser");
        }
        [Test, Order(1)]
        public void userreg()
        {
            Console.WriteLine("user reg completed");
        }
        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine("user is logged in");
        }
        [Test, Order(3)]
        public void select()
        {
            Console.WriteLine("user selects the product");
        }
      

    }
}
