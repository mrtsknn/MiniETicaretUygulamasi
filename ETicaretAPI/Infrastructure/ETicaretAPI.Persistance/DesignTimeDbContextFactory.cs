using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaretAPI.Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
    {
        public ETicaretAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=ETicaretAPIDb;");
            return new ETicaretAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
