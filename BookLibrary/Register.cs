using System;
using System.Windows.Forms;



using BookLibrary.Database;
using BookLibrary.Database.Models;
using BookLibrary.Utils;

namespace BookLibrary
{
    public partial class Register : Form
    {
        private readonly BookLibraryDbContext dbContext;
        public Register(BookLibraryDbContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.PasswordInput.PasswordChar = '*';
            this.RepeatPasswordInput.PasswordChar = '*';


        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = this.UsernameInput.Text;
            string password = this.PasswordInput.Text;
            string repeatPassword = this.RepeatPasswordInput.Text;


            if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(repeatPassword))
            {
                MessageBox.Show("All inputs must be filled!");
                return;
            }

            if(password != repeatPassword)
            {
                MessageBox.Show("Passwords must match!");
                return;
            }

            bool doesUserExist = dbContext.Users.Any(u => u.Username == username);
            if(doesUserExist)
            {
                MessageBox.Show("User with that name already exists!");
                return;
            }

            string salt = PasswordManager.GenerateSalt();
            string hashedPassword = PasswordManager.HashPassword(password, salt);

            User user = new User()
            {
                Username = username,
                PasswordHash = hashedPassword,
                PasswordSalt = salt
            };

            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();

            LibraryUser libraryUser = new LibraryUser(this.dbContext, user.Id);
            libraryUser.Show();
            Hide();
        }



        private void LoginLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login(dbContext);
            loginForm.Show();
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