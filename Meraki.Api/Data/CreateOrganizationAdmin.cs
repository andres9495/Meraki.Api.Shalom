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
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateOrganizationAdmin
	/// </summary>
	[DataContract]
    public partial class CreateOrganizationAdmin :  IEquatable<CreateOrganizationAdmin>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationAdmin" /> class.
        /// </summary>
        [JsonConstructor]
        protected CreateOrganizationAdmin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationAdmin" /> class.
        /// </summary>
        /// <param name="Email">The email of the dashboard administrator. This attribute can not be updated. (required).</param>
        /// <param name="Name">The name of the dashboard administrator (required).</param>
        /// <param name="OrgAccess">OrgAccess (required).</param>
        /// <param name="Tags">The list of tags that the dashboard administrator has privileges on.</param>
        /// <param name="Networks">The list of networks that the dashboard administrator has privileges on.</param>
        public CreateOrganizationAdmin(string Email = default, string Name = default, OrgAccess OrgAccess = default, List<Tag> Tags = default, List<Network> Networks = default)
        {
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for CreateOrganizationAdmin and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for CreateOrganizationAdmin and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "OrgAccess" is required (not null)
            if (OrgAccess == null)
            {
                throw new InvalidDataException("OrgAccess is a required property for CreateOrganizationAdmin and cannot be null");
            }
            else
            {
                this.OrgAccess = OrgAccess;
            }
            this.Tags = Tags;
            this.Networks = Networks;
        }

        /// <summary>
        /// The email of the dashboard administrator. This attribute can not be updated.
        /// </summary>
        /// <value>The email of the dashboard administrator. This attribute can not be updated.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The name of the dashboard administrator
        /// </summary>
        /// <value>The name of the dashboard administrator</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets OrgAccess
        /// </summary>
        [DataMember(Name="orgAccess", EmitDefaultValue=false)]
        public OrgAccess OrgAccess { get; set; }
        /// <summary>
        /// The list of tags that the dashboard administrator has privileges on
        /// </summary>
        /// <value>The list of tags that the dashboard administrator has privileges on</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// The list of networks that the dashboard administrator has privileges on
        /// </summary>
        /// <value>The list of networks that the dashboard administrator has privileges on</value>
        [DataMember(Name="networks", EmitDefaultValue=false)]
        public List<Network> Networks { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrganizationAdmin {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrgAccess: ").Append(OrgAccess).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Networks: ").Append(Networks).Append("\n");
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
            return Equals(obj as CreateOrganizationAdmin);
        }

        /// <summary>
        /// Returns true if CreateOrganizationAdmin instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrganizationAdmin to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrganizationAdmin other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  Email == other.Email ||
						  Email != null &&
						  Email.Equals(other.Email)
					 ) &&
					 (
						  Name == other.Name ||
						  Name != null &&
						  Name.Equals(other.Name)
					 ) &&
					 (
						  OrgAccess == other.OrgAccess ||
						  OrgAccess != null &&
						  OrgAccess.Equals(other.OrgAccess)
					 ) &&
					 (
						  Tags == other.Tags ||
						  Tags != null &&
						  Tags.SequenceEqual(other.Tags)
					 ) &&
					 (
						  Networks == other.Networks ||
						  Networks != null &&
						  Networks.SequenceEqual(other.Networks)
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
                if (Email != null)
                    hash = hash * 59 + Email.GetHashCode();
                if (Name != null)
                    hash = hash * 59 + Name.GetHashCode();
                if (OrgAccess != null)
                    hash = hash * 59 + OrgAccess.GetHashCode();
                if (Tags != null)
                    hash = hash * 59 + Tags.GetHashCode();
                if (Networks != null)
                    hash = hash * 59 + Networks.GetHashCode();
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
