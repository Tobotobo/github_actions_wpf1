using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WpfApp1.Models;

namespace WpfApp1Test.Models
{
    [TestFixture]
    public class CalcServiceTest
    {
        private CalcService calcService = new CalcService();

        [TestCase(1, 1, 2)]
        [TestCase(1, 2, 3)]
        [TestCase(2, 1, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -2, -3)]
        [TestCase(123456789, 100000000, 223456789)]
        [TestCase(-123456789, -100000000, -223456789)]
        public void SumTest(int a, int b, int ans)
        {
            Assert.AreEqual(calcService.Sum(a, b), ans);
        }

        [TestCase(0, 0, 0)]
        [TestCase(0, 1, 0)]
        [TestCase(1, 0, 0)]
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 3, 6)]
        [TestCase(1, -1, -1)]
        [TestCase(-1, -1, 1)]
        public void ProductTest(int a, int b, int ans)
        {
            Assert.AreEqual(calcService.Product(a, b), ans);
        }
    }
}
