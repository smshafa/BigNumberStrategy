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
        SumStrategy sumStrategy;
        MultipleStrategy multipleStrategy;

        public BigCalculatorContext(SumStrategy sumStrategy, MultipleStrategy multipleStrategy)
        {
            this.sumStrategy = sumStrategy;
            this.multipleStrategy = multipleStrategy;
        }
        /// <summary>
        /// Calculate sum operation on set of big digit numbers.
        /// </summary>        
        /// <param name="stringNum">A set of big digit numbers.</param>
        /// <returns>Sum of given numbers.</returns>
        public string Sum(List<string> stringNum)
        {
            return sumStrategy.Calculate(stringNum);            
        }

        /// <summary>
        /// Calculate multiple operation on set of big digit numbers.
        /// </summary>
        /// <param name="stringNum">A set of big digit numbers.</param>
        /// <returns>Multiple of given numbers.</returns>
        public string Multiple(List<string> stringNum)
        {
            return multipleStrategy.Calculate(stringNum);
        }
    }
}
