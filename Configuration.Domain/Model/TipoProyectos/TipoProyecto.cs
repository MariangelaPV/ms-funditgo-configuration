using Configuration.Domain.ValueObjects;
using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Domain.Model.TipoProyectos
{
    public class TipoProyecto : AggregateRoot
    {
        public TextoValue Nombre { get; private set; }
        public TextoValue Descripcion { get; private set; }

        public TipoProyecto(string nombre, string descripcion)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public TipoProyecto() { }
    }
}
