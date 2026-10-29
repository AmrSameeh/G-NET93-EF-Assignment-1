using Microsoft.EntityFrameworkCore;
using ReadMoreBooks.Entities;

namespace ReadMoreBooks.Context
{
    internal class BookstoreContext : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Category> Categories => Set<Category>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=ReadMoreBooksDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

    }
}
