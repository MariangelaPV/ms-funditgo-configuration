using System.ComponentModel.DataAnnotations;
using Configuration.Infrastructure.EntityFramework.ReadModel.Requisito;

namespace Configuration.Infrastructure.EntityFramework.ReadModel.Proyectos
{
    internal class RequisitoProyectoReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public ProyectoReadModel Proyecto { get; set; }
        public Guid ProyectoId { get; set; }
        public RequisitoReadModel Requisito { get; set; }
        public Guid RequisitoId { get; set; }
        public string Valor { get; set; }
    }
}
