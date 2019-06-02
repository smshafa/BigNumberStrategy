using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumber
{
    public class CalculationFactory : CalculationCreator
    {       
        public override ICalculate FactoryMethod(OperationType optType)
        {
            ICalculate calculate = null;
            switch (optType)
            {
                case OperationType.BigSum:
                    calculate = new BigSumStrategy();
                    break;
                case OperationType.BigMultiple:
                    calculate = new BigMultipleStrategy();
                    break;
            }

            return calculate;
        }
    }
}
