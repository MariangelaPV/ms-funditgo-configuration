using Configuration.Infrastructure.EntityFramework.Context;
using MediatR;
using SharedKernel.Core;

namespace Configuration.Infrastructure.EntityFramework
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly WriteDbContext _context;
        private readonly IMediator _mediator;
        public UnitOfWork(WriteDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task Commit()
        {
            var domainEvents = _context.ChangeTracker.Entries<Entity>()
                .Select(x => x.Entity.DomainEvents)
                .SelectMany(x => x)
                .Where(x => !x.Consumed)
                .ToArray();

            foreach (var evento in domainEvents)
            {
                evento.MarkAsConsumed();
                await _mediator.Publish(evento);
            }

            await _context.SaveChangesAsync();

            foreach (var @event in  domainEvents)
            {
                Type type = typeof(ConfirmedDomainEvent<>).MakeGenericType(@event.GetType());
                var confirmedEvent = (INotification)Activator.CreateInstance(type, @event);
                await _mediator.Publish(confirmedEvent);
            }
        }
    }
}
