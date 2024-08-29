namespace Helios;

/// <summary>
/// Defines methods for applying state to an aggregate from a domain event.
/// </summary>
/// <typeparam name="T">
/// The type of domain event to apply.
/// </typeparam>
public interface IDomainEventApplier<in T>
	where T : IDomainEvent
{
	/// <summary>
	/// Updates the state of this instance with data from the specified domain event.
	/// </summary>
	/// <param name="domainEvent">
	/// The type of domain event to apply.
	/// </param>
	void Apply(T domainEvent);
}