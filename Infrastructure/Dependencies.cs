using ElectroShopInfrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ElectroShopInfrastructure
{
    public static class Dependencies
    {
        public static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDbContext<ElectroShopContext>(c =>c.UseNpgsql(configuration.GetConnectionString("CatalogConnection")));

        }
    }
}
