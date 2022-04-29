namespace ReadReader
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bookmarkCloseButton = new System.Windows.Forms.ToolStripButton();
            this.bookmarkSplitter = new System.Windows.Forms.Splitter();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bookmarkPanel = new System.Windows.Forms.Panel();
            this.bookmarkListBox = new System.Windows.Forms.ListBox();
            this.bookmarkToolStrip = new System.Windows.Forms.ToolStrip();
            this.bookmarkStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mainPanel.SuspendLayout();
            this.bookmarkPanel.SuspendLayout();
            this.bookmarkToolStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::ReadReader.Properties.Resources.forward;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = ">";
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkButton.Image = global::ReadReader.Resource.bookmark;
            this.bookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(23, 22);
            this.bookmarkButton.Text = "toolStripButton3";
            this.bookmarkButton.Click += new System.EventHandler(this.bookmarkButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // bookmarkCloseButton
            // 
            this.bookmarkCloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bookmarkCloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkCloseButton.Image = global::ReadReader.Resource.close;
            this.bookmarkCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkCloseButton.Name = "bookmarkCloseButton";
            this.bookmarkCloseButton.Size = new System.Drawing.Size(23, 22);
            this.bookmarkCloseButton.Text = "toolStripButton1";
            this.bookmarkCloseButton.Click += new System.EventHandler(this.bookmarkCloseButton_Click);
            // 
            // bookmarkSplitter
            // 
            this.bookmarkSplitter.Location = new System.Drawing.Point(200, 0);
            this.bookmarkSplitter.Name = "bookmarkSplitter";
            this.bookmarkSplitter.Size = new System.Drawing.Size(3, 510);
            this.bookmarkSplitter.TabIndex = 6;
            this.bookmarkSplitter.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.bookmarkSplitter);
            this.mainPanel.Controls.Add(this.bookmarkPanel);
            this.mainPanel.Controls.Add(this.richTextBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 25);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 510);
            this.mainPanel.TabIndex = 11;
            // 
            // bookmarkPanel
            // 
            this.bookmarkPanel.Controls.Add(this.bookmarkListBox);
            this.bookmarkPanel.Controls.Add(this.bookmarkToolStrip);
            this.bookmarkPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookmarkPanel.Location = new System.Drawing.Point(0, 0);
            this.bookmarkPanel.Name = "bookmarkPanel";
            this.bookmarkPanel.Size = new System.Drawing.Size(200, 510);
            this.bookmarkPanel.TabIndex = 5;
            this.bookmarkPanel.Visible = false;
            // 
            // bookmarkListBox
            // 
            this.bookmarkListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkListBox.FormattingEnabled = true;
            this.bookmarkListBox.Location = new System.Drawing.Point(0, 25);
            this.bookmarkListBox.Name = "bookmarkListBox";
            this.bookmarkListBox.Size = new System.Drawing.Size(200, 485);
            this.bookmarkListBox.TabIndex = 1;
            // 
            // bookmarkToolStrip
            // 
            this.bookmarkToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bookmarkToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkStripLabel,
            this.bookmarkCloseButton});
            this.bookmarkToolStrip.Location = new System.Drawing.Point(0, 0);
            this.bookmarkToolStrip.Name = "bookmarkToolStrip";
            this.bookmarkToolStrip.Size = new System.Drawing.Size(200, 25);
            this.bookmarkToolStrip.TabIndex = 0;
            this.bookmarkToolStrip.Text = "toolStrip2";
            // 
            // bookmarkStripLabel
            // 
            this.bookmarkStripLabel.Name = "bookmarkStripLabel";
            this.bookmarkStripLabel.Size = new System.Drawing.Size(58, 22);
            this.bookmarkStripLabel.Text = "Закладки";
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 510);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel3.Text = "0 из 100";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::ReadReader.Properties.Resources.back;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "<";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel2.Text = "Страница";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.bookmarkButton,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripButton4,
            this.toolStripLabel3,
            this.toolStripButton5});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(800, 25);
            this.mainToolStrip.TabIndex = 10;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.mainPanel.ResumeLayout(false);
            this.bookmarkPanel.ResumeLayout(false);
            this.bookmarkPanel.PerformLayout();
            this.bookmarkToolStrip.ResumeLayout(false);
            this.bookmarkToolStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton bookmarkButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton bookmarkCloseButton;
        private System.Windows.Forms.Splitter bookmarkSplitter;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bookmarkPanel;
        private System.Windows.Forms.ListBox bookmarkListBox;
        private System.Windows.Forms.ToolStrip bookmarkToolStrip;
        private System.Windows.Forms.ToolStripLabel bookmarkStripLabel;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}