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
	/// The Bonjour settings for your group policy. Only valid if your network has a wireless configuration.
	/// </summary>
	[DataContract]
    public partial class BonjourForwarding :  IEquatable<BonjourForwarding>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BonjourForwarding" /> class.
        /// </summary>
        /// <param name="Settings">Settings.</param>
        /// <param name="Rules">A list of the Bonjour forwarding rules for your group policy. If &#39;settings&#39; is set to &#39;custom&#39;, at least one rule must be specified..</param>
        public BonjourForwarding(Settings6 Settings = default, List<Rule3> Rules = default)
        {
            this.Settings = Settings;
            this.Rules = Rules;
        }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Settings6 Settings { get; set; }
        /// <summary>
        /// A list of the Bonjour forwarding rules for your group policy. If &#39;settings&#39; is set to &#39;custom&#39;, at least one rule must be specified.
        /// </summary>
        /// <value>A list of the Bonjour forwarding rules for your group policy. If &#39;settings&#39; is set to &#39;custom&#39;, at least one rule must be specified.</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<Rule3> Rules { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BonjourForwarding {\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
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
            return Equals(obj as BonjourForwarding);
        }

        /// <summary>
        /// Returns true if BonjourForwarding instances are equal
        /// </summary>
        /// <param name="other">Instance of BonjourForwarding to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BonjourForwarding other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Settings == other.Settings ||
						  Settings != null &&
						  Settings.Equals(other.Settings)
					 ) &&
					 (
						  Rules == other.Rules ||
						  Rules != null &&
						  Rules.SequenceEqual(other.Rules)
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
                if (Settings != null)
                    hash = hash * 59 + Settings.GetHashCode();
                if (Rules != null)
                    hash = hash * 59 + Rules.GetHashCode();
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
