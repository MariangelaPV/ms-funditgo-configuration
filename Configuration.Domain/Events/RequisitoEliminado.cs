using SharedKernel.Core;
using System;

namespace Configuration.Domain.Events
{
    public record RequisitoEliminado : DomainEvent
    {
        public Guid RequisitoId { get; private set; }

        public RequisitoEliminado(Guid requisitoId) : base(DateTime.Now)
        {
            RequisitoId = requisitoId;
        }
    }
}
