using BookLibrary.Database;
using BookLibrary.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary
{
    public partial class LibraryUser : Form
    {
        private readonly BookLibraryDbContext dbContext;
        private readonly int userId;
        private int bookId;
        public LibraryUser(BookLibraryDbContext dbContext, int userId)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.userId = userId;
            DisplayView();
            PopulateView();
            bookId = 0;
        }

        private void DisplayView()
        {
            this.BookGridView.ColumnCount = 5;
            this.BookGridView.Columns[0].Name = "Id";
            this.BookGridView.Columns[1].Name = "Title";
            this.BookGridView.Columns[2].Name = "Authors";
            this.BookGridView.Columns[3].Name = "Uploader";
            this.BookGridView.Columns[4].Name = "Date";
        }
        private void PopulateView()
        {
            BookGridView.Rows.Clear();
            var books = this.dbContext.Books.Include(b => b.User).Select(b => new Book
            {
                Id = b.Id,
                Title = b.Title,
                Authors = b.Authors,
                CreatedAt = b.CreatedAt,
                User = new User
                {
                    Username = b.User.Username
                }
            }).ToList();

            foreach (var book in books)
            {
                string[] currentRow = { book.Id.ToString(), book.Title, book.Authors,book.User.Username, book.CreatedAt.Date.ToString() };
                BookGridView.Rows.Add(currentRow);
            }

        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            var book = new Book();
            book.Title = TitleTextBox.Text;
            book.Authors = AuthorsTextBox.Text;
            book.Description = DescriptionTextBox.Text;
            book.LinkDownload = DownloadTextBox.Text;
            book.UserId = userId;

            dbContext.Books.Add(book);
            dbContext.SaveChanges();

            Clear();
            PopulateView();


        }

        private void Clear()
        {
            TitleTextBox.Text = "";
            AuthorsTextBox.Text = "";
            DescriptionTextBox.Text = "";
            DownloadTextBox.Text = "";
            bookId = 0;

        }
        private void BookGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clear();
            int rowIndex = e.RowIndex;
            int id = int.Parse(BookGridView.Rows[rowIndex].Cells[0].Value.ToString());
            var book = dbContext.Books.Find(id);

            bookId = book.Id;
            TitleTextBox.Text = book.Title;
            AuthorsTextBox.Text = book.Authors;
            DescriptionTextBox.Text = book.Description;
            DownloadTextBox.Text = book.LinkDownload;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (bookId != 0)
            {
                var book = dbContext.Books.Find(bookId);
                book.Title = TitleTextBox.Text;
                book.Authors = AuthorsTextBox.Text;
                book.Description = DescriptionTextBox.Text;
                book.LinkDownload = DownloadTextBox.Text;


                dbContext.Books.Update(book);
                dbContext.SaveChanges();
                Clear();
                PopulateView();
            }
            else
            {
                MessageBox.Show("Select a book to edit.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(bookId != 0)
            {
                var book = dbContext.Books.Find(bookId);
                dbContext.Remove(book);
                dbContext.SaveChanges();
                Clear();
                PopulateView();
            }
            else
            {
                MessageBox.Show("Select a book to delete.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login(dbContext);
            loginForm.Show();
            Hide();
        }
    }
}
