using System;
using System.Collections.Generic;

namespace SumBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***BigNumberStrategy***");
            Console.WriteLine("Please input the count of your numbers");
            byte countNum = Convert.ToByte(Console.ReadLine());
            List<string> numHolder = new List<string>();
            for(int i = 0; i < countNum; i++)
            {
                Console.WriteLine($"Number {i}:");
                numHolder.Add(Console.ReadLine());
            }

            Console.WriteLine("Please Choose your operation:");
            Console.WriteLine("1: +\n2: *\n3:-");
            string opt = Console.ReadLine();

            var creator = new CalculationFactory();
            ICalculate calculate = creator.FactoryMethod(CalculationCreator.OperationType.BigSum);

            string result = calculate.Calculate(numHolder);
            Console.WriteLine($"Result is: {result}");
            
        }
    }
}
