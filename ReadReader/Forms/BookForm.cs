using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadReader
{
    public partial class BookForm : Form
    {
        Book book;
        public BookForm(Book book)
        {
            this.book = book;
            InitializeComponent();
            richTextBox.Rtf = book.RTF;
        }

        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            bookmarkPanel.Visible = !bookmarkPanel.Visible;
        }
    }
}
