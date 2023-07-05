using System;
using SharedKernel.Core;

namespace Configuration.Domain.ValueObjects
{
    public record EstadoValue : ValueObject
    {
        private readonly string Estado;

        private EstadoValue(string estado)
        {
            Estado = estado;
        }

        public static readonly EstadoValue creado = new EstadoValue("Creado");
        public static readonly EstadoValue borrador = new EstadoValue("Borrador");
        public static readonly EstadoValue revision = new EstadoValue("Revision");
        public static readonly EstadoValue observado = new EstadoValue("Observado");
        public static readonly EstadoValue modificado = new EstadoValue("Modificado");
        public static readonly EstadoValue aprobado = new EstadoValue("Aprobar");
        public static readonly EstadoValue rechazado = new EstadoValue("Rechazado");

        public static implicit operator string(EstadoValue value)
        {
            return value.Estado;
        }

        public static implicit operator EstadoValue(string value)
        {
            return new EstadoValue(value);
        }
    }
}