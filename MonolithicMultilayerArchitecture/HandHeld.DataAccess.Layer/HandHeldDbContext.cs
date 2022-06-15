using HandHeld.DataAccess.Layer.Configurations;
using HandHeld.DataAccess.Layer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HandHeld.DataAccess.Layer
{
    public class HandHeldDbContext : DbContext
    {
        DbSet<Product> Values => Set<Product>();
        private readonly string _connectionString;
        public HandHeldDbContext(DbContextOptions<HandHeldDbContext> options,
                                 IConfiguration configuration) : base(options) 
        {
            _connectionString = configuration.GetConnectionString("Default");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductConfiguration());
        }

    }
}
