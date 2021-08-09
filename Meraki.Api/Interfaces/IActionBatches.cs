using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IActionBatches
	{
		/// <summary>
		/// createOrganizationActionBatch
		/// </summary>
		/// <remarks>
		/// Create an action batch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="createOrganizationActionBatch"></param>
		/// <returns>Task of Object</returns>
		[Post("/organizations/{organizationId}/actionBatches")]
		Task<object> CreateAsync(
			[AliasAs("organizationId")]string organizationId,
			[Body]ActionBatchCreationRequest createOrganizationActionBatch,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// deleteOrganizationActionBatch
		/// </summary>
		/// <remarks>
		/// Delete an action batch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="actionBatchId"></param>
		/// <returns>Task of void</returns>
		[Delete("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
		Task DeleteAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("actionBatchId")]string actionBatchId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationActionBatch
		/// </summary>
		/// <remarks>
		/// Return an action batch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="actionBatchId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
		Task<ActionBatch> GetAsync(

			[AliasAs("organizationId")]string organizationId,
			[AliasAs("actionBatchId")]string actionBatchId
			);

		/// <summary>
		/// getOrganizationActionBatches
		/// </summary>
		/// <remarks>
		/// Return the list of action batches in the organization
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="status">Filter batches by status. Valid types are pending, completed, and failed.</param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/actionBatches")]
		Task<List<ActionBatch>> GetAllAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("status")]string? status = null,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateOrganizationActionBatch
		/// </summary>
		/// <remarks>
		/// Update an action batch
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The Organization id</param>
		/// <param name="actionBatchId"></param>
		/// <param name="updateOrganizationActionBatch"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/actionBatches/{actionBatchId}")]
		Task<object> UpdateAsync(
			[AliasAs("organizationId")]string organizationId,
			[AliasAs("actionBatchId")]string actionBatchId,
			[Body]ActionBatchUpdateRequest updateOrganizationActionBatch = null!,
			CancellationToken cancellationToken = default);
	}
}