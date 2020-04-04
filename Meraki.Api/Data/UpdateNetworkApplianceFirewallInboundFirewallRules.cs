/* 
 * Meraki Dashboard API
 *
 *   *Version 0.10.0*  The Cisco Meraki Dashboard API is a modern REST API based on the OpenAPI specification.  > Date: 01 April, 2020 > > [What's New](https://meraki.io/whats-new/)  - --  [API Documentation](https://meraki.io/api)  [Community Support](https://meraki.io/community)  [Meraki Homepage](https://www.meraki.com)     
 *
 * OpenAPI spec version: 0.10.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkApplianceFirewallInboundFirewallRules
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkApplianceFirewallInboundFirewallRules :  IEquatable<UpdateNetworkApplianceFirewallInboundFirewallRules>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkApplianceFirewallInboundFirewallRules" /> class.
        /// </summary>
        /// <param name="Rules">An ordered array of the firewall rules (not including the default rule).</param>
        /// <param name="SyslogDefaultRule">Log the special default rule (boolean value - enable only if you&#39;ve configured a syslog server) (optional).</param>
        public UpdateNetworkApplianceFirewallInboundFirewallRules(List<MxCellularFirewallRule> Rules = default, bool? SyslogDefaultRule = default)
        {
            this.Rules = Rules;
            this.SyslogDefaultRule = SyslogDefaultRule;
        }

        /// <summary>
        /// An ordered array of the firewall rules (not including the default rule)
        /// </summary>
        /// <value>An ordered array of the firewall rules (not including the default rule)</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<MxCellularFirewallRule> Rules { get; set; }
        /// <summary>
        /// Log the special default rule (boolean value - enable only if you&#39;ve configured a syslog server) (optional)
        /// </summary>
        /// <value>Log the special default rule (boolean value - enable only if you&#39;ve configured a syslog server) (optional)</value>
        [DataMember(Name="syslogDefaultRule", EmitDefaultValue=false)]
        public bool? SyslogDefaultRule { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkApplianceFirewallInboundFirewallRules {\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  SyslogDefaultRule: ").Append(SyslogDefaultRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as UpdateNetworkApplianceFirewallInboundFirewallRules);
        }

        /// <summary>
        /// Returns true if UpdateNetworkApplianceFirewallInboundFirewallRules instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkApplianceFirewallInboundFirewallRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkApplianceFirewallInboundFirewallRules other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Rules == other.Rules ||
						  Rules != null &&
						  Rules.SequenceEqual(other.Rules)
					 ) &&
					 (
						  SyslogDefaultRule == other.SyslogDefaultRule ||
						  SyslogDefaultRule != null &&
						  SyslogDefaultRule.Equals(other.SyslogDefaultRule)
					 );
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (Rules != null)
                    hash = hash * 59 + Rules.GetHashCode();
                if (SyslogDefaultRule != null)
                    hash = hash * 59 + SyslogDefaultRule.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
