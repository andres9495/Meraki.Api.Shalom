/* 
 * Meraki Dashboard API
 *
 *   *Version 0.10.0*  The Cisco Meraki Dashboard API is a modern REST API based on the OpenAPI specification.  > Date: 01 April, 2020 > > [What's New](https://meraki.io/whats-new/)  - --  [API Documentation](https://meraki.io/api)  [Community Support](https://meraki.io/community)  [Meraki Homepage](https://www.meraki.com)     
 *
 * OpenAPI spec version: 0.10.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The type of protocol (must be 'tcp', 'udp', 'icmp' or 'any')
	/// </summary>
	/// <value>The type of protocol (must be 'tcp', 'udp', 'icmp' or 'any')</value>
	[JsonConverter(typeof(StringEnumConverter))]
    public enum Protocol
    {

        /// <summary>
        /// Enum Tcp for "tcp"
        /// </summary>
        [EnumMember(Value = "tcp")]
        Tcp,

        /// <summary>
        /// Enum Udp for "udp"
        /// </summary>
        [EnumMember(Value = "udp")]
        Udp,

        /// <summary>
        /// Enum Icmp for "icmp"
        /// </summary>
        [EnumMember(Value = "icmp")]
        Icmp,

        /// <summary>
        /// Enum Any for "any"
        /// </summary>
        [EnumMember(Value = "any")]
        Any
    }
}
