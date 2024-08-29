namespace Helios;

/// <summary>
/// Defines an aggregate root with base domain functionality.
/// </summary>
/// <typeparam name="TAggRootKey">
/// The type of the identifier of the aggregate.
/// </typeparam>
public abstract class AggregateRoot<TAggRootKey> : DomainEntity<TAggRootKey>, IAggregateRoot
{
	private readonly List<IDomainEvent> _events = new();

	/// <inheritdoc />
	public IEnumerable<IDomainEvent> GetDomainEvents()
		=> _events.AsReadOnly();

	/// <inheritdoc />
	public void RemoveDomainEvents()
		=> _events.Clear();

	/// <summary>
	/// 
	/// </summary>
	/// <param name="domainEvent"></param>
	/// <typeparam name="T"></typeparam>
	protected virtual void RaiseEvent<T>(T domainEvent)
		where T : IDomainEvent
	{
		this.ApplyEvent(domainEvent);
		this.StashEvent(domainEvent);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="domainEvent"></param>
	/// <typeparam name="T"></typeparam>
	protected virtual void ApplyEvent<T>(T domainEvent)
		where T : IDomainEvent
	{
		if (this is IDomainEventApplier<T> applier)
			applier.Apply(domainEvent);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="domainEvent"></param>
	/// <typeparam name="T"></typeparam>
	protected virtual void StashEvent<T>(T domainEvent)
		where T : IDomainEvent
	{
		_events.Add(domainEvent);
	}
}