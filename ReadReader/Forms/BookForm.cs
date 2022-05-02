using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReadReader
{
    public partial class BookForm : Form
    {
        Theme lightTheme;
        Theme darkTheme;

        Book book;
        BookFileSaver bookSaver;
        public BookForm(Book book, BookFileSaver bookSaver, Theme lightTheme, Theme darkTheme)
        {

            this.bookSaver = bookSaver;
            this.book = book;
            InitializeComponent();
            this.Icon = Icon.FromHandle(Resource.icon.GetHicon());

            this.Text = book.Info.Title;
            richTextBox.Rtf = book.RTF;
            bookmarkListBox.DataSource = book.Bookmarks;
            bookmarkListBox.DisplayMember = "Name";
            bookmarkListBox.SelectedIndex = book.Bookmarks.Count - 1;
            noteListBox.DataSource = book.Notes;
            noteListBox.DisplayMember = "Name";

            this.darkTheme = darkTheme;
            this.lightTheme = lightTheme;
            if (File.Exists("theme"))
                ChangeTheme(File.ReadAllText("theme") == "dark");
            else
            {
                File.WriteAllText("theme", "light");
                ChangeTheme(false);
            }
        }
        private void ChangeTheme(bool dark)
        {
            Theme theme = dark ? darkTheme : lightTheme;
            bookmarkListBox.BackColor = theme.BackColor;
            bookmarkListBox.ForeColor = theme.ForeColor;
            noteListBox.BackColor = theme.BackColor;
            noteListBox.ForeColor = theme.ForeColor;
            richTextBox.BackColor = theme.BackgroundColor;
            richTextBox.ForeColor = theme.ForeColor;
            mainToolStrip.BackColor = theme.BackColor;
            mainToolStrip.ForeColor = theme.ForeColor;
            BackColor = theme.BackgroundColor;
            ForeColor = theme.ForeColor;
            bookmarkToolStrip.BackColor = theme.BackColor;
            bookmarkToolStrip.ForeColor = theme.ForeColor;
            notesToolStrip.BackColor = theme.BackColor;
            notesToolStrip.ForeColor = theme.ForeColor;
            if (dark)
            {
                themeButton.Image = Resource.sun_wh;
                bookmarkButton.Image = Resource.bookmark_wh;
                notesButton.Image = Resource.note_wh;
                closeNotesButton.Image = Resource.close_wh;
                bookmarkCloseButton.Image = Resource.close_wh;
            }
            else
            {
                themeButton.Image = Resource.moon_bl;
                bookmarkButton.Image = Resource.bookmark_bl;
                notesButton.Image = Resource.note_bl;
                closeNotesButton.Image = Resource.close_bl;
                bookmarkCloseButton.Image = Resource.close_bl;
            }
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
            Theme theme = File.ReadAllText("theme") == "dark" ? darkTheme : lightTheme;
            BookmarkNameForm form = new BookmarkNameForm(theme);
            form.Location = MousePosition;
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

        private void richTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && richTextBox.SelectionLength == 0)
            {
                richTextBox.SelectionStart = richTextBox.GetCharIndexFromPosition(e.Location);
            }
        }

        private void bookmarkContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (bookmarkListBox.IndexFromPoint(bookmarkListBox.PointToClient(Control.MousePosition)) == -1)
                e.Cancel = true;
        }

        private void deleteBookmarkMenuItem_Click(object sender, EventArgs e)
        {
            int index = bookmarkListBox.IndexFromPoint(bookmarkListBox.PointToClient(bookmarkContextMenu.Bounds.Location));
            book.Bookmarks.RemoveAt(index);
            bookSaver.SaveBookmarks(book.Info.ID, book);
        }

        private void renameBookmarkMenuItem_Click(object sender, EventArgs e)
        {
            Theme theme = File.ReadAllText("theme") == "dark" ? darkTheme : lightTheme;
            BookmarkNameForm form = new BookmarkNameForm(theme);
            if (form.ShowDialog() == DialogResult.OK)
            {
                int index = bookmarkListBox.IndexFromPoint(bookmarkListBox.PointToClient(bookmarkContextMenu.Bounds.Location));
                book.Bookmarks[index].Name = (string)form.Tag;
                bookmarkListBox.DrawMode = DrawMode.OwnerDrawFixed;
                bookmarkListBox.DrawMode = DrawMode.Normal;
                bookSaver.SaveBookmarks(book.Info.ID, book);
            }
        }

        private void notesButton_Click(object sender, EventArgs e)
        {
            notesPanel.Visible = !notesPanel.Visible;
        }

        private void closeNotesButton_Click(object sender, EventArgs e)
        {
            notesPanel.Hide();
        }

        private void richTextBox_SelectionChanged(object sender, EventArgs e)
        {
            AddNoteMenuItem.Visible = richTextBox.SelectionLength > 0;
        }

        private void AddNoteMenuItem_Click(object sender, EventArgs e)
        {
            Theme theme = File.ReadAllText("theme") == "dark" ? darkTheme : lightTheme;
            NoteAddForm form = new NoteAddForm(richTextBox.SelectedText, theme);
            form.Location = MousePosition;
            if (form.ShowDialog() == DialogResult.OK)
            {
                Note note = (Note)form.Tag;
                note.StartIndex = richTextBox.SelectionStart;
                note.EndIndex = richTextBox.SelectionStart + richTextBox.SelectionLength;
                book.Notes.Add(note);
                bookSaver.SaveNotes(book.Info.ID, book);
            }
        }

        private void noteContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (noteListBox.IndexFromPoint(noteListBox.PointToClient(Control.MousePosition)) == -1)
                e.Cancel = true;
        }

        private void deleteNoteMenuItem_Click(object sender, EventArgs e)
        {
            int index = noteListBox.IndexFromPoint(noteListBox.PointToClient(noteContextMenu.Bounds.Location));
            book.Notes.RemoveAt(index);
            bookSaver.SaveNotes(book.Info.ID, book);
        }

        private void noteListBox_Click(object sender, EventArgs e)
        {
            int index = noteListBox.IndexFromPoint(noteListBox.PointToClient(Control.MousePosition));
            if (index != -1)
            {
                Note note = noteListBox.Items[index] as Note;
                string text = richTextBox.Text.Substring(note.StartIndex, note.EndIndex - note.StartIndex);
                Theme theme = File.ReadAllText("theme") == "dark" ? darkTheme : lightTheme;
                if (new NoteForm(text, note, theme).ShowDialog() == DialogResult.OK)
                {
                    noteListBox.DrawMode = DrawMode.OwnerDrawFixed;
                    noteListBox.DrawMode = DrawMode.Normal;
                    bookSaver.SaveNotes(book.Info.ID, book);
                }
            }
        }

        private void themeButton_Click(object sender, EventArgs e)
        {
            string theme = File.ReadAllText("theme");
            File.WriteAllText("theme", theme == "dark" ? "light" : "dark");
            ChangeTheme(theme != "dark");
        }
    }
}