namespace ReadReader
{
    partial class LibraryForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.themeButton = new System.Windows.Forms.ToolStripButton();
            this.themeSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.libraryListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libraryItemContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.libraryItemContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeButton,
            this.themeSeparator});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // libraryListView
            // 
            this.libraryListView.AllowDrop = true;
            this.libraryListView.BackColor = System.Drawing.SystemColors.Window;
            this.libraryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.libraryListView.ContextMenuStrip = this.libraryItemContext;
            this.libraryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryListView.ForeColor = System.Drawing.SystemColors.WindowText;
            this.libraryListView.HideSelection = false;
            this.libraryListView.Location = new System.Drawing.Point(0, 39);
            this.libraryListView.MultiSelect = false;
            this.libraryListView.Name = "libraryListView";
            this.libraryListView.Size = new System.Drawing.Size(800, 411);
            this.libraryListView.TabIndex = 1;
            this.libraryListView.UseCompatibleStateImageBehavior = false;
            this.libraryListView.View = System.Windows.Forms.View.List;
            this.libraryListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.libraryListView_DragDrop);
            this.libraryListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.libraryListView_DragEnter);
            this.libraryListView.DoubleClick += new System.EventHandler(this.libraryListView_DoubleClick);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Название";
            this.nameColumn.Width = 90;
            // 
            // libraryItemContext
            // 
            this.libraryItemContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem});
            this.libraryItemContext.Name = "libraryItemContext";
            this.libraryItemContext.Size = new System.Drawing.Size(119, 26);
            this.libraryItemContext.Opening += new System.ComponentModel.CancelEventHandler(this.libraryItemContext_Opening);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.libraryListView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LibraryForm";
            this.Text = "Библиотека";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.libraryItemContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView libraryListView;
        private System.Windows.Forms.ContextMenuStrip libraryItemContext;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ToolStripButton themeButton;
        private System.Windows.Forms.ToolStripSeparator themeSeparator;
    }
}