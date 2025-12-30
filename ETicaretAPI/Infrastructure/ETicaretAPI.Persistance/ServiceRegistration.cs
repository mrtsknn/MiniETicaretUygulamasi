using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=ETicaretAPIDb;"));
        }
    }
}
