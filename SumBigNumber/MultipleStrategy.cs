using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    /// <summary>
    /// An abstract class to calculate multiple operation.
    /// </summary>
    public abstract class MultipleStrategy : ICalculate
    {
        /// <summary>
        /// Calculate multiple operation.
        /// </summary>
        /// <param name="stringNum">A set of big digit numbers.</param>
        /// <returns>The result of multiple.</returns>
        public abstract string Calculate(List<string> stringNum);
    }
}
