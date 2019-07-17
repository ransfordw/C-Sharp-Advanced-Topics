using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Ransford";
            // obj.GetHashCode();

            dynamic name = "Ransford";
            name = 10;

            Console.WriteLine($"{name} is {name.GetType()}");


            dynamic a = 10;
            dynamic b = 5;
            var c = a+b;

            int i = 5;
            dynamic d = i;
            long l = d;

            // Reflection
            // var methodInfo = obj.GetType().GetMethod("GetHashCode");
            // methodInfo.Invoke(null, null);

            // dynamic excelObject = "Ransford";
            // excelObject.Optimize(); // with 'object' instead of 'dynamic' this would have a compile-time error


        }
    }
}
