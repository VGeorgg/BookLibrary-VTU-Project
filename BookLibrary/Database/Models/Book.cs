namespace BookLibrary.Database.Models
{
    using BookLibrary.Database.Models.Abstractions;
    using System;
    public class Book : BaseModel
    {
        public Book()
        {
            CreatedAt = DateTime.Now;
        }
        public string Title { get; set; }

        public string Authors { get; set; }

        public string Description { get; set; }

        public string LinkDownload { get; set; }

        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
