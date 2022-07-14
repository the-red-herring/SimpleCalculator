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
    public class AdditionTests
    {
        public SimpleCalculator _calculator;

        public AdditionTests()
        {
            _calculator = new SimpleCalculator();
        }

        [TestMethod]
        public void PositiveAddPositiveTest()
        {
            int expectedResult = 12;
            var result = _calculator.Add(2, 10);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void PositiveAddNegativeTest()
        {
            int expectedResult = -2;
            var result = _calculator.Add(2, -4);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void NegativeAddPositiveTest()
        {
            int expectedResult = 8;
            var result = _calculator.Add(-2, 10);
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void NegativeAddNegativeTest()
        {
            int expectedResult = -10;
            var result = _calculator.Add(-2, -8);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PositiveAddPositiveLoggingTest()
        {
            int expectedResult = 12;
            var result = _calculator.Add(2, 10);
            Assert.AreEqual(expectedResult, result);
        }
        
        // todo: add unit tests for checking that results are being logged correctly.
    }
}
