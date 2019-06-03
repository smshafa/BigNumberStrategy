using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    public class BigCalculatorContext
    {
        public string Calculate(ICalculate calculate, List<string> stringNum)
        {
            return calculate.Calculate(stringNum);            
        }
    }
}
