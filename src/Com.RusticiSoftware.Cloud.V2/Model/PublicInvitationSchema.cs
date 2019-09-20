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
    /// PublicInvitationSchema
    /// </summary>
    [DataContract]
    public partial class PublicInvitationSchema :  IEquatable<PublicInvitationSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicInvitationSchema" /> class.
        /// </summary>
        /// <param name="Id">The invitationId for this invitation..</param>
        /// <param name="CourseId">Course Id for this Invitation..</param>
        /// <param name="AllowLaunch">If true, then new registrations can be created for this dispatch..</param>
        /// <param name="AllowNewRegistrations">If true, then new registrations can be created for this dispatch..</param>
        /// <param name="Url">The launch URL for the invitation.</param>
        /// <param name="CreateDate">The create date for the invitation.</param>
        /// <param name="Updated">Updated.</param>
        /// <param name="PostBack">Specifies a URL for which to post activity and status data in real time as the course is completed.</param>
        /// <param name="ExpirationDate">The date this invitation will expire and can not be launched (formatted yyyyMMddHHmmss in UTC time)..</param>
        /// <param name="RegistrationCap">Integer value that limits the amount of registrations a public invitation can generate. (default to 0).</param>
        /// <param name="RegistrationCount">The count of registrations for this invitation.</param>
        public PublicInvitationSchema(string Id = default(string), string CourseId = default(string), bool? AllowLaunch = default(bool?), bool? AllowNewRegistrations = default(bool?), string Url = default(string), DateTime? CreateDate = default(DateTime?), DateTime? Updated = default(DateTime?), PostBackSchema PostBack = default(PostBackSchema), DateTime? ExpirationDate = default(DateTime?), int? RegistrationCap = 0, int? RegistrationCount = default(int?))
        {
            this.Id = Id;
            this.CourseId = CourseId;
            this.AllowLaunch = AllowLaunch;
            this.AllowNewRegistrations = AllowNewRegistrations;
            this.Url = Url;
            this.CreateDate = CreateDate;
            this.Updated = Updated;
            this.PostBack = PostBack;
            this.ExpirationDate = ExpirationDate;
            // use default value if no "RegistrationCap" provided
            if (RegistrationCap == null)
            {
                this.RegistrationCap = 0;
            }
            else
            {
                this.RegistrationCap = RegistrationCap;
            }
            this.RegistrationCount = RegistrationCount;
        }
        
        /// <summary>
        /// The invitationId for this invitation.
        /// </summary>
        /// <value>The invitationId for this invitation.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Course Id for this Invitation.
        /// </summary>
        /// <value>Course Id for this Invitation.</value>
        [DataMember(Name="courseId", EmitDefaultValue=false)]
        public string CourseId { get; set; }
        /// <summary>
        /// If true, then new registrations can be created for this dispatch.
        /// </summary>
        /// <value>If true, then new registrations can be created for this dispatch.</value>
        [DataMember(Name="allowLaunch", EmitDefaultValue=false)]
        public bool? AllowLaunch { get; set; }
        /// <summary>
        /// If true, then new registrations can be created for this dispatch.
        /// </summary>
        /// <value>If true, then new registrations can be created for this dispatch.</value>
        [DataMember(Name="allowNewRegistrations", EmitDefaultValue=false)]
        public bool? AllowNewRegistrations { get; set; }
        /// <summary>
        /// The launch URL for the invitation
        /// </summary>
        /// <value>The launch URL for the invitation</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// The create date for the invitation
        /// </summary>
        /// <value>The create date for the invitation</value>
        [DataMember(Name="createDate", EmitDefaultValue=false)]
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }
        /// <summary>
        /// Specifies a URL for which to post activity and status data in real time as the course is completed
        /// </summary>
        /// <value>Specifies a URL for which to post activity and status data in real time as the course is completed</value>
        [DataMember(Name="postBack", EmitDefaultValue=false)]
        public PostBackSchema PostBack { get; set; }
        /// <summary>
        /// The date this invitation will expire and can not be launched (formatted yyyyMMddHHmmss in UTC time).
        /// </summary>
        /// <value>The date this invitation will expire and can not be launched (formatted yyyyMMddHHmmss in UTC time).</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public DateTime? ExpirationDate { get; set; }
        /// <summary>
        /// Integer value that limits the amount of registrations a public invitation can generate.
        /// </summary>
        /// <value>Integer value that limits the amount of registrations a public invitation can generate.</value>
        [DataMember(Name="registrationCap", EmitDefaultValue=false)]
        public int? RegistrationCap { get; set; }
        /// <summary>
        /// The count of registrations for this invitation
        /// </summary>
        /// <value>The count of registrations for this invitation</value>
        [DataMember(Name="registrationCount", EmitDefaultValue=false)]
        public int? RegistrationCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicInvitationSchema {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CourseId: ").Append(CourseId).Append("\n");
            sb.Append("  AllowLaunch: ").Append(AllowLaunch).Append("\n");
            sb.Append("  AllowNewRegistrations: ").Append(AllowNewRegistrations).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  PostBack: ").Append(PostBack).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  RegistrationCap: ").Append(RegistrationCap).Append("\n");
            sb.Append("  RegistrationCount: ").Append(RegistrationCount).Append("\n");
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
            return this.Equals(obj as PublicInvitationSchema);
        }

        /// <summary>
        /// Returns true if PublicInvitationSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of PublicInvitationSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicInvitationSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CourseId == other.CourseId ||
                    this.CourseId != null &&
                    this.CourseId.Equals(other.CourseId)
                ) && 
                (
                    this.AllowLaunch == other.AllowLaunch ||
                    this.AllowLaunch != null &&
                    this.AllowLaunch.Equals(other.AllowLaunch)
                ) && 
                (
                    this.AllowNewRegistrations == other.AllowNewRegistrations ||
                    this.AllowNewRegistrations != null &&
                    this.AllowNewRegistrations.Equals(other.AllowNewRegistrations)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.CreateDate == other.CreateDate ||
                    this.CreateDate != null &&
                    this.CreateDate.Equals(other.CreateDate)
                ) && 
                (
                    this.Updated == other.Updated ||
                    this.Updated != null &&
                    this.Updated.Equals(other.Updated)
                ) && 
                (
                    this.PostBack == other.PostBack ||
                    this.PostBack != null &&
                    this.PostBack.Equals(other.PostBack)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.RegistrationCap == other.RegistrationCap ||
                    this.RegistrationCap != null &&
                    this.RegistrationCap.Equals(other.RegistrationCap)
                ) && 
                (
                    this.RegistrationCount == other.RegistrationCount ||
                    this.RegistrationCount != null &&
                    this.RegistrationCount.Equals(other.RegistrationCount)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.CourseId != null)
                    hash = hash * 59 + this.CourseId.GetHashCode();
                if (this.AllowLaunch != null)
                    hash = hash * 59 + this.AllowLaunch.GetHashCode();
                if (this.AllowNewRegistrations != null)
                    hash = hash * 59 + this.AllowNewRegistrations.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.CreateDate != null)
                    hash = hash * 59 + this.CreateDate.GetHashCode();
                if (this.Updated != null)
                    hash = hash * 59 + this.Updated.GetHashCode();
                if (this.PostBack != null)
                    hash = hash * 59 + this.PostBack.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.RegistrationCap != null)
                    hash = hash * 59 + this.RegistrationCap.GetHashCode();
                if (this.RegistrationCount != null)
                    hash = hash * 59 + this.RegistrationCount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
