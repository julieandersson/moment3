using moment3.Models;
using Microsoft.EntityFrameworkCore;

namespace moment3.Data {
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) {

        }

        public DbSet<BookModel> Book { get; set; }
    }
}