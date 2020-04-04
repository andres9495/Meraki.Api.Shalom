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
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// RenewOrganizationLicensesSeats
	/// </summary>
	[DataContract]
    public partial class RenewOrganizationLicensesSeats :  IEquatable<RenewOrganizationLicensesSeats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewOrganizationLicensesSeats" /> class.
        /// </summary>
        [JsonConstructor]
        protected RenewOrganizationLicensesSeats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewOrganizationLicensesSeats" /> class.
        /// </summary>
        /// <param name="LicenseIdToRenew">The ID of the SM license to renew. This license must already be assigned to an SM network (required).</param>
        /// <param name="UnusedLicenseId">The SM license to use to renew the seats on &#39;licenseIdToRenew&#39;. This license must have at least as many seats available as there are seats on &#39;licenseIdToRenew&#39; (required).</param>
        public RenewOrganizationLicensesSeats(string LicenseIdToRenew = default, string UnusedLicenseId = default)
        {
            // to ensure "LicenseIdToRenew" is required (not null)
            if (LicenseIdToRenew == null)
            {
                throw new InvalidDataException("LicenseIdToRenew is a required property for RenewOrganizationLicensesSeats and cannot be null");
            }
            else
            {
                this.LicenseIdToRenew = LicenseIdToRenew;
            }
            // to ensure "UnusedLicenseId" is required (not null)
            if (UnusedLicenseId == null)
            {
                throw new InvalidDataException("UnusedLicenseId is a required property for RenewOrganizationLicensesSeats and cannot be null");
            }
            else
            {
                this.UnusedLicenseId = UnusedLicenseId;
            }
        }

        /// <summary>
        /// The ID of the SM license to renew. This license must already be assigned to an SM network
        /// </summary>
        /// <value>The ID of the SM license to renew. This license must already be assigned to an SM network</value>
        [DataMember(Name="licenseIdToRenew", EmitDefaultValue=false)]
        public string LicenseIdToRenew { get; set; }
        /// <summary>
        /// The SM license to use to renew the seats on &#39;licenseIdToRenew&#39;. This license must have at least as many seats available as there are seats on &#39;licenseIdToRenew&#39;
        /// </summary>
        /// <value>The SM license to use to renew the seats on &#39;licenseIdToRenew&#39;. This license must have at least as many seats available as there are seats on &#39;licenseIdToRenew&#39;</value>
        [DataMember(Name="unusedLicenseId", EmitDefaultValue=false)]
        public string UnusedLicenseId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenewOrganizationLicensesSeats {\n");
            sb.Append("  LicenseIdToRenew: ").Append(LicenseIdToRenew).Append("\n");
            sb.Append("  UnusedLicenseId: ").Append(UnusedLicenseId).Append("\n");
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
            return Equals(obj as RenewOrganizationLicensesSeats);
        }

        /// <summary>
        /// Returns true if RenewOrganizationLicensesSeats instances are equal
        /// </summary>
        /// <param name="other">Instance of RenewOrganizationLicensesSeats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenewOrganizationLicensesSeats other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  LicenseIdToRenew == other.LicenseIdToRenew ||
						  LicenseIdToRenew != null &&
						  LicenseIdToRenew.Equals(other.LicenseIdToRenew)
					 ) &&
					 (
						  UnusedLicenseId == other.UnusedLicenseId ||
						  UnusedLicenseId != null &&
						  UnusedLicenseId.Equals(other.UnusedLicenseId)
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
                if (LicenseIdToRenew != null)
                    hash = hash * 59 + LicenseIdToRenew.GetHashCode();
                if (UnusedLicenseId != null)
                    hash = hash * 59 + UnusedLicenseId.GetHashCode();
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
