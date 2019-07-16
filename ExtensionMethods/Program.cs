using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        // Extension Methods allow us to add mehtods to an existing class with out modifying the base code or creating a new inheritance class from it
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";
            var shortendPost = post.Shorten(5); // to create an extension, you will need to create a static class

            IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
            var max =numbers.Max();
            Console.WriteLine(max);

            Console.WriteLine(shortendPost);
        }
    }
}
