
using Microsoft.EntityFrameworkCore;
using ElectroShopCore.Entities;

namespace ElectroShopInfrastructure.Data
{
    internal class ElectroShopContext : DbContext
    {
        public ElectroShopContext(DbContextOptions<ElectroShopContext> options) : base(options) { }
        public DbSet<Manufacter> Baskets { get; set; }
    }
}
