using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestprojectdecBatchEGIndia.NUnitTest
{
    internal class catogaries
    {
        [Test, Order(1),Category("regression")]
        public void userreg()
        {
            Console.WriteLine("user reg completed");
        }
        [Test, Order(2), Category("regression")]
        public void login()
        {
            Console.WriteLine("user is logged in");
        }
        [Test, Order(3), Category("regression")]
        public void select()
        {
            Console.WriteLine("user selects the product");
        }
        [Test, Order(4),Category("sanity")]
        public void order() { Console.WriteLine("user ordered"); }
        [Test, Order(5), Category("sanity")]
        public void payment() { Console.WriteLine("user payed for the order"); }
    }
}
