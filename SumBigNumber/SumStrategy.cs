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
        /// <summary>
        /// An abstract method to implement different sum operations.
        /// </summary>
        /// <param name="stringNum">A set of numbers to add.</param>
        /// <returns>Result of sum.</returns>
        public abstract string Calculate(List<string> stringNum);
    }
}
