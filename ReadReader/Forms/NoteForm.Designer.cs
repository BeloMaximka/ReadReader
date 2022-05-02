namespace ReadReader
{
    partial class NoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.сloseButton = new System.Windows.Forms.Button();
            this.editSaveButton = new System.Windows.Forms.Button();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.noteNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // сloseButton
            // 
            this.сloseButton.Location = new System.Drawing.Point(408, 200);
            this.сloseButton.Name = "сloseButton";
            this.сloseButton.Size = new System.Drawing.Size(120, 23);
            this.сloseButton.TabIndex = 15;
            this.сloseButton.Text = "Закрыть";
            this.сloseButton.UseVisualStyleBackColor = true;
            this.сloseButton.Click += new System.EventHandler(this.сloseButton_Click);
            // 
            // editSaveButton
            // 
            this.editSaveButton.Location = new System.Drawing.Point(8, 200);
            this.editSaveButton.Name = "editSaveButton";
            this.editSaveButton.Size = new System.Drawing.Size(120, 23);
            this.editSaveButton.TabIndex = 14;
            this.editSaveButton.Text = "Изменить";
            this.editSaveButton.UseVisualStyleBackColor = true;
            this.editSaveButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(272, 72);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ReadOnly = true;
            this.noteTextBox.Size = new System.Drawing.Size(256, 120);
            this.noteTextBox.TabIndex = 13;
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Location = new System.Drawing.Point(8, 72);
            this.referenceTextBox.Multiline = true;
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.ReadOnly = true;
            this.referenceTextBox.Size = new System.Drawing.Size(256, 120);
            this.referenceTextBox.TabIndex = 12;
            // 
            // noteNameTextBox
            // 
            this.noteNameTextBox.Location = new System.Drawing.Point(8, 32);
            this.noteNameTextBox.Name = "noteNameTextBox";
            this.noteNameTextBox.ReadOnly = true;
            this.noteNameTextBox.Size = new System.Drawing.Size(256, 20);
            this.noteNameTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Заметка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название заметки";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 235);
            this.Controls.Add(this.сloseButton);
            this.Controls.Add(this.editSaveButton);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.referenceTextBox);
            this.Controls.Add(this.noteNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NoteForm";
            this.Text = "NoteForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button сloseButton;
        private System.Windows.Forms.Button editSaveButton;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.Windows.Forms.TextBox noteNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}