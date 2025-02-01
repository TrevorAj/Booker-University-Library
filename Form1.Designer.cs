namespace BookerUniversityLibrary
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtBookNumber;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookNumber;
        private System.Windows.Forms.Label lblCopies;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookNumber = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();

            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(150, 20);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 22);
            this.txtAuthor.TabIndex = 0;

            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(150, 60);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 1;

            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(150, 100);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 22);
            this.txtTitle.TabIndex = 2;

            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Location = new System.Drawing.Point(150, 140);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(200, 22);
            this.txtBookNumber.TabIndex = 3;

            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(150, 180);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(200, 22);
            this.txtCopies.TabIndex = 4;

            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(150, 220);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 30);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);

            // 
            // btnShowBooks
            // 
            this.btnShowBooks.Location = new System.Drawing.Point(250, 220);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(100, 30);
            this.btnShowBooks.TabIndex = 6;
            this.btnShowBooks.Text = "Show Books";
            this.btnShowBooks.UseVisualStyleBackColor = true;
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);

            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(150, 270);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(300, 180);
            this.lstBooks.TabIndex = 7;

            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(50, 20);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(50, 17);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Author:";

            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(50, 60);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(50, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 17);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title:";

            // 
            // lblBookNumber
            // 
            this.lblBookNumber.AutoSize = true;
            this.lblBookNumber.Location = new System.Drawing.Point(50, 140);
            this.lblBookNumber.Name = "lblBookNumber";
            this.lblBookNumber.Size = new System.Drawing.Size(94, 17);
            this.lblBookNumber.TabIndex = 11;
            this.lblBookNumber.Text = "Book Number:";

            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(50, 180);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(56, 17);
            this.lblCopies.TabIndex = 12;
            this.lblCopies.Text = "Copies:";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.lblBookNumber);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.btnShowBooks);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtBookNumber);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAuthor);
            this.Name = "Form1";
            this.Text = "Booker University Library";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
