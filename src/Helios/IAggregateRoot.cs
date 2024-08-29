namespace Helios;

/// <summary>
/// Marker interface for an aggregate root within the domain.
/// </summary>
public interface IAggregateRoot
{
	/// <summary>
	/// Returns a collection of pending domain events.
	/// </summary>
	/// <returns>
	/// A collection of pending domain events.
	/// </returns>
	IEnumerable<IDomainEvent> GetDomainEvents();

	/// <summary>
	/// Removes all pending domain events from the aggregate.
	/// </summary>
	void RemoveDomainEvents();
}