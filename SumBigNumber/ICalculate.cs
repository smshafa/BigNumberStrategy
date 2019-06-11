using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    public interface ICalculate
    {
        /// <summary>
        /// Calculates math operation.
        /// </summary>
        /// <param name="stringNum">A set of big digit numbers.</param>
        /// <returns></returns>
        string Calculate(List<string> stringNum);
    }
}
