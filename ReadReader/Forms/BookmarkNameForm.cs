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
    public partial class BookmarkNameForm : Form
    {
        public BookmarkNameForm(string name = "")
        {
            InitializeComponent();
            textBox1.Text = name;
            DialogResult = DialogResult.Cancel;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            Tag = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
