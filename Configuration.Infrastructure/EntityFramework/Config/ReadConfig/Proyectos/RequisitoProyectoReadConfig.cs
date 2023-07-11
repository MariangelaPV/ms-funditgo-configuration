using Configuration.Infrastructure.EntityFramework.ReadModel.Proyectos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Configuration.Infrastructure.EntityFramework.Config.ReadConfig.Proyectos
{
    internal class RequisitoProyectoReadConfig : IEntityTypeConfiguration<RequisitoProyectoReadModel>
    {
        public void Configure(EntityTypeBuilder<RequisitoProyectoReadModel> builder)
        {
            builder.ToTable("RequisitoProyecto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");

            builder.Property(x => x.ProyectoId)
                .HasColumnName("proyectoId");

            builder.HasOne(x => x.Proyecto)
                .WithMany()
                .HasForeignKey(x => x.ProyectoId);

            builder.Property(x => x.RequisitoId)
                .HasColumnName("requisitoId");

            builder.HasOne(x => x.Requisito)
                .WithMany()
                .HasForeignKey(x => x.RequisitoId);

            builder.Property(x => x.Valor)
                .HasColumnName("valor");
        }
    }
}
