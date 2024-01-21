
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ElectroShopCore.Entities;

namespace ElectroShopInfrastructure.Data
{
    internal class ElectroShopContext : DbContext
    {
        public ElectroShopContext(DbContextOptions<ElectroShopContext> options) : base(options) { }
        public DbSet<Manufacter> Manufacters { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
