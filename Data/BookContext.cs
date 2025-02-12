using moment3.Models;
using Microsoft.EntityFrameworkCore;

namespace moment3.Data {
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) {

        }

        public DbSet<BookModel> Books { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
    }
}