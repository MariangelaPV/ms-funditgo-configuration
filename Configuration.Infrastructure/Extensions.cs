using Configuration.Infrastructure.EntityFramework.Context;
using Configuration.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Configuration.Application;
using Configuration.Domain.Repositories;

namespace Configuration.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastrucutre(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddApplication();
            services.AddDbContext<ReadDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ConnectionConfigurationDB"));
            });
            services.AddDbContext<WriteDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ConnectionConfigurationDB"));
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IPagoRepository, PagoRepository>();

            return services;
        }

    }
}