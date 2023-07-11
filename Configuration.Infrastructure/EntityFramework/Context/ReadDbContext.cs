using Configuration.Infrastructure.EntityFramework.Config.ReadConfig.Proyectos;
using Configuration.Infrastructure.EntityFramework.Config.ReadConfig.Requisitos;
using Configuration.Infrastructure.EntityFramework.Config.ReadConfig.TipoProyectos;
using Configuration.Infrastructure.EntityFramework.ReadModel.Proyectos;
using Configuration.Infrastructure.EntityFramework.ReadModel.Requisitos;
using Configuration.Infrastructure.EntityFramework.ReadModel.TipoProyectos;
using Microsoft.EntityFrameworkCore;

namespace Configuration.Infrastructure.EntityFramework.Context
{
    internal class ReadDbContext : DbContext
    {
        public virtual DbSet<ProyectoReadModel> Proyecto { get; set; }
        public virtual DbSet<RequisitoProyectoReadModel> RequisitoProyecto { get; set; }
        public virtual DbSet<RequisitoReadModel> Requisito { get; set; }
        public virtual DbSet<RequisitoTipoReadModel> RequisitoTipo { get; set; }
        public virtual DbSet<TipoProyectoReadModel> TipoProyecto { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProyectoReadConfig());
            modelBuilder.ApplyConfiguration(new RequisitoProyectoReadConfig());
            modelBuilder.ApplyConfiguration(new RequisitoReadConfig());
            modelBuilder.ApplyConfiguration(new RequisitoTipoReadConfig());
            modelBuilder.ApplyConfiguration(new TipoProyectoReadConfig());
        }
    }
}
