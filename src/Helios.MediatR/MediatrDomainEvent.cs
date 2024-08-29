using MediatR;

namespace Helios.MediatR;

public abstract record MediatrDomainEvent : IDomainEvent, INotification;