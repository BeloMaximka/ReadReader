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
            this.libraryListView = new System.Windows.Forms.ListView();
            this.libraryItemContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.libraryItemContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // libraryListView
            // 
            this.libraryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.libraryListView.ContextMenuStrip = this.libraryItemContext;
            this.libraryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryListView.HideSelection = false;
            this.libraryListView.Location = new System.Drawing.Point(0, 25);
            this.libraryListView.MultiSelect = false;
            this.libraryListView.Name = "libraryListView";
            this.libraryListView.Size = new System.Drawing.Size(800, 425);
            this.libraryListView.TabIndex = 1;
            this.libraryListView.UseCompatibleStateImageBehavior = false;
            this.libraryListView.View = System.Windows.Forms.View.Details;
            this.libraryListView.DoubleClick += new System.EventHandler(this.libraryListView_DoubleClick);
            // 
            // libraryItemContext
            // 
            this.libraryItemContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.libraryItemContext.Name = "libraryItemContext";
            this.libraryItemContext.Size = new System.Drawing.Size(119, 26);
            this.libraryItemContext.Opening += new System.ComponentModel.CancelEventHandler(this.libraryItemContext_Opening);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Название";
            this.nameColumn.Width = 90;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.libraryListView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LibraryForm";
            this.Text = "Библиотека";
            this.libraryItemContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView libraryListView;
        private System.Windows.Forms.ContextMenuStrip libraryItemContext;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader nameColumn;
    }
}