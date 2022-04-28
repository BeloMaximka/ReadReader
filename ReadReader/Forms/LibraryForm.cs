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
            ListViewItem item = new ListViewItem("Добавить...");
            libraryListView.LargeImageList = new ImageList();
            libraryListView.LargeImageList.ImageSize = new Size(128, 128);
            libraryListView.LargeImageList.Images.Add(Resource.folder);
            item.ImageIndex = 0;
            libraryListView.Items.Add(item);
            libraryListView.Items.Add(item.Clone() as ListViewItem);
        }

        private void libraryListView_DoubleClick(object sender, EventArgs e)
        {
            ListView view = sender as ListView;
            if (view.Items[view.Items.Count-1].Selected)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog();
                Book book = BookFileLoader.LoadFromFile(openFileDialog.FileName);
                BookFileSaver.SaveBook(".\\library", 1, book);
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
