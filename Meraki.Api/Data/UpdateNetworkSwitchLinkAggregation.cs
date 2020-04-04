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
	/// UpdateNetworkSwitchLinkAggregation
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkSwitchLinkAggregation :  IEquatable<UpdateNetworkSwitchLinkAggregation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSwitchLinkAggregation" /> class.
        /// </summary>
        /// <param name="SwitchPorts">Array of switch or stack ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported..</param>
        /// <param name="SwitchProfilePorts">Array of switch profile ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported..</param>
        public UpdateNetworkSwitchLinkAggregation(List<SwitchPort> SwitchPorts = default, List<SwitchProfilePort> SwitchProfilePorts = default)
        {
            this.SwitchPorts = SwitchPorts;
            this.SwitchProfilePorts = SwitchProfilePorts;
        }

        /// <summary>
        /// Array of switch or stack ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported.
        /// </summary>
        /// <value>Array of switch or stack ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported.</value>
        [DataMember(Name="switchPorts", EmitDefaultValue=false)]
        public List<SwitchPort> SwitchPorts { get; set; }
        /// <summary>
        /// Array of switch profile ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported.
        /// </summary>
        /// <value>Array of switch profile ports for updating aggregation group. Minimum 2 and maximum 8 ports are supported.</value>
        [DataMember(Name="switchProfilePorts", EmitDefaultValue=false)]
        public List<SwitchProfilePort> SwitchProfilePorts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkSwitchLinkAggregation {\n");
            sb.Append("  SwitchPorts: ").Append(SwitchPorts).Append("\n");
            sb.Append("  SwitchProfilePorts: ").Append(SwitchProfilePorts).Append("\n");
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
            return Equals(obj as UpdateNetworkSwitchLinkAggregation);
        }

        /// <summary>
        /// Returns true if UpdateNetworkSwitchLinkAggregation instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkSwitchLinkAggregation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkSwitchLinkAggregation other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  SwitchPorts == other.SwitchPorts ||
						  SwitchPorts != null &&
						  SwitchPorts.SequenceEqual(other.SwitchPorts)
					 ) &&
					 (
						  SwitchProfilePorts == other.SwitchProfilePorts ||
						  SwitchProfilePorts != null &&
						  SwitchProfilePorts.SequenceEqual(other.SwitchProfilePorts)
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
                if (SwitchPorts != null)
                    hash = hash * 59 + SwitchPorts.GetHashCode();
                if (SwitchProfilePorts != null)
                    hash = hash * 59 + SwitchProfilePorts.GetHashCode();
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
