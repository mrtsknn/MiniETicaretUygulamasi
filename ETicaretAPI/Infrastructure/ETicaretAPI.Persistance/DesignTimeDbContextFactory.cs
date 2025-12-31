using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ETicaretAPI.Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
    {
        public ETicaretAPIDbContext CreateDbContext(string[] args)
        {
            var basePath = Path.Combine(
    Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.FullName,
    "Presentation",
    "ETicaretAPI.API"
);



            IConfigurationRoot configuration = new ConfigurationBuilder()
    .SetBasePath(basePath)
    .AddJsonFile("appsettings.json")
    .Build();


            var builder = new DbContextOptionsBuilder<ETicaretAPIDbContext>();

            builder.UseNpgsql(configuration.GetConnectionString("PostgreSQL"));

            return new ETicaretAPIDbContext(builder.Options);
        }
    }
}
