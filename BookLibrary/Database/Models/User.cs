namespace BookLibrary.Database.Models
{
    using BookLibrary.Database.Models.Abstractions;
    using System;
    using System.ComponentModel.DataAnnotations;

    public  class User : BaseModel
    {
        public User()
        {
            CreatedAt = DateTime.Now;
            Books = new HashSet<Book>();
        }

        [Required]
        public string Username { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string PasswordSalt { get; set; }

        public DateTime CreatedAt { get; set; }  
           
        public ICollection<Book> Books { get; set; }
    }
}
