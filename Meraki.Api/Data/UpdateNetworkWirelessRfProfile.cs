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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkWirelessRfProfile
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkWirelessRfProfile :  IEquatable<UpdateNetworkWirelessRfProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkWirelessRfProfile" /> class.
        /// </summary>
        /// <param name="Name">The name of the new profile. Must be unique..</param>
        /// <param name="ClientBalancingEnabled">Steers client to best available access point. Can be either true or false..</param>
        /// <param name="MinBitrateType">MinBitrateType.</param>
        /// <param name="BandSelectionType">BandSelectionType.</param>
        /// <param name="ApBandSettings">ApBandSettings.</param>
        /// <param name="TwoFourGhzSettings">TwoFourGhzSettings.</param>
        /// <param name="FiveGhzSettings">FiveGhzSettings.</param>
        public UpdateNetworkWirelessRfProfile(string Name = default, bool? ClientBalancingEnabled = default, MinBitrateType1 MinBitrateType = default, BandSelectionType1 BandSelectionType = default, ApBandSettings1 ApBandSettings = default, TwoFourGhzSettings1 TwoFourGhzSettings = default, FiveGhzSettings1 FiveGhzSettings = default)
        {
            this.Name = Name;
            this.ClientBalancingEnabled = ClientBalancingEnabled;
            this.MinBitrateType = MinBitrateType;
            this.BandSelectionType = BandSelectionType;
            this.ApBandSettings = ApBandSettings;
            this.TwoFourGhzSettings = TwoFourGhzSettings;
            this.FiveGhzSettings = FiveGhzSettings;
        }

        /// <summary>
        /// The name of the new profile. Must be unique.
        /// </summary>
        /// <value>The name of the new profile. Must be unique.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Steers client to best available access point. Can be either true or false.
        /// </summary>
        /// <value>Steers client to best available access point. Can be either true or false.</value>
        [DataMember(Name="clientBalancingEnabled", EmitDefaultValue=false)]
        public bool? ClientBalancingEnabled { get; set; }
        /// <summary>
        /// Gets or Sets MinBitrateType
        /// </summary>
        [DataMember(Name="minBitrateType", EmitDefaultValue=false)]
        public MinBitrateType1 MinBitrateType { get; set; }
        /// <summary>
        /// Gets or Sets BandSelectionType
        /// </summary>
        [DataMember(Name="bandSelectionType", EmitDefaultValue=false)]
        public BandSelectionType1 BandSelectionType { get; set; }
        /// <summary>
        /// Gets or Sets ApBandSettings
        /// </summary>
        [DataMember(Name="apBandSettings", EmitDefaultValue=false)]
        public ApBandSettings1 ApBandSettings { get; set; }
        /// <summary>
        /// Gets or Sets TwoFourGhzSettings
        /// </summary>
        [DataMember(Name="twoFourGhzSettings", EmitDefaultValue=false)]
        public TwoFourGhzSettings1 TwoFourGhzSettings { get; set; }
        /// <summary>
        /// Gets or Sets FiveGhzSettings
        /// </summary>
        [DataMember(Name="fiveGhzSettings", EmitDefaultValue=false)]
        public FiveGhzSettings1 FiveGhzSettings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkWirelessRfProfile {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ClientBalancingEnabled: ").Append(ClientBalancingEnabled).Append("\n");
            sb.Append("  MinBitrateType: ").Append(MinBitrateType).Append("\n");
            sb.Append("  BandSelectionType: ").Append(BandSelectionType).Append("\n");
            sb.Append("  ApBandSettings: ").Append(ApBandSettings).Append("\n");
            sb.Append("  TwoFourGhzSettings: ").Append(TwoFourGhzSettings).Append("\n");
            sb.Append("  FiveGhzSettings: ").Append(FiveGhzSettings).Append("\n");
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
            return Equals(obj as UpdateNetworkWirelessRfProfile);
        }

        /// <summary>
        /// Returns true if UpdateNetworkWirelessRfProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkWirelessRfProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkWirelessRfProfile other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Name == other.Name ||
						  Name != null &&
						  Name.Equals(other.Name)
					 ) &&
					 (
						  ClientBalancingEnabled == other.ClientBalancingEnabled ||
						  ClientBalancingEnabled != null &&
						  ClientBalancingEnabled.Equals(other.ClientBalancingEnabled)
					 ) &&
					 (
						  MinBitrateType == other.MinBitrateType ||
						  MinBitrateType != null &&
						  MinBitrateType.Equals(other.MinBitrateType)
					 ) &&
					 (
						  BandSelectionType == other.BandSelectionType ||
						  BandSelectionType != null &&
						  BandSelectionType.Equals(other.BandSelectionType)
					 ) &&
					 (
						  ApBandSettings == other.ApBandSettings ||
						  ApBandSettings != null &&
						  ApBandSettings.Equals(other.ApBandSettings)
					 ) &&
					 (
						  TwoFourGhzSettings == other.TwoFourGhzSettings ||
						  TwoFourGhzSettings != null &&
						  TwoFourGhzSettings.Equals(other.TwoFourGhzSettings)
					 ) &&
					 (
						  FiveGhzSettings == other.FiveGhzSettings ||
						  FiveGhzSettings != null &&
						  FiveGhzSettings.Equals(other.FiveGhzSettings)
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
                if (Name != null)
                    hash = hash * 59 + Name.GetHashCode();
                if (ClientBalancingEnabled != null)
                    hash = hash * 59 + ClientBalancingEnabled.GetHashCode();
                if (MinBitrateType != null)
                    hash = hash * 59 + MinBitrateType.GetHashCode();
                if (BandSelectionType != null)
                    hash = hash * 59 + BandSelectionType.GetHashCode();
                if (ApBandSettings != null)
                    hash = hash * 59 + ApBandSettings.GetHashCode();
                if (TwoFourGhzSettings != null)
                    hash = hash * 59 + TwoFourGhzSettings.GetHashCode();
                if (FiveGhzSettings != null)
                    hash = hash * 59 + FiveGhzSettings.GetHashCode();
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
