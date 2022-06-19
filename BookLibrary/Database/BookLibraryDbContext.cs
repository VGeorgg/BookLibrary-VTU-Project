namespace BookLibrary.Database
{
    using BookLibrary.Database.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    public  class BookLibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if(optionsBuilder.IsConfigured == false)
            {
                string conn = "Server=DESKTOP-K5UB4A0;Database=BookLibraryDb;Integrated security=true;";
                optionsBuilder.UseSqlServer(conn);
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Book>()
                .HasOne(b => b.User)
                .WithMany(u => u.Books)
                .HasForeignKey(b => b.UserId);


            modelBuilder
                .Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique(true);
        }
    }
}
