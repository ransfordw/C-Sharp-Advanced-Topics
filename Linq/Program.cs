using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        // Language Integrated Query
        // Give the ability to query object directly in C#
        // Objects in memory(collections etc), Dbs, XML, Data Sets
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // Linq Extension Methods Syntax
            var cheapBooks =
                books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            // Linq Query Operators Syntax
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            var singleBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC"); // the or default handles if the condition is not met
            var first = books.First(b => b.Title == "C# Advanced Topics"); // also has an "OrDefault" verison
            //.Last does the opposite

            var pagedBooks = books.Skip(2).Take(3);

            Console.WriteLine("count: " +books.Count());

            var mostExpensive = books.Max(b => b.Price);
            var mostCheap = books.Min(b => b.Price);
            var totalCost = books.Sum(b => b.Price);

            Console.WriteLine($"1.{mostExpensive} then 2.{mostCheap} then 3.{totalCost}");

            foreach (var book in pagedBooks)
            {
                Console.WriteLine(book.Title);
            }
            //foreach (var book in cheapBooks)
            //{
            //    //Console.WriteLine((book.Title + " " + book.Price));
            //    Console.WriteLine(book);
            //}
            //Console.WriteLine("Desired book: " + singleBook.Title);
            Console.WriteLine(first.Title + " " + first.Price);
        }
    }

}
