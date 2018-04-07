#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="Chinchilla Software Limited">
// // 	Copyright Chinchilla Software Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

namespace Cqrs.Azure.BlobStorage
{
	/// <summary>
	/// A factory for getting connection strings and container names with blob storage for snapshots.
	/// </summary>
	public interface IBlobStorageSnapshotStoreConnectionStringFactory
		: IBlobStorageStoreConnectionStringFactory
	{
	}
}