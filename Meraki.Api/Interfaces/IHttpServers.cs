using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IHttpServers
	{
		/// <summary>
		/// Add an HTTP server to a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkHttpServer">Body for creating a network HTTP server</param>
		[Post("/networks/{networkId}/webhooks/httpServers")]
		Task<HttpServer> CreateNetworkHttpServerAsync(
			[AliasAs("networkId")] string networkId,
			[Body] HttpServerCreationRequest createNetworkHttpServer,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Send a test webhook for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkHttpServersWebhookTest">Body for creating a network HTTP server webhook test</param>
		[Post("/networks/{networkId}/webhooks/webhookTests")]
		Task<WebhookTest> CreateNetworkHttpServersWebhookTestAsync(
			[AliasAs("networkId")] string networkId,
			[Body] HttpServersWebhookTestCreationRequest createNetworkHttpServersWebhookTest,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete an HTTP server from a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="httpServerId">The id of a HTTP server</param>
		[Delete("/networks/{networkId}/webhooks/httpServers/{httpServerId}")]
		Task DeleteNetworkHttpServerAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("httpServerId")] string httpServerId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return an HTTP server for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="httpServerId">The id of a HTTP server</param>
		[Get("/networks/{networkId}/webhooks/httpServers/{httpServerId}")]
		Task<HttpServer> GetNetworkHttpServerAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("httpServerId")] string httpServerId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the HTTP servers for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/webhooks/httpServers")]
		Task<List<HttpServer>> GetNetworkWebhooksHttpServersAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the status of a webhook test for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="webhookTestId">The id of a webhook test</param>
		[Get("/networks/{networkId}/webhooks/webhookTests/{webhookTestId}")]
		Task<WebSocket> GetNetworkHttpServersWebhookTestAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("webhookTestId")] string webhookTestId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update an HTTP server
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="httpServerId">The id of a HTTP server</param>
		/// <param name="updateNetworkHttpServer">Body for updating a network HTTP server</param>
		[Put("/networks/{networkId}/webhooks/httpServers/{httpServerId}")]
		Task<HttpServer> UpdateNetworkHttpServerAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("httpServerId")] string httpServerId,
			[Body] HttpServer httpServer,
			CancellationToken cancellationToken = default
			);
	}
}
