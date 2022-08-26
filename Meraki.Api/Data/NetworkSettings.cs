﻿namespace Meraki.Api.Data;

/// <summary>
/// Network settings
/// </summary>
[DataContract]
public class NetworkSettings
{
	/// <summary>
	/// Local status page enabled?
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "localStatusPageEnabled")]
	public bool? LocalStatusPageEnabled { get; set; }

	/// <summary>
	/// Remote status page enabled?
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "remoteStatusPageEnabled")]
	public bool? RemoteStatusPageEnabled { get; set; }

	/// <summary>
	/// Secure connect settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "secureConnect")]
	public NetworkSettingsSecureConnect? SecureConnect { get; set; }

	/// <summary>
	/// Fips settings - undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fips")]
	public NetworkSettingsFips? Fips { get; set; }

	/// <summary>
	/// Local Status PAge
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "localStatusPage")]
	public LocalStatusPage? LocalStatusPage { get; set; }
}
