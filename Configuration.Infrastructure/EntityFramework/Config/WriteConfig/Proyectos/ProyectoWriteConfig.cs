using Configuration.Domain.Model.Proyectos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Configuration.Infrastructure.EntityFramework.Config.WriteConfig.Proyectos
{
    internal class ProyectoWriteConfig : IEntityTypeConfiguration<Proyecto>
    {
        public void Configure(EntityTypeBuilder<Proyecto> builder)
        {
            builder.ToTable("Proyecto");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Estado).HasColumnName("estado");

            builder.Property(x => x.FechaCreado).HasColumnName("fechaCreacion");

            builder.Property(x => x.FechaBorrador).HasColumnName("fechaBorrador");

            builder.Property(x => x.FechaRevision).HasColumnName("fechaRevision");

            builder.Property(x => x.FechaObservado).HasColumnName("fechaObservado");

            builder.Property(x => x.FechaModificado).HasColumnName("fechaModificado");

            builder.Property(x => x.FechaAprobado).HasColumnName("fechaAprobado");

            builder.Property(x => x.FechaRechazado).HasColumnName("fechaRechazado");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
