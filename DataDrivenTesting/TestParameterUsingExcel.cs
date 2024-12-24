using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilities;

namespace TestprojectdecBatchEGIndia.DataDrivenTesting
{
    internal class TestParameterUsingExcel
    {
        [Test, TestCaseSource("GetTestData")]
        public void Test(string name, string password)
        {
            Console.WriteLine(name + ";" + password);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> { "username", "password" };
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\anami\\source\\repos\\TestprojectdecBatchEGIndia\\TestprojectdecBatchEGIndia\\Testdata.xlsx", "LoginTest", columns);
            
        }
    }
}
