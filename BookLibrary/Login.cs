namespace BookLibrary
{
    using BookLibrary.Database;
    using BookLibrary.Database.Models;
    using BookLibrary.Utils;
    using Microsoft.EntityFrameworkCore;
    using System;
    public partial class Login : Form
    {
        private readonly BookLibraryDbContext dbContext;
        public Login(BookLibraryDbContext dbContext)
        {
            InitializeComponent();
            this.PasswordInput.PasswordChar = '*';
            this.dbContext = dbContext;
        }

        private  async void LoginButton_Click(object sender, EventArgs e)
        {
            string username = this.UsernameInput.Text;
            string password = this.PasswordInput.Text;

            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All inputs must be filled!");
                return;
            }

            User user = await dbContext.Users.SingleOrDefaultAsync(u => u.Username == username);

            if(user == null)
            {
                MessageBox.Show("This user doesn't exist!");
                return;
            }

            string hashedPassword = PasswordManager.HashPassword(password, user.PasswordSalt);
            
            if(hashedPassword !=user.PasswordHash)
            {
                MessageBox.Show("Invalid Password!");
                return;
            }

            LibraryUser libraryUserForm = new LibraryUser(dbContext, user.Id);
            libraryUserForm.Show();
            Hide();
        }

        private void RegisterLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register(dbContext);
            registerForm.Show();
            Hide();
        }

        private void LibraryNonUserButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LibraryNonUser libraryNonUser = new LibraryNonUser(dbContext);
            libraryNonUser.Show();
            Hide();
        }
    }
}
