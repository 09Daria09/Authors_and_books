using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors_and_books
{
    public class Book
    {
        public string Title { get; set; }
        public Book() { }
    }
    public class Author
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
    public class Library
    {
        public List<Author> Authors { get; set; } = new List<Author>();
    }
}
