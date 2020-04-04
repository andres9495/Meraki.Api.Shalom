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
	/// The site-to-site VPN mode. Can be one of 'none', 'spoke' or 'hub'
	/// </summary>
	/// <value>The site-to-site VPN mode. Can be one of 'none', 'spoke' or 'hub'</value>
	[JsonConverter(typeof(StringEnumConverter))]
    public enum Mode2
    {

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Enum Spoke for "spoke"
        /// </summary>
        [EnumMember(Value = "spoke")]
        Spoke,

        /// <summary>
        /// Enum Hub for "hub"
        /// </summary>
        [EnumMember(Value = "hub")]
        Hub
    }
}
