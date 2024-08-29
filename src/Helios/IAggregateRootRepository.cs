namespace Helios;

/// <summary>
/// Defines a representation of a repository of <see cref="TAggRoot"/> entities.
/// </summary>
/// <typeparam name="TAggRoot">
/// The aggregate root type.
/// </typeparam>
/// <typeparam name="TAggRootKey">
/// The aggregate root identifier type.
/// </typeparam>
public interface IAggregateRootRepository<TAggRoot, TAggRootKey>
	where TAggRoot : IDomainEntity<TAggRootKey>, IAggregateRoot
	where TAggRootKey : IEquatable<TAggRootKey>
{
	/// <summary>
	/// Retrieves the aggregate with the specified identifier.
	/// </summary>
	/// <param name="id">
	/// The aggregate identifier.
	/// </param>
	/// <param name="ct">
	/// A notification indicating if the operation should be cancelled.
	/// </param>
	/// <returns>The aggregate with the specified identifier.</returns>
	Task<TAggRoot> GetAsync(TAggRootKey id, CancellationToken ct = default);

	/// <summary>
	/// Adds the specified aggregate to the repository.
	/// </summary>
	/// <param name="aggregate">
	/// The aggregate to add.
	/// </param>
	void Append(TAggRoot aggregate);

	/// <summary>
	/// Updates the specified aggregate within the repository.
	/// </summary>
	/// <param name="aggregate">
	/// The aggregate to update.
	/// </param>
	void Update(TAggRoot aggregate);
}