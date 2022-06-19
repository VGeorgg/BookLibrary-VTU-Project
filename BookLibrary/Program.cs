

namespace BookLibrary
{
    using BookLibrary.Database;
    using Microsoft.EntityFrameworkCore;

    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            BookLibraryDbContext dbContext = new BookLibraryDbContext();
            dbContext.Database.Migrate();

            ApplicationConfiguration.Initialize();
            Application.Run(new LibraryNonUser(dbContext));
        }
    }
}