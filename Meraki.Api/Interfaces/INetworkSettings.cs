using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INetworkSettings
	{
		/// <summary>
		/// getNetworkSettings
		/// </summary>
		/// <remarks>
		/// Return the settings for a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/settings")]
		Task<NetworkSettings> GetNetworkSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkSettings
		/// </summary>
		/// <remarks>
		/// Update the settings for a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/settings")]
		Task<NetworkSettings> UpdateNetworkSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkSettings updateNetworkSettings,
			CancellationToken cancellationToken = default
			);
	}
}