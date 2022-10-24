using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context {
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camisa no Internet",
                Price = new Decimal(69.9),
                Description = "It is a long establaisbdjas dsa hdasdasj dbsad ",
                ImageURL = "http://nagdhsvdhasvbds.com.br",
                CategoryName = "One jusadusavds ad"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camisa no Internet",
                Price = new Decimal(69.9),
                Description = "It is a long establaisbdjas dsa hdasdasj dbsad ",
                ImageURL = "http://nagdhsvdhasvbds.com.br",
                CategoryName = "One jusadusavds ad"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camisa no Internet",
                Price = new Decimal(69.9),
                Description = "It is a long establaisbdjas dsa hdasdasj dbsad ",
                ImageURL = "http://nagdhsvdhasvbds.com.br",
                CategoryName = "One jusadusavds ad"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Camisa no Internet",
                Price = new Decimal(69.9),
                Description = "It is a long establaisbdjas dsa hdasdasj dbsad ",
                ImageURL = "http://nagdhsvdhasvbds.com.br",
                CategoryName = "One jusadusavds ad"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Camisa no Internet",
                Price = new Decimal(69.9),
                Description = "It is a long establaisbdjas dsa hdasdasj dbsad ",
                ImageURL = "http://nagdhsvdhasvbds.com.br",
                CategoryName = "One jusadusavds ad"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Camisa no Internet",
                Price = new Decimal(69.9),
                Description = "It is a long establaisbdjas dsa hdasdasj dbsad ",
                ImageURL = "http://nagdhsvdhasvbds.com.br",
                CategoryName = "One jusadusavds ad"
            });
        }
    }
}
