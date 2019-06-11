using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Reflection;
using BigNumberStrategy;

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
            // Arrange
            List<string> mylist = new List<string>(new string[] { "121556550", "15589455452", "2254564555565552", "5554525455454554565" });
            StandardKernel kernel = new StandardKernel();

            // Load Modules
            // Assemblies of the current project (Assemblies in Unit Test).
            //kernel.Load(Assembly.GetExecutingAssembly());

            // Assemblies of the solution (Assemblies in all projects).
            kernel.Load(AppDomain.CurrentDomain.GetAssemblies());

            CalculatorContext calculatorContext = null;
            try
            {

                // Gets a instance of the specified service.
                SumStrategy objCalculate = kernel.Get<SumStrategy>();//("Sum");
                MultipleStrategy objCalculate2 = kernel.Get<MultipleStrategy>();// ("Multiple");


                // Act: Inject 
                calculatorContext = new CalculatorContext(objCalculate, objCalculate2);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }


            // Assert
            Assert.AreEqual(calculatorContext.Sum(mylist), "5556780035721132119");
        }

        [TestMethod]
        public void TestMultiple_Mock()
        {
            // Arrange           
            List<string> mylist = new List<string>(new string[] { "121556550", "15589455452"});

            Mock<BigMultipleStrategy> mock = new Mock<BigMultipleStrategy>();

            // Act
            mock.Setup(m => m.Calculate(mylist)).Returns("1895000421123810600");
            string result = mock.Object.Calculate(mylist);

            // Assert
            Assert.AreEqual(result, "1895000421123810600");
        }
    }
}
