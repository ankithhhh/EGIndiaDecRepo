using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestprojectdecBatchEGIndia.NUnitTest
{
    [TestFixture("anki", "qwe", 123)]

    [Allure.NUnit.AllureNUnit]
    internal class Assignment
    {
        
        [Test,Order(1)]
       
        public void MangerLogin()
        {
            Console.WriteLine("logged in sucessfully");
        }
        private readonly string _fname;
        private readonly string _lname;
        private readonly int _PostCode;
        
        public Assignment(string fname, string lname, int postCode)
        {
            _fname = fname;
            _lname = lname;
            _PostCode = postCode;
        }
        [Test,Category("sanity"),Order(2)]
        public void AddCustomer()
        {
            Console.WriteLine(_fname);
            Console.WriteLine(_lname);
            Console.WriteLine(_PostCode);
            Console.WriteLine("sucessfull");
            Assert.IsNotNull(_fname);
            Assert.IsNotEmpty(_lname);
            
        }
        [TestCase("ankii", "dollar"),Ignore("failed"), Category("sanity")]
        public void AddCustomer(string name, string currency)
        {
            Console.WriteLine(name+";"+ currency);


        }


    }
}
