using System.ComponentModel.DataAnnotations;

namespace Configuration.Infrastructure.EntityFramework.ReadModel.TipoProyectos
{
    internal class TipoProyectoReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
