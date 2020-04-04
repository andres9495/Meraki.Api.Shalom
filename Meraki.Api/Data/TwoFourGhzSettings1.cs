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
	/// Settings related to 2.4Ghz band
	/// </summary>
	[DataContract]
    public partial class TwoFourGhzSettings1 :  IEquatable<TwoFourGhzSettings1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoFourGhzSettings1" /> class.
        /// </summary>
        /// <param name="MaxPower">Sets max power (dBm) of 2.4Ghz band. Can be integer between 5 and 30..</param>
        /// <param name="MinPower">Sets min power (dBm) of 2.4Ghz band. Can be integer between 5 and 30..</param>
        /// <param name="MinBitrate">Sets min bitrate (Mbps) of 2.4Ghz band. Can be one of &#39;1&#39;, &#39;2&#39;, &#39;5.5&#39;, &#39;6&#39;, &#39;9&#39;, &#39;11&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;..</param>
        /// <param name="ValidAutoChannels">Sets valid auto channels for 2.4Ghz band. Can be one of &#39;1&#39;, &#39;6&#39; or &#39;11&#39;..</param>
        /// <param name="AxEnabled">Determines whether ax radio on 2.4Ghz band is on or off. Can be either true or false. If false, we highly recommend disabling band steering..</param>
        /// <param name="Rxsop">The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default..</param>
        public TwoFourGhzSettings1(int? MaxPower = default, int? MinPower = default, double? MinBitrate = default, List<int?> ValidAutoChannels = default, bool? AxEnabled = default, int? Rxsop = default)
        {
            this.MaxPower = MaxPower;
            this.MinPower = MinPower;
            this.MinBitrate = MinBitrate;
            this.ValidAutoChannels = ValidAutoChannels;
            this.AxEnabled = AxEnabled;
            this.Rxsop = Rxsop;
        }

        /// <summary>
        /// Sets max power (dBm) of 2.4Ghz band. Can be integer between 5 and 30.
        /// </summary>
        /// <value>Sets max power (dBm) of 2.4Ghz band. Can be integer between 5 and 30.</value>
        [DataMember(Name="maxPower", EmitDefaultValue=false)]
        public int? MaxPower { get; set; }
        /// <summary>
        /// Sets min power (dBm) of 2.4Ghz band. Can be integer between 5 and 30.
        /// </summary>
        /// <value>Sets min power (dBm) of 2.4Ghz band. Can be integer between 5 and 30.</value>
        [DataMember(Name="minPower", EmitDefaultValue=false)]
        public int? MinPower { get; set; }
        /// <summary>
        /// Sets min bitrate (Mbps) of 2.4Ghz band. Can be one of &#39;1&#39;, &#39;2&#39;, &#39;5.5&#39;, &#39;6&#39;, &#39;9&#39;, &#39;11&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;.
        /// </summary>
        /// <value>Sets min bitrate (Mbps) of 2.4Ghz band. Can be one of &#39;1&#39;, &#39;2&#39;, &#39;5.5&#39;, &#39;6&#39;, &#39;9&#39;, &#39;11&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;.</value>
        [DataMember(Name="minBitrate", EmitDefaultValue=false)]
        public double? MinBitrate { get; set; }
        /// <summary>
        /// Sets valid auto channels for 2.4Ghz band. Can be one of &#39;1&#39;, &#39;6&#39; or &#39;11&#39;.
        /// </summary>
        /// <value>Sets valid auto channels for 2.4Ghz band. Can be one of &#39;1&#39;, &#39;6&#39; or &#39;11&#39;.</value>
        [DataMember(Name="validAutoChannels", EmitDefaultValue=false)]
        public List<int?> ValidAutoChannels { get; set; }
        /// <summary>
        /// Determines whether ax radio on 2.4Ghz band is on or off. Can be either true or false. If false, we highly recommend disabling band steering.
        /// </summary>
        /// <value>Determines whether ax radio on 2.4Ghz band is on or off. Can be either true or false. If false, we highly recommend disabling band steering.</value>
        [DataMember(Name="axEnabled", EmitDefaultValue=false)]
        public bool? AxEnabled { get; set; }
        /// <summary>
        /// The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default.
        /// </summary>
        /// <value>The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default.</value>
        [DataMember(Name="rxsop", EmitDefaultValue=false)]
        public int? Rxsop { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TwoFourGhzSettings1 {\n");
            sb.Append("  MaxPower: ").Append(MaxPower).Append("\n");
            sb.Append("  MinPower: ").Append(MinPower).Append("\n");
            sb.Append("  MinBitrate: ").Append(MinBitrate).Append("\n");
            sb.Append("  ValidAutoChannels: ").Append(ValidAutoChannels).Append("\n");
            sb.Append("  AxEnabled: ").Append(AxEnabled).Append("\n");
            sb.Append("  Rxsop: ").Append(Rxsop).Append("\n");
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
            return Equals(obj as TwoFourGhzSettings1);
        }

        /// <summary>
        /// Returns true if TwoFourGhzSettings1 instances are equal
        /// </summary>
        /// <param name="other">Instance of TwoFourGhzSettings1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TwoFourGhzSettings1 other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  MaxPower == other.MaxPower ||
						  MaxPower != null &&
						  MaxPower.Equals(other.MaxPower)
					 ) &&
					 (
						  MinPower == other.MinPower ||
						  MinPower != null &&
						  MinPower.Equals(other.MinPower)
					 ) &&
					 (
						  MinBitrate == other.MinBitrate ||
						  MinBitrate != null &&
						  MinBitrate.Equals(other.MinBitrate)
					 ) &&
					 (
						  ValidAutoChannels == other.ValidAutoChannels ||
						  ValidAutoChannels != null &&
						  ValidAutoChannels.SequenceEqual(other.ValidAutoChannels)
					 ) &&
					 (
						  AxEnabled == other.AxEnabled ||
						  AxEnabled != null &&
						  AxEnabled.Equals(other.AxEnabled)
					 ) &&
					 (
						  Rxsop == other.Rxsop ||
						  Rxsop != null &&
						  Rxsop.Equals(other.Rxsop)
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
                if (MaxPower != null)
                    hash = hash * 59 + MaxPower.GetHashCode();
                if (MinPower != null)
                    hash = hash * 59 + MinPower.GetHashCode();
                if (MinBitrate != null)
                    hash = hash * 59 + MinBitrate.GetHashCode();
                if (ValidAutoChannels != null)
                    hash = hash * 59 + ValidAutoChannels.GetHashCode();
                if (AxEnabled != null)
                    hash = hash * 59 + AxEnabled.GetHashCode();
                if (Rxsop != null)
                    hash = hash * 59 + Rxsop.GetHashCode();
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
