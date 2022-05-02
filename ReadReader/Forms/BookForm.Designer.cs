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
            this.components = new System.ComponentModel.Container();
            this.bookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.notesButton = new System.Windows.Forms.ToolStripButton();
            this.bookmarkCloseButton = new System.Windows.Forms.ToolStripButton();
            this.bookmarkSplitter = new System.Windows.Forms.Splitter();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddBookmarkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesSplitter = new System.Windows.Forms.Splitter();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.noteListBox = new System.Windows.Forms.ListBox();
            this.notesToolStrip = new System.Windows.Forms.ToolStrip();
            this.closeNotesButton = new System.Windows.Forms.ToolStripButton();
            this.noteLabel = new System.Windows.Forms.ToolStripLabel();
            this.bookmarkPanel = new System.Windows.Forms.Panel();
            this.bookmarkListBox = new System.Windows.Forms.ListBox();
            this.bookmarkContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameBookmarkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookmarkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarkToolStrip = new System.Windows.Forms.ToolStrip();
            this.bookmarkStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.themeButton = new System.Windows.Forms.ToolStripButton();
            this.themeSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.noteContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteNoteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.mainContextMenu.SuspendLayout();
            this.notesPanel.SuspendLayout();
            this.notesToolStrip.SuspendLayout();
            this.bookmarkPanel.SuspendLayout();
            this.bookmarkContextMenu.SuspendLayout();
            this.bookmarkToolStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.noteContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkButton.Image = global::ReadReader.Resource.bookmark_bl;
            this.bookmarkButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(36, 36);
            this.bookmarkButton.Text = "Закладки";
            this.bookmarkButton.Click += new System.EventHandler(this.bookmarkButton_Click);
            // 
            // notesButton
            // 
            this.notesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notesButton.Image = global::ReadReader.Resource.note_bl;
            this.notesButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.notesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(36, 36);
            this.notesButton.Text = "Заметки";
            this.notesButton.Click += new System.EventHandler(this.notesButton_Click);
            // 
            // bookmarkCloseButton
            // 
            this.bookmarkCloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bookmarkCloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkCloseButton.Image = global::ReadReader.Resource.close_bl;
            this.bookmarkCloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkCloseButton.Name = "bookmarkCloseButton";
            this.bookmarkCloseButton.Size = new System.Drawing.Size(23, 22);
            this.bookmarkCloseButton.Text = "toolStripButton1";
            this.bookmarkCloseButton.Click += new System.EventHandler(this.bookmarkCloseButton_Click);
            // 
            // bookmarkSplitter
            // 
            this.bookmarkSplitter.Location = new System.Drawing.Point(176, 39);
            this.bookmarkSplitter.Name = "bookmarkSplitter";
            this.bookmarkSplitter.Size = new System.Drawing.Size(3, 496);
            this.bookmarkSplitter.TabIndex = 6;
            this.bookmarkSplitter.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.richTextBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 39);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 496);
            this.mainPanel.TabIndex = 11;
            // 
            // richTextBox
            // 
            this.richTextBox.ContextMenuStrip = this.mainContextMenu;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 496);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            this.richTextBox.SelectionChanged += new System.EventHandler(this.richTextBox_SelectionChanged);
            this.richTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox_MouseUp);
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBookmarkMenuItem,
            this.AddNoteMenuItem});
            this.mainContextMenu.Name = "mainContextMenu";
            this.mainContextMenu.Size = new System.Drawing.Size(178, 48);
            // 
            // AddBookmarkMenuItem
            // 
            this.AddBookmarkMenuItem.Name = "AddBookmarkMenuItem";
            this.AddBookmarkMenuItem.Size = new System.Drawing.Size(177, 22);
            this.AddBookmarkMenuItem.Text = "Добавить закладку";
            this.AddBookmarkMenuItem.Click += new System.EventHandler(this.AddBookmarkToolStripMenuItem_Click);
            // 
            // AddNoteMenuItem
            // 
            this.AddNoteMenuItem.Name = "AddNoteMenuItem";
            this.AddNoteMenuItem.Size = new System.Drawing.Size(177, 22);
            this.AddNoteMenuItem.Text = "Добавить заметку";
            this.AddNoteMenuItem.Visible = false;
            this.AddNoteMenuItem.Click += new System.EventHandler(this.AddNoteMenuItem_Click);
            // 
            // notesSplitter
            // 
            this.notesSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.notesSplitter.Location = new System.Drawing.Point(621, 39);
            this.notesSplitter.Name = "notesSplitter";
            this.notesSplitter.Size = new System.Drawing.Size(3, 496);
            this.notesSplitter.TabIndex = 8;
            this.notesSplitter.TabStop = false;
            // 
            // notesPanel
            // 
            this.notesPanel.Controls.Add(this.noteListBox);
            this.notesPanel.Controls.Add(this.notesToolStrip);
            this.notesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.notesPanel.Location = new System.Drawing.Point(624, 39);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(176, 496);
            this.notesPanel.TabIndex = 7;
            this.notesPanel.Visible = false;
            // 
            // noteListBox
            // 
            this.noteListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteListBox.FormattingEnabled = true;
            this.noteListBox.Location = new System.Drawing.Point(0, 25);
            this.noteListBox.Name = "noteListBox";
            this.noteListBox.Size = new System.Drawing.Size(176, 471);
            this.noteListBox.TabIndex = 1;
            this.noteListBox.Click += new System.EventHandler(this.noteListBox_Click);
            // 
            // notesToolStrip
            // 
            this.notesToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.notesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeNotesButton,
            this.noteLabel});
            this.notesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.notesToolStrip.Name = "notesToolStrip";
            this.notesToolStrip.Size = new System.Drawing.Size(176, 25);
            this.notesToolStrip.TabIndex = 0;
            this.notesToolStrip.Text = "toolStrip1";
            // 
            // closeNotesButton
            // 
            this.closeNotesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeNotesButton.Image = global::ReadReader.Resource.close_bl;
            this.closeNotesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeNotesButton.Name = "closeNotesButton";
            this.closeNotesButton.Size = new System.Drawing.Size(23, 22);
            this.closeNotesButton.Text = "toolStripButton1";
            this.closeNotesButton.Click += new System.EventHandler(this.closeNotesButton_Click);
            // 
            // noteLabel
            // 
            this.noteLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(53, 22);
            this.noteLabel.Text = "Заметки";
            this.noteLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // bookmarkPanel
            // 
            this.bookmarkPanel.Controls.Add(this.bookmarkListBox);
            this.bookmarkPanel.Controls.Add(this.bookmarkToolStrip);
            this.bookmarkPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookmarkPanel.Location = new System.Drawing.Point(0, 39);
            this.bookmarkPanel.Name = "bookmarkPanel";
            this.bookmarkPanel.Size = new System.Drawing.Size(176, 496);
            this.bookmarkPanel.TabIndex = 5;
            this.bookmarkPanel.Visible = false;
            // 
            // bookmarkListBox
            // 
            this.bookmarkListBox.ContextMenuStrip = this.bookmarkContextMenu;
            this.bookmarkListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkListBox.FormattingEnabled = true;
            this.bookmarkListBox.Location = new System.Drawing.Point(0, 25);
            this.bookmarkListBox.Name = "bookmarkListBox";
            this.bookmarkListBox.Size = new System.Drawing.Size(176, 471);
            this.bookmarkListBox.TabIndex = 1;
            this.bookmarkListBox.SelectedIndexChanged += new System.EventHandler(this.bookmarkListBox_SelectedIndexChanged);
            // 
            // bookmarkContextMenu
            // 
            this.bookmarkContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameBookmarkMenuItem,
            this.deleteBookmarkMenuItem});
            this.bookmarkContextMenu.Name = "bookmarkContextMenu";
            this.bookmarkContextMenu.Size = new System.Drawing.Size(162, 48);
            this.bookmarkContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.bookmarkContextMenu_Opening);
            // 
            // renameBookmarkMenuItem
            // 
            this.renameBookmarkMenuItem.Name = "renameBookmarkMenuItem";
            this.renameBookmarkMenuItem.Size = new System.Drawing.Size(161, 22);
            this.renameBookmarkMenuItem.Text = "Переименовать";
            this.renameBookmarkMenuItem.Click += new System.EventHandler(this.renameBookmarkMenuItem_Click);
            // 
            // deleteBookmarkMenuItem
            // 
            this.deleteBookmarkMenuItem.Name = "deleteBookmarkMenuItem";
            this.deleteBookmarkMenuItem.Size = new System.Drawing.Size(161, 22);
            this.deleteBookmarkMenuItem.Text = "Удалить";
            this.deleteBookmarkMenuItem.Click += new System.EventHandler(this.deleteBookmarkMenuItem_Click);
            // 
            // bookmarkToolStrip
            // 
            this.bookmarkToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bookmarkToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkStripLabel,
            this.bookmarkCloseButton});
            this.bookmarkToolStrip.Location = new System.Drawing.Point(0, 0);
            this.bookmarkToolStrip.Name = "bookmarkToolStrip";
            this.bookmarkToolStrip.Size = new System.Drawing.Size(176, 25);
            this.bookmarkToolStrip.TabIndex = 0;
            this.bookmarkToolStrip.Text = "toolStrip2";
            // 
            // bookmarkStripLabel
            // 
            this.bookmarkStripLabel.Name = "bookmarkStripLabel";
            this.bookmarkStripLabel.Size = new System.Drawing.Size(58, 22);
            this.bookmarkStripLabel.Text = "Закладки";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookmarkButton,
            this.notesButton,
            this.toolStripSeparator1,
            this.themeButton,
            this.themeSeparator});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(800, 39);
            this.mainToolStrip.TabIndex = 10;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // themeButton
            // 
            this.themeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.themeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.themeButton.Image = global::ReadReader.Resource.moon_bl;
            this.themeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.themeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themeButton.Name = "themeButton";
            this.themeButton.Size = new System.Drawing.Size(36, 36);
            this.themeButton.Text = "Сменить тему";
            this.themeButton.Click += new System.EventHandler(this.themeButton_Click);
            // 
            // themeSeparator
            // 
            this.themeSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.themeSeparator.Name = "themeSeparator";
            this.themeSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // noteContextMenu
            // 
            this.noteContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteNoteMenuItem});
            this.noteContextMenu.Name = "contextMenuStrip1";
            this.noteContextMenu.Size = new System.Drawing.Size(119, 26);
            this.noteContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.noteContextMenu_Opening);
            // 
            // deleteNoteMenuItem
            // 
            this.deleteNoteMenuItem.Name = "deleteNoteMenuItem";
            this.deleteNoteMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteNoteMenuItem.Text = "Удалить";
            this.deleteNoteMenuItem.Click += new System.EventHandler(this.deleteNoteMenuItem_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.notesSplitter);
            this.Controls.Add(this.notesPanel);
            this.Controls.Add(this.bookmarkSplitter);
            this.Controls.Add(this.bookmarkPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BookForm";
            this.mainPanel.ResumeLayout(false);
            this.mainContextMenu.ResumeLayout(false);
            this.notesPanel.ResumeLayout(false);
            this.notesPanel.PerformLayout();
            this.notesToolStrip.ResumeLayout(false);
            this.notesToolStrip.PerformLayout();
            this.bookmarkPanel.ResumeLayout(false);
            this.bookmarkPanel.PerformLayout();
            this.bookmarkContextMenu.ResumeLayout(false);
            this.bookmarkToolStrip.ResumeLayout(false);
            this.bookmarkToolStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.noteContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton bookmarkButton;
        private System.Windows.Forms.ToolStripButton notesButton;
        private System.Windows.Forms.ToolStripButton bookmarkCloseButton;
        private System.Windows.Forms.Splitter bookmarkSplitter;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel bookmarkPanel;
        private System.Windows.Forms.ListBox bookmarkListBox;
        private System.Windows.Forms.ToolStrip bookmarkToolStrip;
        private System.Windows.Forms.ToolStripLabel bookmarkStripLabel;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddBookmarkMenuItem;
        private System.Windows.Forms.ContextMenuStrip bookmarkContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteBookmarkMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameBookmarkMenuItem;
        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.Splitter notesSplitter;
        private System.Windows.Forms.ToolStrip notesToolStrip;
        private System.Windows.Forms.ToolStripLabel noteLabel;
        private System.Windows.Forms.ToolStripButton closeNotesButton;
        private System.Windows.Forms.ListBox noteListBox;
        private System.Windows.Forms.ToolStripMenuItem AddNoteMenuItem;
        private System.Windows.Forms.ContextMenuStrip noteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteNoteMenuItem;
        private System.Windows.Forms.ToolStripButton themeButton;
        private System.Windows.Forms.ToolStripSeparator themeSeparator;
    }
}