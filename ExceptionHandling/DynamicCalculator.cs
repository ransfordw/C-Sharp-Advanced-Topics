using System;

namespace ExceptionHandling
{
    public class DynamicCalculator
    {
        public dynamic Divide(dynamic numerator, dynamic denomenator)
        {
            if (numerator.GetType() == typeof(string))
                if (!decimal.TryParse(numerator.ToString(), out decimal x) | !decimal.TryParse(denomenator.ToString(), out decimal y))
                    throw new InvalidOperationException("The values must be some type of number.");
                else
                    return x / y;

            return numerator / denomenator;
        }

        public static void WriteResult(object v)
        {
            Console.WriteLine(
                $"Result = {v}." +
                $"\nType = {v.GetType()}" +
                $"\n==========================="
                );
        }
        
    }
}
