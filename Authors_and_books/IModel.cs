using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authors_and_books
{
    public interface IModel
    {
        Library library { get; set; } 
        Author author { get; set; }
        Book book { get; set;  }
        void AddBookToLibrary(string authorName, string bookTitle);
        List<Book> GetBooksByAuthor(string authorName);
        List<Author> GetAllAuthors();
        List<Book> GetAllBooks();
        void RemoveAuthorByName(string authorName);
        void RemoveBookByTitle(string bookTitle);
        void UpdateAuthorName(string currentName, string newName);
        void UpdateBookTitle(string currentTitle, string newTitle);
        void Load();
        void Save();
        void SortLibraryAlphabetically();
    }


}

