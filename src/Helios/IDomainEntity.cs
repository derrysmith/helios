namespace Helios;

/// <summary>
/// Marker interface for a domain entity.
/// </summary>
public interface IDomainEntity;

/// <summary>
/// Defines a domain entity having a primary key with an "Id" property.
/// </summary>
/// <typeparam name="TEntityKey">
/// The type of the identifier of the entity.
/// </typeparam>
public interface IDomainEntity<out TEntityKey> : IDomainEntity
{
	/// <summary>
	/// the unique identifier of the entity
	/// </summary>
	TEntityKey Id { get; }
}