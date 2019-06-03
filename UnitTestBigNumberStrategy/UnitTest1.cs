using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumBigNumber;
using System.Collections.Generic;

namespace UnitTestBigNumberStrategy
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMultiAdd()
        {
            // Arrange
            var creator = new CalculationFactory();
            ICalculate calculate = creator.FactoryMethod(CalculationCreator.OperationType.BigSum);            
            List<string> mylist = new List<string>(new string[] { "121556550", "15589455452", "2254564555565552", "5554525455454554565" });
                        
            // Act
            string multiResult = calculate.Calculate(mylist);

            // Assert
            Assert.AreEqual(multiResult, "5556780035721132119");
        }
    }
}
