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
        public BookmarkNameForm(Theme theme, string name = "")
        {
            InitializeComponent();
            this.Icon = Icon.FromHandle(Resource.icon.GetHicon());
            textBox1.Text = name;
            DialogResult = DialogResult.Cancel;

            BackColor = theme.BackgroundColor;
            ForeColor=theme.ForeColor;
            textBox1.BackColor = theme.BackColor;
            textBox1.ForeColor = theme.ForeColor;
            cancelButton.BackColor = theme.BackColor;
            cancelButton.ForeColor = theme.ForeColor;
            okButton.BackColor = theme.BackColor;
            okButton.ForeColor = theme.ForeColor;
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
