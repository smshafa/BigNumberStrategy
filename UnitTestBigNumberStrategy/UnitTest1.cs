using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
using SumBigNumber;
using System;
using System.Collections.Generic;
using System.Reflection;

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

        [TestMethod]
        public void TestNinject()
        {

            List<string> mylist = new List<string>(new string[] { "121556550", "15589455452", "2254564555565552", "5554525455454554565" });
            StandardKernel kernel = new StandardKernel();

            // Load Modules
            kernel.Load(Assembly.GetExecutingAssembly());

            CalculatorContext calculatorContext = null;
            try
            {

                // Gets a instance of the specified service.
                SumStrategy objCalculate = kernel.Get<SumStrategy>();//("Sum");
                MultipleStrategy objCalculate2 = kernel.Get<MultipleStrategy>();// ("Multiple");


                // Inject 
                calculatorContext = new CalculatorContext(objCalculate, objCalculate2);
            }
            catch(Exception ex)
            {
                Assert.Fail();
            }


            // Call method of context
            Assert.AreEqual(calculatorContext.Sum(mylist), "5556780035721132119");
        }
    }
}
