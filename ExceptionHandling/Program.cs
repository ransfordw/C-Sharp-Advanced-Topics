using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calc = new Calculator();
                var result = calc.Divide(5, 0);

            }
            catch (Exception ex) // 'Exception' is the parent of all exceptions in C#
            {
                Console.WriteLine($"Sorry, an unexpected error occured: {ex.Message}");
            }

        }

        static void DynamicCalcMain(string[] args)
        {
            var calc = new DynamicCalculator();

            Console.Write("Please enter the numbers you would like to divide:");
            var responseOne = Console.ReadLine();
            var responseTwo = Console.ReadLine();
            Thread.Sleep(1500);

            Console.WriteLine("Press any key to see our result!");

            DynamicCalculator.WriteResult(calc.Divide(responseOne, responseTwo));

            var numbers = new List<object>() { 12f, 3f, 12d, 3d, 12, 3, "two", "seven" };
            var results = new List<object>();
            try
            {

                for (int i = 0; i < numbers.Count; i += 2)
                {
                    results.Add(calc.Divide(numbers[i], numbers[i + 1]));
                    DynamicCalculator.WriteResult(results.Last());
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message} ");
            }
        }

    }

    public class Calculator
    {
        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }
}
