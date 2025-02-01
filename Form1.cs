using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookerUniversityLibrary
{
    public partial class Form1 : Form
    {
        private List<Book> books = new List<Book>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Get data from textboxes
            string author = txtAuthor.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);
            string title = txtTitle.Text;
            string bookNumber = txtBookNumber.Text;
            int numberOfCopies = Convert.ToInt32(txtCopies.Text);

            // Create a new book and add it to the list
            Book newBook = new Book(author, price, title, bookNumber, numberOfCopies);
            books.Add(newBook);

            // Clear input fields
            txtAuthor.Clear();
            txtPrice.Clear();
            txtTitle.Clear();
            txtBookNumber.Clear();
            txtCopies.Clear();

            // Show success message
            MessageBox.Show("Book added successfully!");

            // Refresh the list
            RefreshBookList();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            // Refresh the list and show all books
            RefreshBookList();
        }

        private void RefreshBookList()
        {
            lstBooks.Items.Clear();
            foreach (var book in books)
            {
                lstBooks.Items.Add(book);
            }
        }
    }
}
