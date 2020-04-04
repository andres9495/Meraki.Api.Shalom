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
	/// The 'Help -> Community' subtab which provides a link to Meraki Community. Can be one of 'default or inherit', 'hide' or 'show'.
	/// </summary>
	/// <value>The 'Help -> Community' subtab which provides a link to Meraki Community. Can be one of 'default or inherit', 'hide' or 'show'.</value>
	[JsonConverter(typeof(StringEnumConverter))]
    public enum CommunitySubtab
    {

        /// <summary>
        /// Enum Defaultorinherit for "default or inherit"
        /// </summary>
        [EnumMember(Value = "default or inherit")]
        Defaultorinherit,

        /// <summary>
        /// Enum Hide for "hide"
        /// </summary>
        [EnumMember(Value = "hide")]
        Hide,

        /// <summary>
        /// Enum Show for "show"
        /// </summary>
        [EnumMember(Value = "show")]
        Show
    }
}
