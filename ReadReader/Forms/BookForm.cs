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
        BookFileSaver bookSaver;
        public BookForm(Book book, BookFileSaver bookSaver)
        {
            this.bookSaver = bookSaver;
            this.book = book;
            InitializeComponent();
            richTextBox.Rtf = book.RTF;
            bookmarkListBox.DataSource = book.Bookmarks;
            bookmarkListBox.DisplayMember = "Name";
        }

        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            bookmarkPanel.Visible = !bookmarkPanel.Visible;
        }

        private void bookmarkCloseButton_Click(object sender, EventArgs e)
        {
            bookmarkPanel.Hide();
        }

        private void AddBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkNameForm form = new BookmarkNameForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Bookmark bookmark = new Bookmark(richTextBox.SelectionStart, (string)form.Tag);
                book.Bookmarks.Add(bookmark);
                bookSaver.SaveBookmarks(book.Info.ID, book);
            }
        }

        private void bookmarkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            richTextBox.SelectionStart = ((Bookmark)listBox.SelectedItem).Position;
            richTextBox.ScrollToCaret();
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(richTextBox.SelectionStart.ToString());
        }

        private void richTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                richTextBox.SelectionStart = richTextBox.GetCharIndexFromPosition(e.Location);
                richTextBox.SelectionLength = 0;
            }
        }
    }
}