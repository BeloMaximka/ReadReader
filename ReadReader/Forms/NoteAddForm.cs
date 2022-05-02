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
        public NoteAddForm(string text, Theme theme)
        {
            InitializeComponent();
            this.Icon = Icon.FromHandle(Resource.icon.GetHicon());
            DialogResult = DialogResult.Cancel;
            referenceTextBox.Text = text;

            BackColor = theme.BackgroundColor;
            ForeColor = theme.ForeColor;
            label1.BackColor = theme.BackColor;
            label1.ForeColor = theme.ForeColor;
            label2.BackColor = theme.BackColor;
            label2.ForeColor = theme.ForeColor;
            label3.BackColor = theme.BackColor;
            label3.ForeColor = theme.ForeColor;
            noteNameTextBox.BackColor = theme.BackColor;
            noteNameTextBox.ForeColor = theme.ForeColor;
            noteTextBox.BackColor = theme.BackColor;
            noteTextBox.ForeColor = theme.ForeColor;
            referenceTextBox.BackColor = theme.BackColor;
            referenceTextBox.ForeColor = theme.ForeColor;
            referenceTextBox.BackColor = theme.BackColor;
            referenceTextBox.ForeColor = theme.ForeColor;
            addButton.BackColor = theme.BackColor;
            addButton.ForeColor = theme.ForeColor;
            cancelButton.BackColor = theme.BackColor;
            cancelButton.ForeColor = theme.ForeColor;

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
            Tag = new Note(0, 0, noteNameTextBox.Text, noteTextBox.Text);
            Close();
        }
    }
}
