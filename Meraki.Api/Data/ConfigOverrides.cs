﻿namespace Meraki.Api.Data;

/// <summary>
/// Config overrides
/// </summary>
[DataContract]
public class ConfigOverrides
{
	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Allowed vlans
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "allowedVlans")]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// Vlan
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }
}
