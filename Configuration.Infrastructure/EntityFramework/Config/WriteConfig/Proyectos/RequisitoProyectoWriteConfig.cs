using Configuration.Domain.Model.Proyectos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Configuration.Infrastructure.EntityFramework.Config.WriteConfig.Proyectos
{
    internal class RequisitoProyectoWriteConfig : IEntityTypeConfiguration<RequisitoProyecto>
    {
        public void Configure(EntityTypeBuilder<RequisitoProyecto> builder)
        {
            builder.ToTable("RequisitoProyecto");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ProyectoId)
                .HasColumnName("proyectoId");

            builder.Property(x => x.RequisitoId)
                .HasColumnName("requisitoId");

            builder.Property(x => x.Valor)
                .HasColumnName("valor");

            builder.Ignore(x => x.DomainEvents);
            builder.Ignore("_domainEvents");
        }
    }
}
