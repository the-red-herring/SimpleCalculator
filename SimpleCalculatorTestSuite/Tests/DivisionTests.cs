using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace CalculatorTestSuite
{
    [TestClass]
    public class DivisionTests
    {
        public SimpleCalculator _calculator;

        public DivisionTests()
        {
            _calculator = new SimpleCalculator();
        }

        [TestMethod]
        public void PositiveDividedByPositiveTest()
        {
            float expectedResult = 0.2f;
            var result = _calculator.Divide(2, 10);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PositiveDividedByNegativeTest()
        {
            float expectedResult = -0.5f;
            var result = _calculator.Divide(2, -4);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void NegativeDividedByPositiveTest()
        {
            float expectedResult = -0.2f;
            var result = _calculator.Divide(-2, 10);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void NegativeDividedByNegativeTest()
        {
            float expectedResult = 0.25f;
            var result = _calculator.Divide(-2, -8);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void PositiveDividedByZeroTest()
        {
            Assert.AreEqual(Single.PositiveInfinity, _calculator.Divide(243, 0));
        }

        [TestMethod]
        public void NegativeDividedByZeroTest()
        {
            Assert.AreEqual(Single.NegativeInfinity, _calculator.Divide(-243, 0));
        }

        // todo: add unit tests for checking that results are being logged correctly.
    }
}
