using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface ICalculate
    {
        int GetTotal();
        void Calculate(int num1, int num2);
    }
}
