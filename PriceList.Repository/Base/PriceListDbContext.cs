using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PriceListApp.Common.Contracts;

namespace PriceListApp.Repository.Base
{
    public class PriceListDbContext : DbContext
    {
        private string? ConnectionString { get; }
        public DbSet<PriceList> PriceLists { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductParameter> ProductParameters { get; set; }
        public PriceListDbContext()
        {
            ConnectionString = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build()
                    .GetSection("ConnectionStrings")["DefaultConnection"];

            if (ConnectionString == null)
                throw new ArgumentNullException("DefaultConnection is not found");

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
