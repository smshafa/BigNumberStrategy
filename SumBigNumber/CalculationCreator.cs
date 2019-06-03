using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    /// <summary>
    /// An abstract class to creates factory design pattern.
    /// </summary>
    public abstract class CalculationCreator
    {
        /// <summary>
        /// The type of common math operations.
        /// </summary>
        public enum OperationType
        {
            BigSum,
            BigMultiple
        }
        /// <summary>
        /// Factory method delegate.
        /// </summary>
        /// <param name="optType">The type of common math operations.</param>
        /// <returns></returns>
        public abstract ICalculate FactoryMethod(OperationType optType);
    }
}
