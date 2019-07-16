using System;

namespace LamdaExpressions
{
    class Program
    {
        // Lambda Expressions are anonymous methods
        // They have no access modifier
        // They have no name
        // And they have no return statement

        // They are convenient and more readable

        static void Main(string[] args)
        {
            // args => expression : reads, 'Args goes to expression'
            // number => number * number;

            // if no agruments
            // () => ...

            // x => ...
            //(x, y, z) => ...

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;

            var result = multiplier(10);
            Console.WriteLine(result);

            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            var books = new BookRepository().GetBooks();
            // var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks) Console.WriteLine(book.Title);

            Console.ReadKey();
        }

        // Predicate delegate
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
