using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "Ado.Net Step by Step", Price = 5 },
                new Book(){Title = "ASP.NET MVC", Price = 9.99f},
                new Book(){Title = "ASP.NEW Web API", Price = 12f},
                new Book(){Title = "C# Advanced Topics", Price = 7f},
                new Book(){Title = "C# Advanced Topics", Price = 9f}
            };
        }
    }
}
