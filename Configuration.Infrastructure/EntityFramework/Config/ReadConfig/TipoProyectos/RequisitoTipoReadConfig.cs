using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Configuration.Infrastructure.EntityFramework.ReadModel.TipoProyectos;

namespace Configuration.Infrastructure.EntityFramework.Config.ReadConfig.TipoProyectos
{
    internal class RequisitoTipoReadConfig : IEntityTypeConfiguration<RequisitoTipoReadModel>
    {
        public void Configure(EntityTypeBuilder<RequisitoTipoReadModel> builder)
        {
            builder.ToTable("RequisitoTipo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");

            builder.Property(x => x.RequisitoId)
                .HasColumnName("requisitoId");

            builder.HasOne(x => x.Requisito)
                .WithMany()
                .HasForeignKey(x => x.RequisitoId);

            builder.Property(x => x.TipoProyectoId)
                .HasColumnName("tipoProyectoId");

            builder.HasOne(x => x.TipoProyecto)
                .WithMany()
                .HasForeignKey(x => x.TipoProyectoId);

            builder.Property(x => x.Obligatorio)
                .HasColumnName("obligatorio");

            builder.Property(x => x.Orden)
                .HasColumnName("orden");
        }
    }
}
