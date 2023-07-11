using Configuration.Infrastructure.EntityFramework.ReadModel.TipoProyectos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Infrastructure.EntityFramework.Config.ReadConfig.TipoProyectos
{
    internal class TipoProyectoReadConfig : IEntityTypeConfiguration<TipoProyectoReadModel>
    {
        public void Configure(EntityTypeBuilder<TipoProyectoReadModel> builder)
        {
            builder.ToTable("TipoProyecto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");

            builder.Property(x => x.Nombre)
                .HasColumnName("nombre");

            builder.Property(x => x.Descripcion)
                .HasColumnName("descripcion");
        }
    }
}
