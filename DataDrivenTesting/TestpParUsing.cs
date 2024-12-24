using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestprojectdecBatchEGIndia.DataDrivenTesting
{
    internal class TestpParUsing
    {
        [Test,TestCaseSource("GetTestData")]
        public void Test( string name, string password)
        {
            Console.WriteLine(name + ";" + password);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("abc.com", "aaa");
            yield return new TestCaseData("abc.com", "a");

        }

    }
}
