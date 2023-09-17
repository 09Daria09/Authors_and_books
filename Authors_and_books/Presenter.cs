using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Authors_and_books
{
    internal class Presenter
    {
        private IView _view;
        private IModel _model;

        public Presenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
            _view.FileSaveClicked += new EventHandler<EventArgs>(FileSave);
            _view.OptionsAddAuthorClicked += new EventHandler<SelectionEventArgs>(AddAuthor);
            _view.OptionsAddBookClicked += new EventHandler<SelectionEventArgs>(AddBook);
            _view.FileOpenClicked += new EventHandler<EventArgs>(FileOpen);
            _view.FilterEvent += new EventHandler<SelectionEventArgs>(Filtering);
            _view.RemoveAuthorEvent += new EventHandler<SelectionEventArgs>(RemoveAuthor);
            _view.RemoveBookEvent += new EventHandler<SelectionEventArgs>(RemoveBook);
            _view.EditAuthorEvent += new EventHandler<SelectionEventArgs>(EditAuthor);
            _view.EditBookEvent += new EventHandler<SelectionEventArgs>(EditBook);
            _view.ExitEvent += new EventHandler<EventArgs>(Exit);
        }

        private void Exit(object sender, EventArgs e)
        {
            _view.result = _view.MyMessageBox($"Желаете сохранить данные в файл?", "Подтверждение");
            if (_view.result == _view.result2)
            {
                _model.Save();
            }
            _view.MyClose();
        }

        private void EditAuthor(object sender, SelectionEventArgs e)
        {
            _model.UpdateAuthorName(e.text1, e.text2);
            UpDateView();
        }
        private void EditBook(object sender, SelectionEventArgs e)
        {
            _model.UpdateBookTitle(e.text1, e.text2);
            UpDateView();
        }
        private void RemoveAuthor(object sender, SelectionEventArgs e)
        {
            _view.result = _view.MyMessageBox($"Вы уверены, что хотите удалить автора {e.text1}?", "Подтверждение");
            if (_view.result == _view.result2)
            {
                _model.RemoveAuthorByName(e.text1);
                UpDateView();
            }
        }
        private void RemoveBook(object sender, SelectionEventArgs e)
        {
            _view.result = _view.MyMessageBox($"Вы уверены, что хотите удалить книгу {e.text2}?", "Подтверждение");
            if (_view.result == _view.result2)
            {
                _model.RemoveBookByTitle(e.text2);
                UpDateView();
            }
        }
        private void FileSave(object sender, EventArgs e)
        {
            _model.Save();
        }
        private void FileOpen(object sender, EventArgs e)
        {
            _model.Load();
            _model.SortLibraryAlphabetically();
            UpDateView();
        }
        private void AddAuthor(object sender, SelectionEventArgs e)
        {
            _model.AddBookToLibrary(e.text1, null);
            _view.ComboNameAuthor.Items.Add(e.text1);
        }
        private void AddBook(object sender, SelectionEventArgs e)
        {
            _model.AddBookToLibrary(e.text1, e.text2);
            _view.ListBoxBook.Items.Add(e.text2);
        }
        private void Filtering(object sender, SelectionEventArgs e)
        {
            if (_view.CheckFilter.Checked)
            {
                var books = _model.GetBooksByAuthor(e.text1);

                _view.ListBoxBook.Items.Clear();
                for (int i = 0; i < books.Count; i++)
                {
                    _view.ListBoxBook.Items.Add(books[i].Title);
                }
            }
            else
            {
                var books = _model.GetAllBooks();
                _view.ListBoxBook.Items.Clear();
                for (int i = 0; i < books.Count; i++)
                {
                    _view.ListBoxBook.Items.Add(books[i].Title);
                }
            }
        }
        private void UpDateView()
        {
            _view.ComboNameAuthor.Items.Clear();
            _view.ListBoxBook.Items.Clear();
            for (int i = 0; i < _model.library.Authors.Count; i++)
            {
                _view.ComboNameAuthor.Items.Add(_model.library.Authors[i].Name);
                for (int j = 0; j < _model.library.Authors[i].Books.Count; j++)
                {
                    if (_model.library.Authors[i].Books[j].Title != null)
                        _view.ListBoxBook.Items.Add(_model.library.Authors[i].Books[j].Title);
                }
            }
            if (_view.ComboNameAuthor.Items.Count > 0)
            {
                _view.ComboNameAuthor.SelectedIndex = 0;
            }
        }// Я планировала использовать здесь DataSource, как вы нам советовали,
         // но мне было совсем не удобно работать с ним в дальнейшем, поэтому я сделала так :)
         // Надеюсь, так тоже нормально
    }
}
