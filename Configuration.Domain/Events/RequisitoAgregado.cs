using SharedKernel.Core;
using System;

namespace Configuration.Domain.Events
{
    public record RequisitoAgregado : DomainEvent
    {
        public Guid RequisitoId { get; private set; }
        public RequisitoAgregado(Guid requisitoId) : base(DateTime.Now)
        {
            RequisitoId = requisitoId;
        }
    }
}
