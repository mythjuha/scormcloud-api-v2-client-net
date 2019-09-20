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
    /// MetadataSchema
    /// </summary>
    [DataContract]
    public partial class MetadataSchema :  IEquatable<MetadataSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSchema" /> class.
        /// </summary>
        /// <param name="Title">Title.</param>
        /// <param name="TitleLanguage">TitleLanguage.</param>
        /// <param name="Description">Description.</param>
        /// <param name="DescriptionLanguage">DescriptionLanguage.</param>
        /// <param name="Duration">Duration.</param>
        /// <param name="Typicaltime">Typicaltime.</param>
        /// <param name="Keywords">Keywords.</param>
        public MetadataSchema(string Title = default(string), string TitleLanguage = default(string), string Description = default(string), string DescriptionLanguage = default(string), string Duration = default(string), string Typicaltime = default(string), List<string> Keywords = default(List<string>))
        {
            this.Title = Title;
            this.TitleLanguage = TitleLanguage;
            this.Description = Description;
            this.DescriptionLanguage = DescriptionLanguage;
            this.Duration = Duration;
            this.Typicaltime = Typicaltime;
            this.Keywords = Keywords;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets TitleLanguage
        /// </summary>
        [DataMember(Name="titleLanguage", EmitDefaultValue=false)]
        public string TitleLanguage { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets DescriptionLanguage
        /// </summary>
        [DataMember(Name="descriptionLanguage", EmitDefaultValue=false)]
        public string DescriptionLanguage { get; set; }
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }
        /// <summary>
        /// Gets or Sets Typicaltime
        /// </summary>
        [DataMember(Name="typicaltime", EmitDefaultValue=false)]
        public string Typicaltime { get; set; }
        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataSchema {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleLanguage: ").Append(TitleLanguage).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DescriptionLanguage: ").Append(DescriptionLanguage).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Typicaltime: ").Append(Typicaltime).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
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
            return this.Equals(obj as MetadataSchema);
        }

        /// <summary>
        /// Returns true if MetadataSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of MetadataSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.TitleLanguage == other.TitleLanguage ||
                    this.TitleLanguage != null &&
                    this.TitleLanguage.Equals(other.TitleLanguage)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DescriptionLanguage == other.DescriptionLanguage ||
                    this.DescriptionLanguage != null &&
                    this.DescriptionLanguage.Equals(other.DescriptionLanguage)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Typicaltime == other.Typicaltime ||
                    this.Typicaltime != null &&
                    this.Typicaltime.Equals(other.Typicaltime)
                ) && 
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.SequenceEqual(other.Keywords)
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
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.TitleLanguage != null)
                    hash = hash * 59 + this.TitleLanguage.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DescriptionLanguage != null)
                    hash = hash * 59 + this.DescriptionLanguage.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.Typicaltime != null)
                    hash = hash * 59 + this.Typicaltime.GetHashCode();
                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
