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
	/// UpdateNetworkSmDevicesTags
	/// </summary>
	[DataContract]
    public partial class UpdateNetworkSmDevicesTags :  IEquatable<UpdateNetworkSmDevicesTags>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSmDevicesTags" /> class.
        /// </summary>
        [JsonConstructor]
        protected UpdateNetworkSmDevicesTags() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetworkSmDevicesTags" /> class.
        /// </summary>
        /// <param name="WifiMacs">The wifiMacs of the devices to be modified..</param>
        /// <param name="Ids">The ids of the devices to be modified..</param>
        /// <param name="Serials">The serials of the devices to be modified..</param>
        /// <param name="Scope">The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be modified..</param>
        /// <param name="Tags">The tags to be added, deleted, or updated. (required).</param>
        /// <param name="UpdateAction">One of add, delete, or update. Only devices that have been modified will be returned. (required).</param>
        public UpdateNetworkSmDevicesTags(string WifiMacs = default, string Ids = default, string Serials = default, string Scope = default, string Tags = default, string UpdateAction = default)
        {
            // to ensure "Tags" is required (not null)
            if (Tags == null)
            {
                throw new InvalidDataException("Tags is a required property for UpdateNetworkSmDevicesTags and cannot be null");
            }
            else
            {
                this.Tags = Tags;
            }
            // to ensure "UpdateAction" is required (not null)
            if (UpdateAction == null)
            {
                throw new InvalidDataException("UpdateAction is a required property for UpdateNetworkSmDevicesTags and cannot be null");
            }
            else
            {
                this.UpdateAction = UpdateAction;
            }
            this.WifiMacs = WifiMacs;
            this.Ids = Ids;
            this.Serials = Serials;
            this.Scope = Scope;
        }

        /// <summary>
        /// The wifiMacs of the devices to be modified.
        /// </summary>
        /// <value>The wifiMacs of the devices to be modified.</value>
        [DataMember(Name="wifiMacs", EmitDefaultValue=false)]
        public string WifiMacs { get; set; }
        /// <summary>
        /// The ids of the devices to be modified.
        /// </summary>
        /// <value>The ids of the devices to be modified.</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public string Ids { get; set; }
        /// <summary>
        /// The serials of the devices to be modified.
        /// </summary>
        /// <value>The serials of the devices to be modified.</value>
        [DataMember(Name="serials", EmitDefaultValue=false)]
        public string Serials { get; set; }
        /// <summary>
        /// The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be modified.
        /// </summary>
        /// <value>The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be modified.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }
        /// <summary>
        /// The tags to be added, deleted, or updated.
        /// </summary>
        /// <value>The tags to be added, deleted, or updated.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }
        /// <summary>
        /// One of add, delete, or update. Only devices that have been modified will be returned.
        /// </summary>
        /// <value>One of add, delete, or update. Only devices that have been modified will be returned.</value>
        [DataMember(Name="updateAction", EmitDefaultValue=false)]
        public string UpdateAction { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetworkSmDevicesTags {\n");
            sb.Append("  WifiMacs: ").Append(WifiMacs).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Serials: ").Append(Serials).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UpdateAction: ").Append(UpdateAction).Append("\n");
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
            return Equals(obj as UpdateNetworkSmDevicesTags);
        }

        /// <summary>
        /// Returns true if UpdateNetworkSmDevicesTags instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetworkSmDevicesTags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetworkSmDevicesTags other)
        {
			// credit: http://stackoverflow.com/a/10454552/677735
			return other == null
					? false
					: (
						  WifiMacs == other.WifiMacs ||
						  WifiMacs != null &&
						  WifiMacs.Equals(other.WifiMacs)
					 ) &&
					 (
						  Ids == other.Ids ||
						  Ids != null &&
						  Ids.Equals(other.Ids)
					 ) &&
					 (
						  Serials == other.Serials ||
						  Serials != null &&
						  Serials.Equals(other.Serials)
					 ) &&
					 (
						  Scope == other.Scope ||
						  Scope != null &&
						  Scope.Equals(other.Scope)
					 ) &&
					 (
						  Tags == other.Tags ||
						  Tags != null &&
						  Tags.Equals(other.Tags)
					 ) &&
					 (
						  UpdateAction == other.UpdateAction ||
						  UpdateAction != null &&
						  UpdateAction.Equals(other.UpdateAction)
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
                if (WifiMacs != null)
                    hash = hash * 59 + WifiMacs.GetHashCode();
                if (Ids != null)
                    hash = hash * 59 + Ids.GetHashCode();
                if (Serials != null)
                    hash = hash * 59 + Serials.GetHashCode();
                if (Scope != null)
                    hash = hash * 59 + Scope.GetHashCode();
                if (Tags != null)
                    hash = hash * 59 + Tags.GetHashCode();
                if (UpdateAction != null)
                    hash = hash * 59 + UpdateAction.GetHashCode();
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
