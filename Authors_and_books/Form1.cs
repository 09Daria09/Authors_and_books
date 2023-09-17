using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authors_and_books
{
    public partial class Form1 : Form, IView
    {
        public ComboBox ComboNameAuthor { get; set; }
        public ListBox ListBoxBook { get; set; }
        public CheckBox CheckFilter { get; set ; }
        public DialogResult result { get; set; }
        public DialogResult result2 { get; set; }

        public Form1()
        {
            InitializeComponent();
            ComboNameAuthor = comboBox1;
            ListBoxBook = listBox1;
            CheckFilter = checkBox1;
            result2 = DialogResult.Yes; 
        }

        public event EventHandler<EventArgs> FileSaveClicked;
        public event EventHandler<SelectionEventArgs> OptionsAddAuthorClicked;
        public event EventHandler<SelectionEventArgs> OptionsAddBookClicked;
        public event EventHandler<EventArgs> FileOpenClicked;
        public event EventHandler<SelectionEventArgs> FilterEvent;
        public event EventHandler<SelectionEventArgs> RemoveAuthorEvent;
        public event EventHandler<SelectionEventArgs> RemoveBookEvent;
        public event EventHandler<SelectionEventArgs> EditAuthorEvent;
        public event EventHandler<SelectionEventArgs> EditBookEvent;
        public event EventHandler<EventArgs> ExitEvent; 

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileSaveClicked?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void добавитьАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additional additional = new Additional();
            additional.TextLabel = "Введите ФИО автора:";
            string NameAuhtor = null;

            if (additional.ShowDialog() == DialogResult.OK)
            {
                NameAuhtor = additional.TextBox;
            try
            {
                OptionsAddAuthorClicked?.Invoke(this, new SelectionEventArgs(NameAuhtor, null));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        }
        private void добавитьКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additional additional = new Additional();
            additional.TextLabel = $"Автор книги - {ComboNameAuthor.Text}\n"+"Введите название книги:";
            string Title = null; 

            if (additional.ShowDialog() == DialogResult.OK)
            {
                Title = additional.TextBox;
                try
                {
                    OptionsAddBookClicked?.Invoke(this, new SelectionEventArgs(ComboNameAuthor.SelectedText, Title));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileOpenClicked?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                FilterEvent?.Invoke(this, new SelectionEventArgs(ComboNameAuthor.SelectedItem.ToString(), null));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
        }
        private void удалитьАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveAuthorEvent?.Invoke(this, new SelectionEventArgs(ComboNameAuthor.SelectedItem.ToString(), null));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void удалитьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveBookEvent?.Invoke(this, new SelectionEventArgs(null, ListBoxBook.SelectedItem.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void редактироватьАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additional additional = new Additional();
            additional.TextLabel = $"{ComboNameAuthor.SelectedItem}\n" +"Измените ФИО автора:";
            string NameAuhtor = null;
            if (additional.ShowDialog() == DialogResult.OK)
            {
                NameAuhtor = additional.TextBox;
                try
                {
                    EditAuthorEvent?.Invoke(this, new SelectionEventArgs(ComboNameAuthor.SelectedItem.ToString(), NameAuhtor)); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void редактироватьКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Additional additional = new Additional();
            additional.TextLabel = $"{ListBoxBook.SelectedItem}\n" + "Измените название книги:";
            string Title = null; 

            if (additional.ShowDialog() == DialogResult.OK)
            {
                Title = additional.TextBox;
                try
                {
                    EditBookEvent?.Invoke(this, new SelectionEventArgs(ListBoxBook.SelectedItem.ToString(), Title));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ExitEvent?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DialogResult MyMessageBox(string message, string caption) 
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void MyClose()
        {
            Close();
        }
    }
}
