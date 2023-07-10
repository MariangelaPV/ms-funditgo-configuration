using Microsoft.Extensions.DependencyInjection;

namespace Configuration.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAplication();
            var connectionString = configuration.GetConnectionString("FunditGoProyectoConnection");
            services.AddDbContext<ReadDbContext>(context => { context.UseSqlServer(connectionString); });
            services.AddDbContext<WriteDbContext>(context => { context.UseSqlServer(connectionString); });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProyectoRepository, ProyectoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}