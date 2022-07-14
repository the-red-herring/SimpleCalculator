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
    public class MultiplicationTests
    {
        public SimpleCalculator _calculator;

        public MultiplicationTests()
        {
            _calculator = new SimpleCalculator();
        }

        [TestMethod]
        public void PositiveMultipliedByPositiveTest()
        {
            int expectedResult = 20;
            var result = _calculator.Multiply(2, 10);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PositiveMultipliedByNegativeTest()
        {
            int expectedResult = -8;
            var result = _calculator.Multiply(2, -4);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void NegativeMultipliedByPositiveTest()
        {
            int expectedResult = -20;
            var result = _calculator.Multiply(-2, 10);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void NegativeMultipliedByNegativeTest()
        {
            int expectedResult = 16;
            var result = _calculator.Multiply(-2, -8);
            Assert.AreEqual(expectedResult, result);
        }

        // todo: add unit tests for checking that results are being logged correctly.
    }
}
