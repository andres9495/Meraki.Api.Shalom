namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchPorts
{
	/// <summary>
	/// List the switch ports for a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[ApiOperationId("getDeviceSwitchPorts")]
	[Get("/devices/{serial}/switch/ports")]
	Task<List<SwitchPort>> GetDeviceSwitchPortsAsync(
		[AliasAs("serial")] string serial,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a switch port
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="portId">The port id</param>
	[ApiOperationId("getDeviceSwitchPort")]
	[Get("/devices/{serial}/switch/ports/{portId}")]
	Task<SwitchPort> GetDeviceSwitchPortAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("portId")] string portId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a switch port
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="portId">The port id</param>
	/// <param name="deviceSwitchPort">The new configuration</param>
	[ApiOperationId("updateDeviceSwitchPort")]
	[Put("/devices/{serial}/switch/ports/{portId}")]
	Task<SwitchPort> UpdateDeviceSwitchPortAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("portId")] string portId,
		[Body] SwitchPort deviceSwitchPort,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the status for all the ports of a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
	[Get("/devices/{serial}/switch/ports/statuses")]
	Task<List<SwitchPortStatus>> GetDeviceSwitchPortsStatusesAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the packet counters for all the ports of a switch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 1 day from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 1 day. The default is 1 day. (optional)</param>
	[Get("/devices/{serial}/switch/ports/statuses/packets")]
	Task<List<PacketsList>> GetDeviceSwitchPortsStatusesPacketsAsync(
		[AliasAs("serial")] string serial,
		[AliasAs("t0")] string t0 = null!,
		[AliasAs("timespan")] double? timespan = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Cycle a set of switch ports
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="deviceSwitchPortsCycleRequest">Body for cycling switch ports</param>
	[Post("/devices/{serial}/switch/ports/cycle")]
	Task<DeviceSwitchPortsCycleRequest> CycleDeviceSwitchPortsAsync(
		[AliasAs("serial")] string serial,
		[Body] DeviceSwitchPortsCycleRequest deviceSwitchPortsCycleRequest,
		CancellationToken cancellationToken = default);
}
