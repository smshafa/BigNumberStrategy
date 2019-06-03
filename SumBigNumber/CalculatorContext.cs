using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    /// <summary>
    /// Context of factory method pattern.
    /// </summary>
    public class BigCalculatorContext
    {
        /// <summary>
        /// Calculate operation on set of big digit numbers.
        /// </summary>
        /// <param name="calculate">The type of operation.</param>
        /// <param name="stringNum">A set of big digit numbers.</param>
        /// <returns></returns>
        public string Calculate(ICalculate calculate, List<string> stringNum)
        {
            return calculate.Calculate(stringNum);            
        }
    }
}
