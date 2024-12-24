using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestprojectdecBatchEGIndia.NUnitTest
{
    [TestFixture(2,3)]
    [TestFixture(4,5)]
    [TestFixture(4,7)]
    internal class ParamaeterTestFixture
    {
        private readonly int _a;
        private readonly int _b;

        public ParamaeterTestFixture(int a, int b)
        {
            _a = a;
            _b = b;   

        }
        [Test]
        public void Sum()
        {
            Assert.AreEqual(_a +_b, _a * 1 + _b * 1);

        }
        [Test]
        public void prod()
        {
            Assert.AreEqual(_a * _b, _a * _b);

        }

    }

}
