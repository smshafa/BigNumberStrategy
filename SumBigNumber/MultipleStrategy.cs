using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    public abstract class MultipleStrategy : ICalculate
    {
        public abstract string Calculate(List<string> stringNum);
    }
}
