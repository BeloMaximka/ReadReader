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
    public partial class NoteForm : Form
    {
        bool saved = false;
        Note note;
        public NoteForm(string text, Note note, Theme theme)
        {
            this.note = note;
            InitializeComponent();
            this.Icon = Icon.FromHandle(Resource.icon.GetHicon());
            referenceTextBox.Text = text;
            noteNameTextBox.Text = note.Name;
            noteTextBox.Text = note.Text;
            DialogResult = DialogResult.Cancel;

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
            editSaveButton.BackColor = theme.BackColor;
            editSaveButton.ForeColor = theme.ForeColor;
            сloseButton.BackColor = theme.BackColor;
            сloseButton.ForeColor = theme.ForeColor;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editSaveButton.Text = "Сохранить";
            noteNameTextBox.ReadOnly = false;
            noteTextBox.ReadOnly = false;
            editSaveButton.Click -= editButton_Click;
            editSaveButton.Click += saveButton_Click;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (noteNameTextBox.Text == "" || noteTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }
            saved = true;
            note.Text = noteTextBox.Text;
            note.Name = noteNameTextBox.Text;

            editSaveButton.Text = "Изменить";
            noteNameTextBox.ReadOnly = true;
            noteTextBox.ReadOnly = true;
            editSaveButton.Click -= saveButton_Click;
            editSaveButton.Click += editButton_Click;
        }

        private void сloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved)
                DialogResult = DialogResult.OK;
        }
    }
}
