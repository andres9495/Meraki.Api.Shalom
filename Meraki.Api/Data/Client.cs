﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A (Network) Client
	/// </summary>
	[DataContract]
	public class Client : IdentifiedItem
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public new string Id { get; set; } = string.Empty;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = default!;

		/// <summary>
		/// The mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = default!;

		/// <summary>
		/// The IP address
		/// </summary>
		[DataMember(Name = "ip")]
		public string Ip { get; set; } = default!;

		/// <summary>
		/// The user
		/// </summary>
		[DataMember(Name = "user")]
		public string User { get; set; } = default!;

		/// <summary>
		/// The VLAN
		/// </summary>
		[DataMember(Name = "vlan")]
		public int Vlan { get; set; }

		/// <summary>
		/// The switch port
		/// </summary>
		[DataMember(Name = "switchport")]
		public object Switchport { get; set; } = default!;

		/// <summary>
		/// The IPv6 address
		/// </summary>
		[DataMember(Name = "ip6")]
		public string Ip6 { get; set; } = default!;

		/// <summary>
		/// When this client was first seen
		/// </summary>
		[DataMember(Name = "firstSeen")]
		public int FirstSeen { get; set; }

		/// <summary>
		/// When this client was last seen
		/// </summary>
		[DataMember(Name = "lastSeen")]
		public int LastSeen { get; set; }

		/// <summary>
		/// The manufacturer
		/// </summary>
		[DataMember(Name = "manufacturer")]
		public string Manufacturer { get; set; } = default!;

		/// <summary>
		/// The Operating system
		/// </summary>
		[DataMember(Name = "os")]
		public string Os { get; set; } = default!;

		/// <summary>
		/// SSID
		/// </summary>
		[DataMember(Name = "ssid")]
		public string Ssid { get; set; } = string.Empty;

		/// <summary>
		/// Wireless capabilities
		/// </summary>
		[DataMember(Name = "wirelessCapabilities")]
		public string WirelessCapabilities { get; set; } = string.Empty;

		/// <summary>
		/// The recent device mac address
		/// </summary>
		[DataMember(Name = "recentDeviceMac")]
		public string RecentDeviceMac { get; set; } = default!;

		/// <summary>
		/// The status
		/// </summary>
		[DataMember(Name = "status")]
		public string Status { get; set; } = default!;

		/// <summary>
		/// The notes
		/// </summary>
		[DataMember(Name = "notes")]
		public string Notes { get; set; } = default!;

		/// <summary>
		/// SM Installed
		/// </summary>
		[DataMember(Name = "smInstalled")]
		public bool SmInstalled { get; set; } = default!;

		/// <summary>
		/// LLDP
		/// </summary>
		[DataMember(Name = "lldp")]
		public List<List<string>> Lldp { get; set; } = new();

		/// <summary>
		/// Client VPN connections
		/// </summary>
		[DataMember(Name = "clientVpnConnections")]
		public List<ClientVpnConnections> ClientVpnConnections { get; set; } = new();
	}
}