using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Infrastructure.EntityFramework.ReadModel
{
    internal class TipoProyectoReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid RequisitoId { get; set; }
        public Guid TipoProyectoId { get; set; }
        public bool Obligatorio { get; set; }
        public int Orden { get; set; }
    }
}
