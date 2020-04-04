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
	/// How Bonjour rules are applied. Can be 'network default', 'ignore' or 'custom'.
	/// </summary>
	/// <value>How Bonjour rules are applied. Can be 'network default', 'ignore' or 'custom'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
    public enum Settings6
    {

        /// <summary>
        /// Enum Networkdefault for "network default"
        /// </summary>
        [EnumMember(Value = "network default")]
        Networkdefault,

        /// <summary>
        /// Enum Ignore for "ignore"
        /// </summary>
        [EnumMember(Value = "ignore")]
        Ignore,

        /// <summary>
        /// Enum Custom for "custom"
        /// </summary>
        [EnumMember(Value = "custom")]
        Custom
    }
}
