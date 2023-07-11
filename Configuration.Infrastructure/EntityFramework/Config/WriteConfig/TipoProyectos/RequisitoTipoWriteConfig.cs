using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Configuration.Domain.Model.TipoProyectos;

namespace Configuration.Infrastructure.EntityFramework.Config.WriteConfig.TipoProyectos
{
    internal class RequisitoTipoWriteConfig : IEntityTypeConfiguration<RequisitoTipo>
    {
        public void Configure(EntityTypeBuilder<RequisitoTipo> builder)
        {
            builder.ToTable("RequisitoTipo");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.RequisitoId)
                .HasColumnName("requisitoId");

            builder.Property(x => x.TipoProyectoId)
                .HasColumnName("tipoProyectoId");

            builder.Property(x => x.Obligatorio)
                .HasColumnName("obligatorio");

            builder.Property(x => x.Orden)
                .HasColumnName("orden");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
