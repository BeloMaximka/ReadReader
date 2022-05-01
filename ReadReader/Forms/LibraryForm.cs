﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadReader
{
    public partial class LibraryForm : Form
    {
        LibraryManager libraryManager;
        BookFileLoader bookFileLoader;
        BookFileSaver bookFileSaver;
        public LibraryForm(string path)
        {
            libraryManager = new LibraryManager(path);
            bookFileLoader = new BookFileLoader(path);
            bookFileSaver = new BookFileSaver(path);

            InitializeComponent();
            this.Icon = Icon.FromHandle(Resource.icon.GetHicon());
            libraryListView.SmallImageList = new ImageList();
            libraryListView.SmallImageList.Images.Add(Resource.book);
            libraryListView.SmallImageList.Images.Add(Resource.bookadd);
            var books = bookFileLoader.LoadAllBooksFromDir();
            foreach (var book in books)
            {
                ListViewItem item = new ListViewItem(book.Title, 0);
                item.Tag = book.ID;
                libraryListView.Items.Add(item);
            }
            libraryListView.Items.Add(new ListViewItem("Добавить...", 1));
            libraryListView.Columns[0].Width = 185;
        }

        private void libraryListView_DoubleClick(object sender, EventArgs e)
        {
            ListView view = sender as ListView;
            if (view.Items[view.Items.Count - 1].Selected)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Book book = BookFileLoader.LoadFromFile(openFileDialog.FileName);
                    bookFileSaver.SaveBook(0, book);

                    ListViewItem item = new ListViewItem(book.Info.Title, 0);
                    item.Tag = libraryManager.ID;
                    view.Items.Insert(view.Items.Count - 1, item);
                }
            }
            else
            {
                Book book = bookFileLoader.LoadBookFromDir((uint)view.SelectedItems[0].Tag);
                Hide();
                BookForm form = new BookForm(book, bookFileSaver);
                form.Location = this.Location;
                form.ShowDialog();
                this.Location=form.Location;
                Show();
            }
        }

        private void libraryItemContext_Opening(object sender, CancelEventArgs e)
        {
            if (libraryListView.SelectedItems.Count == 0 ||
                libraryListView.Items[libraryListView.Items.Count - 1].Selected)
                e.Cancel = true;
        }

        private void libraryListView_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                Book book = BookFileLoader.LoadFromFile(file);
                bookFileSaver.SaveBook(0, book);

                ListViewItem item = new ListViewItem(book.Info.Title, 0);
                item.Tag = libraryManager.ID;
                libraryListView.Items.Insert(libraryListView.Items.Count - 1, item);
            }
        }

        private void libraryListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uint id = (uint)libraryListView.SelectedItems[0].Tag;
            libraryListView.Items.Remove(libraryListView.SelectedItems[0]);
            foreach (var directory in Directory.GetDirectories(".\\library"))
            {
                uint dirId;
                Regex regex = new Regex("\\\\\\d.+");
                string number = regex.Match(directory).ToString().Trim('\\', '.');
                if (uint.TryParse(number, out dirId) && dirId == id)
                {
                    Directory.Delete(directory, true);
                    return;
                }
            }
        }
    }
}