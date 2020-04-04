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
	/// WAN 2 settings (only for MX devices)
	/// </summary>
	[DataContract]
    public partial class Wan2 :  IEquatable<Wan2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wan2" /> class.
        /// </summary>
        /// <param name="WanEnabled">WanEnabled.</param>
        /// <param name="UsingStaticIp">Configue the interface to have static IP settings or use DHCP..</param>
        /// <param name="StaticIp">The IP the device should use on the WAN..</param>
        /// <param name="StaticGatewayIp">The IP of the gateway on the WAN..</param>
        /// <param name="StaticSubnetMask">The subnet mask for the WAN..</param>
        /// <param name="StaticDns">Up to two DNS IPs..</param>
        /// <param name="Vlan">The VLAN that management traffic should be tagged with. Applies whether usingStaticIp is true or false..</param>
        public Wan2(WanEnabled WanEnabled = default, bool? UsingStaticIp = default, string StaticIp = default, string StaticGatewayIp = default, string StaticSubnetMask = default, List<string> StaticDns = default, int? Vlan = default)
        {
            this.WanEnabled = WanEnabled;
            this.UsingStaticIp = UsingStaticIp;
            this.StaticIp = StaticIp;
            this.StaticGatewayIp = StaticGatewayIp;
            this.StaticSubnetMask = StaticSubnetMask;
            this.StaticDns = StaticDns;
            this.Vlan = Vlan;
        }

        /// <summary>
        /// Gets or Sets WanEnabled
        /// </summary>
        [DataMember(Name="wanEnabled", EmitDefaultValue=false)]
        public WanEnabled WanEnabled { get; set; }
        /// <summary>
        /// Configue the interface to have static IP settings or use DHCP.
        /// </summary>
        /// <value>Configue the interface to have static IP settings or use DHCP.</value>
        [DataMember(Name="usingStaticIp", EmitDefaultValue=false)]
        public bool? UsingStaticIp { get; set; }
        /// <summary>
        /// The IP the device should use on the WAN.
        /// </summary>
        /// <value>The IP the device should use on the WAN.</value>
        [DataMember(Name="staticIp", EmitDefaultValue=false)]
        public string StaticIp { get; set; }
        /// <summary>
        /// The IP of the gateway on the WAN.
        /// </summary>
        /// <value>The IP of the gateway on the WAN.</value>
        [DataMember(Name="staticGatewayIp", EmitDefaultValue=false)]
        public string StaticGatewayIp { get; set; }
        /// <summary>
        /// The subnet mask for the WAN.
        /// </summary>
        /// <value>The subnet mask for the WAN.</value>
        [DataMember(Name="staticSubnetMask", EmitDefaultValue=false)]
        public string StaticSubnetMask { get; set; }
        /// <summary>
        /// Up to two DNS IPs.
        /// </summary>
        /// <value>Up to two DNS IPs.</value>
        [DataMember(Name="staticDns", EmitDefaultValue=false)]
        public List<string> StaticDns { get; set; }
        /// <summary>
        /// The VLAN that management traffic should be tagged with. Applies whether usingStaticIp is true or false.
        /// </summary>
        /// <value>The VLAN that management traffic should be tagged with. Applies whether usingStaticIp is true or false.</value>
        [DataMember(Name="vlan", EmitDefaultValue=false)]
        public int? Vlan { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Wan2 {\n");
            sb.Append("  WanEnabled: ").Append(WanEnabled).Append("\n");
            sb.Append("  UsingStaticIp: ").Append(UsingStaticIp).Append("\n");
            sb.Append("  StaticIp: ").Append(StaticIp).Append("\n");
            sb.Append("  StaticGatewayIp: ").Append(StaticGatewayIp).Append("\n");
            sb.Append("  StaticSubnetMask: ").Append(StaticSubnetMask).Append("\n");
            sb.Append("  StaticDns: ").Append(StaticDns).Append("\n");
            sb.Append("  Vlan: ").Append(Vlan).Append("\n");
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
            return Equals(obj as Wan2);
        }

        /// <summary>
        /// Returns true if Wan2 instances are equal
        /// </summary>
        /// <param name="other">Instance of Wan2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Wan2 other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  WanEnabled == other.WanEnabled ||
						  WanEnabled != null &&
						  WanEnabled.Equals(other.WanEnabled)
					 ) &&
					 (
						  UsingStaticIp == other.UsingStaticIp ||
						  UsingStaticIp != null &&
						  UsingStaticIp.Equals(other.UsingStaticIp)
					 ) &&
					 (
						  StaticIp == other.StaticIp ||
						  StaticIp != null &&
						  StaticIp.Equals(other.StaticIp)
					 ) &&
					 (
						  StaticGatewayIp == other.StaticGatewayIp ||
						  StaticGatewayIp != null &&
						  StaticGatewayIp.Equals(other.StaticGatewayIp)
					 ) &&
					 (
						  StaticSubnetMask == other.StaticSubnetMask ||
						  StaticSubnetMask != null &&
						  StaticSubnetMask.Equals(other.StaticSubnetMask)
					 ) &&
					 (
						  StaticDns == other.StaticDns ||
						  StaticDns != null &&
						  StaticDns.SequenceEqual(other.StaticDns)
					 ) &&
					 (
						  Vlan == other.Vlan ||
						  Vlan != null &&
						  Vlan.Equals(other.Vlan)
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
                if (WanEnabled != null)
                    hash = hash * 59 + WanEnabled.GetHashCode();
                if (UsingStaticIp != null)
                    hash = hash * 59 + UsingStaticIp.GetHashCode();
                if (StaticIp != null)
                    hash = hash * 59 + StaticIp.GetHashCode();
                if (StaticGatewayIp != null)
                    hash = hash * 59 + StaticGatewayIp.GetHashCode();
                if (StaticSubnetMask != null)
                    hash = hash * 59 + StaticSubnetMask.GetHashCode();
                if (StaticDns != null)
                    hash = hash * 59 + StaticDns.GetHashCode();
                if (Vlan != null)
                    hash = hash * 59 + Vlan.GetHashCode();
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
