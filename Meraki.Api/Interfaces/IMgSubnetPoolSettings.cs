using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgSubnetPoolSettings
	{
		/// <summary>
		/// getNetworkCellularGatewaySettingsSubnetPool
		/// </summary>
		/// <remarks>
		/// Return the subnet pool and mask configured for MGs in the network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/cellularGateway/settings/subnetPool")]
		Task<object> GetNetworkCellularGatewaySettingsSubnetPool(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkCellularGatewaySettingsSubnetPool
		/// </summary>
		/// <remarks>
		/// Update the subnet pool and mask configuration for MGs in the network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkCellularGatewaySettingsSubnetPool"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/cellularGateway/settings/subnetPool")]
		Task<object> UpdateNetworkCellularGatewaySettingsSubnetPool(
			[AliasAs("networkId")]string networkId,
			[Body]NetworkCellularGatewaySettingsSubnetPoolUpdateRequest updateNetworkCellularGatewaySettingsSubnetPool
			);
	}
}
