using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SimpleCalculator : ISimpleCalculator
    {
        public interface IDiagonsticsHelper
        {
            string WriteResultToDebugger<T>(int a, int b, Operations operation, T result);
        }

        public class DiagnosticsHelper : IDiagonsticsHelper
        {
            public string WriteResultToDebugger<T>(int a, int b, Operations operation, T result)
            {
                return $"Params: {a}, {b}. \n Operation: {operation.ToString()} \n Result: {result}";
            }
        };

        public IDiagonsticsHelper _diagnosticsHelper;

        public SimpleCalculator()
        {
            _diagnosticsHelper = new DiagnosticsHelper();
        }

        public int Add(int start, int amount)
        {
            var result = start + amount;
            _diagnosticsHelper.WriteResultToDebugger(start, amount, Operations.Add, result);
            return result;
        }

        public float Divide(int start, int by)
        {
            var result = (float)start / (float)by;
            _diagnosticsHelper.WriteResultToDebugger(start, by, Operations.Divide, result);
            return result;
        }

        public int Multiply(int start, int by)
        {
            var result = start * by;
            _diagnosticsHelper.WriteResultToDebugger(start, by, Operations.Multiply, result);
            return result;
        }

        public int Subtract(int start, int amount)
        {
            var result = start - amount;
            _diagnosticsHelper.WriteResultToDebugger(start, amount, Operations.Subtract, result);
            return result;
        }
    }
}
