namespace BigNumberStrategy
{
    /// <summary>
    /// Factory method is implemented by this class.
    /// </summary>
    public class CalculationFactory : CalculationCreator
    {       
        /// <summary>
        /// Which instance of math operation should be concreted.
        /// </summary>
        /// <param name="optType"></param>
        /// <returns></returns>
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
