using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace ExceptionHandling
{

    class Program
    {
        static void Main(string[] args)
        {
            #region StreamReader Example
            // StreamReader streamReader = null;
            try
            {
                
                // using statement here allows us to not need to dispose, and thus not need the finally block
                using (var streamReader = new StreamReader(@"C:\Personal Projects\Udemy\C-Sharp-Intermediate-Skills\log.txt"))
                {
                    var content = streamReader.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry, an unexpected error ocurred: {ex.Message}");
            }
            //finally // Finally blocks are always excuted, regardless of whether or not an exception is thrown.
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose(); // prevents us from accidentally leaving a file open on the disk, leaving network or db connections open, and overloading resources
            //}
            #endregion

            #region YouTubeApi Example
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("ransford");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Inner Execption: " + ex.InnerException.Message);
            }

            #endregion

            #region Caclulator
            try
            {
                var calc = new Calculator();
                var result = calc.Divide(5, 0);

            }
            catch (DivideByZeroException ex) { Console.WriteLine("You cannont divide by zero."); }
            catch (ArithmeticException ex) { Console.WriteLine("Your Maths were bad."); }
            catch (Exception ex) // 'Exception' is the parent of all exceptions in C#
            {
                Console.WriteLine($"Sorry, an unexpected error occured: {ex.Message}");
            }
            finally
            {

            }
            #endregion
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message} ");
            }
        }

    }
}
