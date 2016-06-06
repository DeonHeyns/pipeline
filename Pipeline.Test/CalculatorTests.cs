using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Pipeline.Test
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Test()
        {
            Calculator calc = new Calculator();

            int result = calc.Add(1, 2);

            Assert.AreEqual(3, result);
        }
    }
}
