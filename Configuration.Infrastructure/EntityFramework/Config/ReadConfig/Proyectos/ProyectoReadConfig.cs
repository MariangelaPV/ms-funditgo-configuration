using Configuration.Infrastructure.EntityFramework.ReadModel.Proyectos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Configuration.Infrastructure.EntityFramework.Config.ReadConfig.Proyectos
{
    internal class ProyectoReadConfig : IEntityTypeConfiguration<ProyectoReadModel>
    {
        public void Configure(EntityTypeBuilder<ProyectoReadModel> builder)
        {
            builder.ToTable("Proyecto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");

            builder.Property(x => x.Estado)
                .HasColumnName("estado");

            builder.Property(x => x.FechaCreado)
                .HasColumnName("fechaCreacion");

            builder.Property(x => x.FechaBorrador)
                .HasColumnName("fechaBorrador");

            builder.Property(x => x.FechaRevision)
                .HasColumnName("fechaRevision");

            builder.Property(x => x.FechaObservado)
                .HasColumnName("fechaObservado");

            builder.Property(x => x.FechaModificado)
                .HasColumnName("fechaModificado");

            builder.Property(x => x.FechaAprobado)
                .HasColumnName("fechaAprobado");

            builder.Property(x => x.FechaRechazado)
                .HasColumnName("fechaRechazado");
        }
    }
}
