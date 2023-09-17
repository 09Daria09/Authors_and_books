using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authors_and_books
{
    internal class Model : IModel
    {
        public Library library { get; set; } = new Library();
        public Author author { get; set; } = new Author();
        public Book book { get; set; } = new Book();
        public void AddBookToLibrary(string authorName, string bookTitle)
        {
            author = library.Authors.FirstOrDefault(a => a.Name == authorName);

            if (author == null)
            {
                author = new Author { Name = authorName };
                library.Authors.Add(author);
            }
            if (bookTitle != null)
            {
                book = new Book { Title = bookTitle };
                author.Books.Add(book);
            }
        }
        public List<Book> GetBooksByAuthor(string authorName)
        {
            var author = library.Authors.FirstOrDefault(a => a.Name == authorName);
            return author?.Books ?? new List<Book>();
        }
        public List<Book> GetAllBooks()
        {
            return library.Authors.SelectMany(author => author.Books).ToList();
        }
        public List<Author> GetAllAuthors()
        {
            return library.Authors;
        }
        public void RemoveAuthorByName(string authorName)
        {
            library.Authors.RemoveAll(a => a.Name == authorName);
        }
        public void RemoveBookByTitle(string bookTitle)
        {
            foreach (var author in library.Authors)
            {
                var bookToRemove = author.Books.FirstOrDefault(b => b.Title == bookTitle);
                if (bookToRemove != null)
                {
                    author.Books.Remove(bookToRemove);
                }
            }
        }
        public void UpdateAuthorName(string currentName, string newName)
        {
            var authorToUpdate = library.Authors.FirstOrDefault(a => a.Name == currentName);
            if (authorToUpdate != null)
            {
                authorToUpdate.Name = newName;
            }
        }
        public void UpdateBookTitle(string currentTitle, string newTitle)
        {
            foreach (var author in library.Authors)
            {
                var bookToUpdate = author.Books.FirstOrDefault(b => b.Title == currentTitle);
                if (bookToUpdate != null)
                {
                    bookToUpdate.Title = newTitle;
                }
            }
        }
        public void Load()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Выберите файл для загрузки данных"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    var jsonFormatter = new DataContractJsonSerializer(typeof(List<Author>));
                    var loadedData = (List<Author>)jsonFormatter.ReadObject(stream);

                    library.Authors.Clear();
                    foreach (Author author in loadedData)
                    {
                        library.Authors.Add(author);
                    }
                }
            }
        }
        public void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Выберите место для сохранения данных"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    var jsonFormatter = new DataContractJsonSerializer(typeof(List<Author>));
                    jsonFormatter.WriteObject(stream, library.Authors);
                }
            }
        }
        public void SortLibraryAlphabetically()
        {
            // Сортируем авторов по имени
            library.Authors = library.Authors.OrderBy(a => a.Name).ToList();

            // Для каждого автора сортируем его книги по названию
            foreach (var author in library.Authors)
            {
                author.Books = author.Books.OrderBy(b => b.Title).ToList();
            }
        }

    }

}
