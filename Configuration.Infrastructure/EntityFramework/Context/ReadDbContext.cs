using Configuration.Infrastructure.EntityFramework.Config.ReadConfig;
using Configuration.Infrastructure.EntityFramework.ReadModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Infrastructure.EntityFramework.Context
{
    internal class ReadDbContext : DbContext
    {
        public virtual DbSet<ProyectoReadModel> Proyecto { get; set; }
        public virtual DbSet<RequisitoReadModel> Requisito { get; set; }
        public virtual DbSet<TipoProyectoReadModel> TipoProyecto { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProyectoReadConfig());
            modelBuilder.ApplyConfiguration(new RequisitoReadConfig());
            modelBuilder.ApplyConfiguration(new TipoProyectoReadConfig());
        }
    }
}
