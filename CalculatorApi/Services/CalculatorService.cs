using CalculatorApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Interfaces;
using Calculator;

namespace CalculatorApi.Services
{
    public class CalculatorService : ICalculatorService
    {
        public ISimpleCalculator _calculator;
        public CalculatorService()
        {
            _calculator = new SimpleCalculator();
        }

        public int Add(int start, int amount)
        {
            return _calculator.Add(start, amount);
        }

        public float Divide(int start, int by)
        {
            return _calculator.Divide(start, by);
        }

        public int Multiply(int start, int by)
        {
            return _calculator.Multiply(start, by);
        }

        public int Subtract(int start, int amount)
        {
            return _calculator.Subtract(start, amount);
        }
    }
}
