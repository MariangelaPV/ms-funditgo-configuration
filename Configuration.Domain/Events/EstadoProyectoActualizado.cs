using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Domain.Events
{
    public record EstadoProyectoActualizado : DomainEvent
    {
        public string Nombre { get; }
        public string Estado { get; }

        public EstadoProyectoActualizado(string nombreProyecto, string estado) : base(DateTime.Now)
        {
            Nombre = nombreProyecto;
            Estado = estado;
        }
    }
}
