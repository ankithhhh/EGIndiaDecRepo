using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestprojectdecBatchEGIndia.DataDrivenTesting
{
    internal class Testparameter
    {
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 4)]
        public void sum(int a ,int b)
        {
            Console.WriteLine(a + b);

        }
    }
}
