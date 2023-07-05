using Configuration.Domain.ValueObjects;
using SharedKernel.Core;
using System;

namespace Configuration.Domain.Model.Requisito
{
    public class Requisito : AggregateRoot
    {
        public TextoValue Nombre { get; private set; }
        public TextoValue Descripcion { get; private set; }

        public Requisito(string nombre, string descripcion)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public Requisito() { }
    }
}
