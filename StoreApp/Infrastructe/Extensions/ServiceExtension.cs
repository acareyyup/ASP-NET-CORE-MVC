using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;
using StoreApp.Models;
using System.Reflection;

namespace StoreApp.Infrastructe.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(x =>
            {
                x.UseSqlServer(configuration.GetConnectionString("SqlConnection"), option =>
                {
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(RepositoryContext)).GetName().Name);
                });
            });
        }
    }
}