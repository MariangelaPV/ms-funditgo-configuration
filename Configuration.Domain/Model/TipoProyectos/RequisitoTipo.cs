using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.Domain.Model.TipoProyectos
{
    public class RequisitoTipo : Entity
    {
        public Guid RequisitoId { get; private set; }
        public Guid TipoProyectoId { get; private set; }
        public bool Obligatorio { get; private set; }
        public int Orden { get; private set; }


        public RequisitoTipo(Guid requisitoId, Guid tipoProyectoId, bool obligatorio, int orden) 
        {
            if (requisitoId == Guid.Empty)
            {
                throw new ArgumentException("El requisito no puede ser vacio");
            }
            if (tipoProyectoId == Guid.Empty)
            {
                throw new ArgumentException("El tipo de proyecto no puede ser vacio");
            }
            Id = Guid.NewGuid();
            RequisitoId = requisitoId;
            TipoProyectoId = tipoProyectoId;
            Obligatorio = obligatorio;
            Orden = orden;
        }

        public RequisitoTipo() { }
    }
}
