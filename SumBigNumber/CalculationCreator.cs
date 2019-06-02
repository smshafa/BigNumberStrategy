using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    public abstract class CalculationCreator
    {
        public enum OperationType
        {
            BigSum,
            BigMultiple
        }
        public abstract ICalculate FactoryMethod(OperationType optType);
    }
}
