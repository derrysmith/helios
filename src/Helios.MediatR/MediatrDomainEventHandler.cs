using MediatR;

namespace Helios.MediatR;

public abstract class MediatrDomainEventHandler<TDomainEvent> : INotificationHandler<TDomainEvent>
	where TDomainEvent : MediatrDomainEvent
{
	public abstract Task Handle(TDomainEvent notification, CancellationToken cancellationToken);
}