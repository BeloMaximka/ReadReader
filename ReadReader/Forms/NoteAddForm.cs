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
    public partial class NoteAddForm : Form
    {
        public NoteAddForm(string text)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            referenceTextBox.Text = text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(noteNameTextBox.Text == "" || noteTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            DialogResult = DialogResult.OK;
            Tag = new Note(0, 0, noteNameTextBox.Text, noteNameTextBox.Text);
            Close();
        }
    }
}
