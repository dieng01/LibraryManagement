namespace LibraryManagement.GUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBorrowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookManagementToolStripMenuItem,
            this.borrowerManagementToolStripMenuItem,
            this.transactionManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookManagementToolStripMenuItem
            // 
            this.bookManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.searchBookToolStripMenuItem});
            this.bookManagementToolStripMenuItem.Name = "bookManagementToolStripMenuItem";
            this.bookManagementToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.bookManagementToolStripMenuItem.Text = "Book Management";
            // 
            // borrowerManagementToolStripMenuItem
            // 
            this.borrowerManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBorrowerToolStripMenuItem,
            this.searchBorrowerToolStripMenuItem});
            this.borrowerManagementToolStripMenuItem.Name = "borrowerManagementToolStripMenuItem";
            this.borrowerManagementToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.borrowerManagementToolStripMenuItem.Text = "Borrower Management";
            // 
            // transactionManagementToolStripMenuItem
            // 
            this.transactionManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem});
            this.transactionManagementToolStripMenuItem.Name = "transactionManagementToolStripMenuItem";
            this.transactionManagementToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.transactionManagementToolStripMenuItem.Text = "Transaction Management";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addBookToolStripMenuItem.Text = "Add Book";
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            // 
            // addBorrowerToolStripMenuItem
            // 
            this.addBorrowerToolStripMenuItem.Name = "addBorrowerToolStripMenuItem";
            this.addBorrowerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addBorrowerToolStripMenuItem.Text = "Add Borrower";
            // 
            // searchBorrowerToolStripMenuItem
            // 
            this.searchBorrowerToolStripMenuItem.Name = "searchBorrowerToolStripMenuItem";
            this.searchBorrowerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.searchBorrowerToolStripMenuItem.Text = "Search Borrower";
            // 
            // borrowBooksToolStripMenuItem
            // 
            this.borrowBooksToolStripMenuItem.Name = "borrowBooksToolStripMenuItem";
            this.borrowBooksToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.borrowBooksToolStripMenuItem.Text = "Borrow Books";
            // 
            // returnBooksToolStripMenuItem
            // 
            this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.returnBooksToolStripMenuItem.Text = "Return Books";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 674);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBorrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBorrowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
    }
}