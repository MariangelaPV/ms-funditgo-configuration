using MediatR;

namespace SharedKernel.Core
{
    public record ConfirmedDomainEvent<T> : INotification where T : DomainEvent
    {
        public T DomainEvent { get; }
        public ConfirmedDomainEvent(T domainEvent)
        {
            DomainEvent = domainEvent;
        }
    }
}
