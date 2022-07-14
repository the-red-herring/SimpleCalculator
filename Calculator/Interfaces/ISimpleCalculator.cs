﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    public interface ISimpleCalculator
    {
        int Add(int start, int amount);
        int Subtract(int start, int amount);
        int Multiply(int start, int by);
        float Divide(int start, int by);
    }
}
