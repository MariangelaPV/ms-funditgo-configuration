using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Configuration.Domain.Model.Requisitos;

namespace Configuration.Infrastructure.EntityFramework.Config.WriteConfig.Requisitos
{
    internal class RequisitoWriteConfig : IEntityTypeConfiguration<Requisito>
    {
        public void Configure(EntityTypeBuilder<Requisito> builder)
        {
            builder.ToTable("Requisito");
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
