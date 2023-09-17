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
    public partial class Additional : Form
    {
        public Additional()
        {
            InitializeComponent();
        }
        public string TextLabel
        {
            get { return label1.Text.Trim(); }
            set { label1.Text = value; }
        }
        public string TextBox
        {
            get { return textBox1.Text.Trim(); }
            set { textBox1.Text = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
