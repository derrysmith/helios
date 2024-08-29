namespace Helios;

/// <inheritdoc />
public abstract class DomainEntity<TEntityKey> : IDomainEntity<TEntityKey>
{
	/// <inheritdoc />
	public virtual TEntityKey Id { get; protected set; } = default!;
}