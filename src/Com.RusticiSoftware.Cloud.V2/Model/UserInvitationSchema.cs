/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// UserInvitationSchema
    /// </summary>
    [DataContract]
    public partial class UserInvitationSchema :  IEquatable<UserInvitationSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationSchema" /> class.
        /// </summary>
        /// <param name="Email">The email of the user who took an invitation..</param>
        /// <param name="Url">The URL which the user would follow to take the invitation..</param>
        /// <param name="IsStarted">A boolean flag stating if the user has started the invitation..</param>
        /// <param name="Updated">Updated.</param>
        /// <param name="RegistrationId">The id of the registration which was created from the user being invited..</param>
        /// <param name="RegistrationReport">RegistrationReport.</param>
        public UserInvitationSchema(string Email = default(string), string Url = default(string), bool? IsStarted = default(bool?), DateTime? Updated = default(DateTime?), string RegistrationId = default(string), UserInvitationSchemaRegistrationReport RegistrationReport = default(UserInvitationSchemaRegistrationReport))
        {
            this.Email = Email;
            this.Url = Url;
            this.IsStarted = IsStarted;
            this.Updated = Updated;
            this.RegistrationId = RegistrationId;
            this.RegistrationReport = RegistrationReport;
        }
        
        /// <summary>
        /// The email of the user who took an invitation.
        /// </summary>
        /// <value>The email of the user who took an invitation.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The URL which the user would follow to take the invitation.
        /// </summary>
        /// <value>The URL which the user would follow to take the invitation.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// A boolean flag stating if the user has started the invitation.
        /// </summary>
        /// <value>A boolean flag stating if the user has started the invitation.</value>
        [DataMember(Name="isStarted", EmitDefaultValue=false)]
        public bool? IsStarted { get; set; }
        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }
        /// <summary>
        /// The id of the registration which was created from the user being invited.
        /// </summary>
        /// <value>The id of the registration which was created from the user being invited.</value>
        [DataMember(Name="registrationId", EmitDefaultValue=false)]
        public string RegistrationId { get; set; }
        /// <summary>
        /// Gets or Sets RegistrationReport
        /// </summary>
        [DataMember(Name="registrationReport", EmitDefaultValue=false)]
        public UserInvitationSchemaRegistrationReport RegistrationReport { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInvitationSchema {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsStarted: ").Append(IsStarted).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  RegistrationReport: ").Append(RegistrationReport).Append("\n");
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
            return this.Equals(obj as UserInvitationSchema);
        }

        /// <summary>
        /// Returns true if UserInvitationSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of UserInvitationSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInvitationSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.IsStarted == other.IsStarted ||
                    this.IsStarted != null &&
                    this.IsStarted.Equals(other.IsStarted)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) && 
                (
                    this.RegistrationId == other.RegistrationId ||
                    this.RegistrationId != null &&
                    this.RegistrationId.Equals(other.RegistrationId)
                ) && 
                (
                    this.RegistrationReport == other.RegistrationReport ||
                    this.RegistrationReport != null &&
                    this.RegistrationReport.Equals(other.RegistrationReport)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.IsStarted != null)
                    hash = hash * 59 + this.IsStarted.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.RegistrationId != null)
                    hash = hash * 59 + this.RegistrationId.GetHashCode();
                if (this.RegistrationReport != null)
                    hash = hash * 59 + this.RegistrationReport.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
