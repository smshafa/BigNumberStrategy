using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    public abstract class SumStrategy : ICalculate
    {
        public abstract string Calculate(string[] stringNum);
    }
}
