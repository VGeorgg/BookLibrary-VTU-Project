using BookLibrary.Database;
using BookLibrary.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BookLibrary
{
    public partial class LibraryNonUser : Form
    {
        private readonly BookLibraryDbContext dbContext;
        private int bookId;
        public LibraryNonUser(BookLibraryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
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
            var books = dbContext.Books.Include(b => b.User).Select(b => new Book
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
                string[] currentRow = { book.Id.ToString(), book.Title, book.Authors, book.User.Username, book.CreatedAt.Date.ToString() };
                BookGridView.Rows.Add(currentRow);
            }
        }

        private void Clear()
        {
            TitleTextBox.Text = "";
            AuthorsTextBox.Text = "";
            DescriptionTextBox.Text = "";
            DownloadTextBox.Text = "";
            bookId = 0;

        }

        private void BookGridView_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
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

        private void RegisterLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register(dbContext);
            registerForm.Show();
            Hide();
        }

        private void LoginLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login(dbContext);
            loginForm.Show();
            Hide();
        }
    }
}
