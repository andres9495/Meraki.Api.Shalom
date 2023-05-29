﻿namespace Meraki.Api.Data;

/// <summary>
/// Secure port settings - formerlu secure connect
/// </summary>
[DataContract]
public class SwitchPortStatusSecurePort
{
	/// <summary>
	/// Enabled?
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Active
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "active")]
	public bool? Active { get; set; }

	/// <summary>
	/// Authentication status
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "authenticationStatus")]
	public string? AuthenticationStatus { get; set; }

	/// <summary>
	/// Config overrides
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "configOverrides")]
	public ConfigOverrides? ConfigOverrides { get; set; }
}
