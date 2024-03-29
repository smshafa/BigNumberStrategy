﻿using System.Collections.Generic;

namespace BigNumberStrategy
{
    /// <summary>
    /// A common interface for calculating common math operations.
    /// </summary>
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
