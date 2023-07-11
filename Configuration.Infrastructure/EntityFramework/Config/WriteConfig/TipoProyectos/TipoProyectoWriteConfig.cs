using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Configuration.Domain.Model.TipoProyectos;

namespace Configuration.Infrastructure.EntityFramework.Config.WriteConfig.TipoProyectos
{
    internal class TipoProyectoWriteConfig : IEntityTypeConfiguration<TipoProyecto>
    {
        public void Configure(EntityTypeBuilder<TipoProyecto> builder)
        {
            builder.ToTable("TipoProyecto");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nombre)
                .HasColumnName("nombre");

            builder.Property(x => x.Descripcion)
                .HasColumnName("descripcion");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
