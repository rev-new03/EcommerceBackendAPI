using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EcommerceBackendAPI.Data
{
    public class EcommerceDbContextFactory
        : IDesignTimeDbContextFactory<EcommerceDbContext>
    {
        public EcommerceDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<EcommerceDbContext>();
            optionsBuilder.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"));

            return new EcommerceDbContext(optionsBuilder.Options);
        }
    }
}
