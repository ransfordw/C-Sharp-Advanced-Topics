using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    #region ObjectList
    public class ObjectList
    {
        // requires boxing and unboxing which has a performance penalty
        // Generics avoid this penalty.
        public void Add(object value)
        {

        }
        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };
            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(book);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", book);

            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Actual value: " + number.GetValueOrDefault());



            Console.ReadKey();
        }
    }
}
