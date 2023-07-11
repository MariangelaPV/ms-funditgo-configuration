using Configuration.Domain.Model.Proyectos;
using Configuration.Domain.Model.Requisitos;
using Configuration.Domain.Model.TipoProyectos;
using Configuration.Infrastructure.EntityFramework.Config.WriteConfig.Proyectos;
using Configuration.Infrastructure.EntityFramework.Config.WriteConfig.Requisitos;
using Configuration.Infrastructure.EntityFramework.Config.WriteConfig.TipoProyectos;
using Microsoft.EntityFrameworkCore;

namespace Configuration.Infrastructure.EntityFramework.Context
{
    internal class WriteDbContext : DbContext
    {
        public virtual DbSet<Proyecto> Proyecto { get; set; }
        public virtual DbSet<RequisitoProyecto> RequisitoProyecto { get; set; }
        public virtual DbSet<Requisito> Requisito { get; set; }
        public virtual DbSet<RequisitoTipo> RequisitoTipo { get; set; }
        public virtual DbSet<TipoProyecto> TipoProyecto { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProyectoWriteConfig());
            modelBuilder.ApplyConfiguration(new RequisitoProyectoWriteConfig());
            modelBuilder.ApplyConfiguration(new RequisitoWriteConfig());
            modelBuilder.ApplyConfiguration(new RequisitoTipoWriteConfig());
            modelBuilder.ApplyConfiguration(new TipoProyectoWriteConfig());
        }
    }
}
