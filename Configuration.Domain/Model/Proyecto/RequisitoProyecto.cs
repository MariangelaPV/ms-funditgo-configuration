using Configuration.Domain.ValueObjects;
using SharedKernel.Core;
using System;

namespace Configuration.Domain.Model.Proyecto
{
    public class RequisitoProyecto : Entity
    {
        public Guid ProyectoId { get; private set; }
        public Guid RequisitoId { get; private set; }
        public TextoValue Valor { get; private set; }

        public RequisitoProyecto(Guid proyectoId, Guid requisitoId, string valor) 
        {
            if (proyectoId == Guid.Empty)
            {
                throw new ArgumentException("El proyecto no puede ser vacio");
            }
            if (requisitoId == Guid.Empty)
            {
                throw new ArgumentException("El requisito no puede ser vacio");
            }
            Id = Guid.NewGuid();
            ProyectoId = proyectoId;
            RequisitoId = requisitoId;
            Valor = valor;
        }

        private RequisitoProyecto() { }
    }
}
