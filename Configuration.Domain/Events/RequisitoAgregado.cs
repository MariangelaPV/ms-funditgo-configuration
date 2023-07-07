using SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
