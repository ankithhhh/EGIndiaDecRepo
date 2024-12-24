using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestprojectdecBatchEGIndia.NUnitTest
{
    internal class Testorder
    {
        [Test,Order(1)]
        public void userreg()
        {
            Console.WriteLine("user reg completed");
        }
        [Test,Order(2)]
        public void login()
        {
            Console.WriteLine("user is logged in");
        }
        [Test,Order(3)]
        public void select()
        {
            Console.WriteLine("user selects the product");
        }
        [Test,Order(4)]
        public void order() { Console.WriteLine("user ordered"); }
        [Test,Order(5)]
        public void payment() { Console.WriteLine("user payed for the order"); }
    }
}
