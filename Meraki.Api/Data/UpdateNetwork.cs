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
	/// UpdateNetwork
	/// </summary>
	[DataContract]
    public partial class UpdateNetwork :  IEquatable<UpdateNetwork>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateNetwork" /> class.
        /// </summary>
        /// <param name="Name">The name of the network.</param>
        /// <param name="TimeZone">The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;.</param>
        /// <param name="Tags">A space-separated list of tags to be applied to the network.</param>
        /// <param name="DisableMyMerakiCom">Disables the local device status pages (&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://my.meraki.com/&#39;&gt;my.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://ap.meraki.com/&#39;&gt;ap.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://switch.meraki.com/&#39;&gt;switch.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://wired.meraki.com/&#39;&gt;wired.meraki.com&lt;/a&gt;). Optional (defaults to false).</param>
        /// <param name="DisableRemoteStatusPage">Disables access to the device status page (&lt;a target&#x3D;&#39;_blank&#39;&gt;http://[device&#39;s LAN IP])&lt;/a&gt;. Optional. Can only be set if disableMyMerakiCom is set to false.</param>
        /// <param name="EnrollmentString">A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break..</param>
        public UpdateNetwork(string Name = default, string TimeZone = default, string Tags = default, bool? DisableMyMerakiCom = default, bool? DisableRemoteStatusPage = default, string EnrollmentString = default)
        {
            this.Name = Name;
            this.TimeZone = TimeZone;
            this.Tags = Tags;
            this.DisableMyMerakiCom = DisableMyMerakiCom;
            this.DisableRemoteStatusPage = DisableRemoteStatusPage;
            this.EnrollmentString = EnrollmentString;
        }

        /// <summary>
        /// The name of the network
        /// </summary>
        /// <value>The name of the network</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;
        /// </summary>
        /// <value>The timezone of the network. For a list of allowed timezones, please see the &#39;TZ&#39; column in the table in &lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;https://en.wikipedia.org/wiki/List_of_tz_database_time_zones&#39;&gt;this article.&lt;/a&gt;</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }
        /// <summary>
        /// A space-separated list of tags to be applied to the network
        /// </summary>
        /// <value>A space-separated list of tags to be applied to the network</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }
        /// <summary>
        /// Disables the local device status pages (&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://my.meraki.com/&#39;&gt;my.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://ap.meraki.com/&#39;&gt;ap.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://switch.meraki.com/&#39;&gt;switch.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://wired.meraki.com/&#39;&gt;wired.meraki.com&lt;/a&gt;). Optional (defaults to false)
        /// </summary>
        /// <value>Disables the local device status pages (&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://my.meraki.com/&#39;&gt;my.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://ap.meraki.com/&#39;&gt;ap.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://switch.meraki.com/&#39;&gt;switch.meraki.com, &lt;/a&gt;&lt;a target&#x3D;&#39;_blank&#39; href&#x3D;&#39;http://wired.meraki.com/&#39;&gt;wired.meraki.com&lt;/a&gt;). Optional (defaults to false)</value>
        [DataMember(Name="disableMyMerakiCom", EmitDefaultValue=false)]
        public bool? DisableMyMerakiCom { get; set; }
        /// <summary>
        /// Disables access to the device status page (&lt;a target&#x3D;&#39;_blank&#39;&gt;http://[device&#39;s LAN IP])&lt;/a&gt;. Optional. Can only be set if disableMyMerakiCom is set to false
        /// </summary>
        /// <value>Disables access to the device status page (&lt;a target&#x3D;&#39;_blank&#39;&gt;http://[device&#39;s LAN IP])&lt;/a&gt;. Optional. Can only be set if disableMyMerakiCom is set to false</value>
        [DataMember(Name="disableRemoteStatusPage", EmitDefaultValue=false)]
        public bool? DisableRemoteStatusPage { get; set; }
        /// <summary>
        /// A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break.
        /// </summary>
        /// <value>A unique identifier which can be used for device enrollment or easy access through the Meraki SM Registration page or the Self Service Portal. Please note that changing this field may cause existing bookmarks to break.</value>
        [DataMember(Name="enrollmentString", EmitDefaultValue=false)]
        public string EnrollmentString { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNetwork {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DisableMyMerakiCom: ").Append(DisableMyMerakiCom).Append("\n");
            sb.Append("  DisableRemoteStatusPage: ").Append(DisableRemoteStatusPage).Append("\n");
            sb.Append("  EnrollmentString: ").Append(EnrollmentString).Append("\n");
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
            return Equals(obj as UpdateNetwork);
        }

        /// <summary>
        /// Returns true if UpdateNetwork instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateNetwork to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateNetwork other)
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
						  TimeZone == other.TimeZone ||
						  TimeZone != null &&
						  TimeZone.Equals(other.TimeZone)
					 ) &&
					 (
						  Tags == other.Tags ||
						  Tags != null &&
						  Tags.Equals(other.Tags)
					 ) &&
					 (
						  DisableMyMerakiCom == other.DisableMyMerakiCom ||
						  DisableMyMerakiCom != null &&
						  DisableMyMerakiCom.Equals(other.DisableMyMerakiCom)
					 ) &&
					 (
						  DisableRemoteStatusPage == other.DisableRemoteStatusPage ||
						  DisableRemoteStatusPage != null &&
						  DisableRemoteStatusPage.Equals(other.DisableRemoteStatusPage)
					 ) &&
					 (
						  EnrollmentString == other.EnrollmentString ||
						  EnrollmentString != null &&
						  EnrollmentString.Equals(other.EnrollmentString)
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
                if (TimeZone != null)
                    hash = hash * 59 + TimeZone.GetHashCode();
                if (Tags != null)
                    hash = hash * 59 + Tags.GetHashCode();
                if (DisableMyMerakiCom != null)
                    hash = hash * 59 + DisableMyMerakiCom.GetHashCode();
                if (DisableRemoteStatusPage != null)
                    hash = hash * 59 + DisableRemoteStatusPage.GetHashCode();
                if (EnrollmentString != null)
                    hash = hash * 59 + EnrollmentString.GetHashCode();
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
