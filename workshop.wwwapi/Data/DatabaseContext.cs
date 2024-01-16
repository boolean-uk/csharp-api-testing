using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.models;

namespace workshop.wwwapi.Data
{
    public class DatabaseContext : DbContext
    {
        private string _connectionString;
        public DatabaseContext()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;

            //if (!this.Products.Any())
            //{
            //    this.Products.AddRange(Seeder.Products);
            //    this.SaveChanges();
            //}

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase(databaseName: "Database");
            optionsBuilder.UseNpgsql(_connectionString);
        }
        public DbSet<Product> Products { get; set; }
    }
}
