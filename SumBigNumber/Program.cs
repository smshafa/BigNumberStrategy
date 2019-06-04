﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Reflection;

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

            // First method: using factory method:
            ICalculate calculate = creator.FactoryMethod(CalculationCreator.OperationType.BigSum);

            // Second method: using Strategy method

            StandardKernel kernel = new StandardKernel();

            // Load Modules
            kernel.Load(Assembly.GetExecutingAssembly());

            // Gets a instance of the specified service.
            SumStrategy objCalculate = kernel.Get<SumStrategy>(); //"Sum"
            MultipleStrategy objCalculate2 = kernel.Get<MultipleStrategy>(); // "Multiple"

            // Inject 
            CalculatorContext calculatorContext = new CalculatorContext(objCalculate, objCalculate2);

            // Call method of context
            Console.WriteLine(calculatorContext.Sum(numHolder));
            //Console.WriteLine(calculatorContext.Multiple(numHolder));
            

            string result = calculate.Calculate(numHolder);
            Console.WriteLine($"Result is: {result}");
            
        }
    }
}
