using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authors_and_books
{
    internal interface IView
    {
        event EventHandler<EventArgs> FileSaveClicked;
        event EventHandler<EventArgs> FileOpenClicked;
        event EventHandler<SelectionEventArgs> OptionsAddAuthorClicked;
        event EventHandler<SelectionEventArgs> OptionsAddBookClicked;
        event EventHandler<SelectionEventArgs> FilterEvent;
        event EventHandler<SelectionEventArgs> RemoveAuthorEvent; 
        event EventHandler<SelectionEventArgs> RemoveBookEvent;
        event EventHandler<SelectionEventArgs> EditAuthorEvent; 
        event EventHandler<SelectionEventArgs> EditBookEvent;
        event EventHandler<EventArgs> ExitEvent;  
        ComboBox ComboNameAuthor { get; set; }
        ListBox ListBoxBook {  get; set; }
        CheckBox CheckFilter {  get; set; }
        DialogResult MyMessageBox(string message, string caption);
        DialogResult result {  get; set; }
        DialogResult result2 { get; set; }
        void MyClose();
    }
    public class SelectionEventArgs : EventArgs
    {
        public string text1 {  get; set; }
        public string text2 { get; set; }
        public SelectionEventArgs(string text1, string text2)
        {
            this.text1 = text1; 
            this.text2 = text2;
        }
    }
}
