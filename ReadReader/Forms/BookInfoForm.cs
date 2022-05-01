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
    public partial class BookInfoForm : Form
    {
        Book book;
        public BookInfoForm(Book book)
        {
            this.book = book;
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            this.Icon = Icon.FromHandle(Resource.icon.GetHicon());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (bookNameTextBox.Text == "" || authorTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            book.Info.Title = bookNameTextBox.Text;
            book.Info.Authors.Add(authorTextBox.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
