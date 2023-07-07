using Configuration.Infrastructure.EntityFramework.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Configuration.Infrastructure.EntityFramework.Config.ReadConfig
{
    internal class ProyectoReadConfig : IEntityTypeConfiguration<ProyectoReadModel>
    {
        public void Configure(EntityTypeBuilder<ProyectoReadModel> builder)
        {
            builder.ToTable("Proyecto");
        }
    }
}
