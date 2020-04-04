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
	/// Minimum bitrate can be set to either 'band' or 'ssid'.
	/// </summary>
	/// <value>Minimum bitrate can be set to either 'band' or 'ssid'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
    public enum MinBitrateType1
    {

        /// <summary>
        /// Enum Band for "band"
        /// </summary>
        [EnumMember(Value = "band")]
        Band,

        /// <summary>
        /// Enum Ssid for "ssid"
        /// </summary>
        [EnumMember(Value = "ssid")]
        Ssid
    }
}
