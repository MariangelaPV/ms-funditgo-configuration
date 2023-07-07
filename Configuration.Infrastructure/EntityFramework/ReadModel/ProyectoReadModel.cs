using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Infrastructure.EntityFramework.ReadModel
{
    internal class ProyectoReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreado { get; set; }
        public DateTime? FechaBorrador { get; set; }
        public DateTime? FechaRevision { get; set; }
        public DateTime? FechaObservado { get; set; }
        public DateTime? FechaModificado { get; set; }
        public DateTime? FechaAprobado { get; set; }
        public DateTime? FechaRechazado { get; set; }
    }
}
