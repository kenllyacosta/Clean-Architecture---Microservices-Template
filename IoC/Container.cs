using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryEFCore;
using RepositoryEFCore.Repositories;

namespace IoC
{
    public static class Container
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                opt => opt.UseSqlServer(configuration.GetConnectionString("Northwind")));

            services.AddTransient<ProductRepository>();
            //Los demás repositorios

            return services;
        }
    }
}
