using Configuration.Infrastructure.EntityFramework.ReadModel.Requisitos;
using System.ComponentModel.DataAnnotations;

namespace Configuration.Infrastructure.EntityFramework.ReadModel.TipoProyectos
{
    internal class RequisitoTipoReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public RequisitoReadModel Requisito { get; private set; }
        public Guid RequisitoId { get; set; }
        public TipoProyectoReadModel TipoProyecto { get; private set; }
        public Guid TipoProyectoId { get; set; }
        public bool Obligatorio { get; private set; }
        public int Orden { get; private set; }
    }
}
