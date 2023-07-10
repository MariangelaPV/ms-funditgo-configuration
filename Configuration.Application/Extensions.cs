using Configuration.Domain.Factories;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Configuration.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddScoped<IProyectoFactory, ProyectoFactory>();
            services.AddScoped<IRequisitoFactory, RequisitoFactory>();
            services.AddScoped<ITipoProyectoFactory, TipoProyectoFactory>();
            return services;
        }
    }
}