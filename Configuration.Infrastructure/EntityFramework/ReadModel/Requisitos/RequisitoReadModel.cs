using System.ComponentModel.DataAnnotations;

namespace Configuration.Infrastructure.EntityFramework.ReadModel.Requisitos
{
    internal class RequisitoReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
