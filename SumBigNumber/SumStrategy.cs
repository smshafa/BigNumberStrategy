using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    /// <summary>
    /// SumStrategy class provides an abstract view to implement different strategy for add(sum) numbers.
    /// </summary>
    public abstract class SumStrategy : ICalculate
    {
        public abstract string Calculate(string[] stringNum);
    }
}
