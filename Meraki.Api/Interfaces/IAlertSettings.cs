using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IAlertSettings
	{
		/// <summary>
		/// getNetworkAlertsSettings
		/// </summary>
		/// <remarks>
		/// Return the alert configuration for this network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/alerts/settings")]
		Task<AlertSettingsUpdateRequest> GetNetworkAlertsSettings(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkAlertSettings
		/// </summary>
		/// <remarks>
		/// Update the alert configuration for this network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkAlertSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/alerts/settings")]
		Task<object> UpdateNetworkAlertSettings(
			[AliasAs("networkId")]string networkId,
			[Body]AlertSettingsUpdateRequest updateNetworkAlertSettings = null!,
			CancellationToken cancellationToken = default);
	}
}