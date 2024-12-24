using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestprojectdecBatchEGIndia.NUnitTest
{
    [Parallelizable(ParallelScope.All)]
    internal class parallelExe
    {

        [Test]
        public void userreg()
        {
            Console.WriteLine("user reg completed");
        }
        [Test]
        public void login()
        {
            Console.WriteLine("user is logged in");
        }
        [Test]
        public void select()
        {
            Console.WriteLine("user selects the product");
        }
    }
}

