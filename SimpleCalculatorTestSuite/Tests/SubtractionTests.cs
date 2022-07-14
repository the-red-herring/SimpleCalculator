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
    public class SubtractionTests
    {
        public SimpleCalculator _calculator;

        public SubtractionTests()
        {
            _calculator = new SimpleCalculator();
        }

        [TestMethod]
        public void PositiveMinusPositiveTest()
        {
            int expectedResult = -8;
            var result = _calculator.Subtract(2, 10);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PositiveMinusNegativeTest()
        {
            int expectedResult = 6;
            var result = _calculator.Subtract(2, -4);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void NegativeMinusPositiveTest()
        {
            int expectedResult = -12;
            var result = _calculator.Subtract(-2, 10);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void NegativeMinusNegativeTest()
        {
            int expectedResult = 6;
            var result = _calculator.Subtract(-2, -8);
            Assert.AreEqual(expectedResult, result);
        }

        // todo: add unit tests for checking that results are being logged correctly.
    }
}
