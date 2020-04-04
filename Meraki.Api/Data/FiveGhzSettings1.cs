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
	/// Settings related to 5Ghz band
	/// </summary>
	[DataContract]
    public partial class FiveGhzSettings1 :  IEquatable<FiveGhzSettings1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FiveGhzSettings1" /> class.
        /// </summary>
        /// <param name="MaxPower">Sets max power (dBm) of 5Ghz band. Can be integer between 8 and 30..</param>
        /// <param name="MinPower">Sets min power (dBm) of 5Ghz band. Can be integer between 8 and 30..</param>
        /// <param name="MinBitrate">Sets min bitrate (Mbps) of 5Ghz band. Can be one of &#39;6&#39;, &#39;9&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;..</param>
        /// <param name="ValidAutoChannels">Sets valid auto channels for 5Ghz band. Can be one of &#39;36&#39;, &#39;40&#39;, &#39;44&#39;, &#39;48&#39;, &#39;52&#39;, &#39;56&#39;, &#39;60&#39;, &#39;64&#39;, &#39;100&#39;, &#39;104&#39;, &#39;108&#39;, &#39;112&#39;, &#39;116&#39;, &#39;120&#39;, &#39;124&#39;, &#39;128&#39;, &#39;132&#39;, &#39;136&#39;, &#39;140&#39;, &#39;144&#39;, &#39;149&#39;, &#39;153&#39;, &#39;157&#39;, &#39;161&#39; or &#39;165&#39;..</param>
        /// <param name="ChannelWidth">Sets channel width (MHz) for 5Ghz band. Can be one of &#39;auto&#39;, &#39;20&#39;, &#39;40&#39; or &#39;80&#39;..</param>
        /// <param name="Rxsop">The RX-SOP level controls the sensitivity of the radio. It is strongly recommended to use RX-SOP only after     consulting a wireless expert. RX-SOP can be configured in the range of -65 to -95 (dBm). A value of null will     reset this to the default..</param>
        public FiveGhzSettings1(int? MaxPower = default, int? MinPower = default, int? MinBitrate = default, List<int?> ValidAutoChannels = default, string ChannelWidth = default, int? Rxsop = default)
        {
            this.MaxPower = MaxPower;
            this.MinPower = MinPower;
            this.MinBitrate = MinBitrate;
            this.ValidAutoChannels = ValidAutoChannels;
            this.ChannelWidth = ChannelWidth;
            this.Rxsop = Rxsop;
        }

        /// <summary>
        /// Sets max power (dBm) of 5Ghz band. Can be integer between 8 and 30.
        /// </summary>
        /// <value>Sets max power (dBm) of 5Ghz band. Can be integer between 8 and 30.</value>
        [DataMember(Name="maxPower", EmitDefaultValue=false)]
        public int? MaxPower { get; set; }
        /// <summary>
        /// Sets min power (dBm) of 5Ghz band. Can be integer between 8 and 30.
        /// </summary>
        /// <value>Sets min power (dBm) of 5Ghz band. Can be integer between 8 and 30.</value>
        [DataMember(Name="minPower", EmitDefaultValue=false)]
        public int? MinPower { get; set; }
        /// <summary>
        /// Sets min bitrate (Mbps) of 5Ghz band. Can be one of &#39;6&#39;, &#39;9&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;.
        /// </summary>
        /// <value>Sets min bitrate (Mbps) of 5Ghz band. Can be one of &#39;6&#39;, &#39;9&#39;, &#39;12&#39;, &#39;18&#39;, &#39;24&#39;, &#39;36&#39;, &#39;48&#39; or &#39;54&#39;.</value>
        [DataMember(Name="minBitrate", EmitDefaultValue=false)]
        public int? MinBitrate { get; set; }
        /// <summary>
        /// Sets valid auto channels for 5Ghz band. Can be one of &#39;36&#39;, &#39;40&#39;, &#39;44&#39;, &#39;48&#39;, &#39;52&#39;, &#39;56&#39;, &#39;60&#39;, &#39;64&#39;, &#39;100&#39;, &#39;104&#39;, &#39;108&#39;, &#39;112&#39;, &#39;116&#39;, &#39;120&#39;, &#39;124&#39;, &#39;128&#39;, &#39;132&#39;, &#39;136&#39;, &#39;140&#39;, &#39;144&#39;, &#39;149&#39;, &#39;153&#39;, &#39;157&#39;, &#39;161&#39; or &#39;165&#39;.
        /// </summary>
        /// <value>Sets valid auto channels for 5Ghz band. Can be one of &#39;36&#39;, &#39;40&#39;, &#39;44&#39;, &#39;48&#39;, &#39;52&#39;, &#39;56&#39;, &#39;60&#39;, &#39;64&#39;, &#39;100&#39;, &#39;104&#39;, &#39;108&#39;, &#39;112&#39;, &#39;116&#39;, &#39;120&#39;, &#39;124&#39;, &#39;128&#39;, &#39;132&#39;, &#39;136&#39;, &#39;140&#39;, &#39;144&#39;, &#39;149&#39;, &#39;153&#39;, &#39;157&#39;, &#39;161&#39; or &#39;165&#39;.</value>
        [DataMember(Name="validAutoChannels", EmitDefaultValue=false)]
        public List<int?> ValidAutoChannels { get; set; }
        /// <summary>
        /// Sets channel width (MHz) for 5Ghz band. Can be one of &#39;auto&#39;, &#39;20&#39;, &#39;40&#39; or &#39;80&#39;.
        /// </summary>
        /// <value>Sets channel width (MHz) for 5Ghz band. Can be one of &#39;auto&#39;, &#39;20&#39;, &#39;40&#39; or &#39;80&#39;.</value>
        [DataMember(Name="channelWidth", EmitDefaultValue=false)]
        public string ChannelWidth { get; set; }
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
            sb.Append("class FiveGhzSettings1 {\n");
            sb.Append("  MaxPower: ").Append(MaxPower).Append("\n");
            sb.Append("  MinPower: ").Append(MinPower).Append("\n");
            sb.Append("  MinBitrate: ").Append(MinBitrate).Append("\n");
            sb.Append("  ValidAutoChannels: ").Append(ValidAutoChannels).Append("\n");
            sb.Append("  ChannelWidth: ").Append(ChannelWidth).Append("\n");
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
            return Equals(obj as FiveGhzSettings1);
        }

        /// <summary>
        /// Returns true if FiveGhzSettings1 instances are equal
        /// </summary>
        /// <param name="other">Instance of FiveGhzSettings1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FiveGhzSettings1 other)
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
						  ChannelWidth == other.ChannelWidth ||
						  ChannelWidth != null &&
						  ChannelWidth.Equals(other.ChannelWidth)
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
                if (ChannelWidth != null)
                    hash = hash * 59 + ChannelWidth.GetHashCode();
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
