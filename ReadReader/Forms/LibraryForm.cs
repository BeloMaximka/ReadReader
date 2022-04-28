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
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
            libraryListView.SmallImageList = new ImageList();
            libraryListView.SmallImageList.Images.Add(Resource.address_book);
            libraryListView.SmallImageList.Images.Add(Resource.address_book_add);
            var books = BookFileLoader.LoadAllBooksFromDir(".\\library");
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
                    BookFileSaver.SaveBook(".\\library", 0, book);

                    ListViewItem item = new ListViewItem(book.Info.Title, 0);
                    item.Tag = book.Info.ID;
                    libraryListView.Items.Insert(view.Items.Count - 1, item);
                }
            }
        }

        private void libraryItemContext_Opening(object sender, CancelEventArgs e)
        {
            if (libraryListView.SelectedItems.Count == 0 ||
                libraryListView.Items[libraryListView.Items.Count - 1].Selected)
                e.Cancel = true;
        }
    }
}