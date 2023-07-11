using Configuration.Infrastructure.EntityFramework.ReadModel.Requisitos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Infrastructure.EntityFramework.Config.ReadConfig.Requisitos
{
    internal class RequisitoReadConfig : IEntityTypeConfiguration<RequisitoReadModel>
    {
        public void Configure(EntityTypeBuilder<RequisitoReadModel> builder)
        {
            builder.ToTable("Requisito");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");

            builder.Property(x => x.Nombre)
                .HasColumnName("nombre");

            builder.Property(x => x.Descripcion)
                .HasColumnName("descripcion");
        }
    }
}
