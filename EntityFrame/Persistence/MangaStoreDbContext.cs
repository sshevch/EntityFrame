using EntityFrame.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrame.Persistence
{
    public class MangaStoreDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Manga> Manga { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=MangaShop;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
