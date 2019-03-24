/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0 beta
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// SettingMetadata
    /// </summary>
    [DataContract]
    public partial class SettingMetadata :  IEquatable<SettingMetadata>
    {
        /// <summary>
        /// Does this setting apply to only single-SCO packages, only multi-SCO, or either?
        /// </summary>
        /// <value>Does this setting apply to only single-SCO packages, only multi-SCO, or either?</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LearningStandardVariantEnum
        {
            
            /// <summary>
            /// Enum SingleScoOnly for "singleScoOnly"
            /// </summary>
            [EnumMember(Value = "singleScoOnly")]
            SingleScoOnly,
            
            /// <summary>
            /// Enum MultiScoOnly for "multiScoOnly"
            /// </summary>
            [EnumMember(Value = "multiScoOnly")]
            MultiScoOnly,
            
            /// <summary>
            /// Enum Either for "either"
            /// </summary>
            [EnumMember(Value = "either")]
            Either
        }

        /// <summary>
        /// Does this setting apply to only single-SCO packages, only multi-SCO, or either?
        /// </summary>
        /// <value>Does this setting apply to only single-SCO packages, only multi-SCO, or either?</value>
        [DataMember(Name="learningStandardVariant", EmitDefaultValue=false)]
        public LearningStandardVariantEnum? LearningStandardVariant { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingMetadata" /> class.
        /// </summary>
        /// <param name="_Default">Default value of this setting.</param>
        /// <param name="DataType">The data type of this setting.</param>
        /// <param name="SettingDescription">description of this setting.</param>
        /// <param name="Level">The level this setting will be applied at, which limits where it can be set. For example, WebPathToContentRoot is applied at the application level, so it&#39;s not valid to set it for a registration..</param>
        /// <param name="LearningStandards">The list of learning standards this setting applies to. If not present, this setting is not limited to certain learning standards..</param>
        /// <param name="LearningStandardVariant">Does this setting apply to only single-SCO packages, only multi-SCO, or either? (default to &quot;either&quot;).</param>
        /// <param name="Fallback">A setting that will be used instead of this setting if no value is provided for this setting (This is similar to a default, except that the the value of another setting is being used instead of a fixed default value)..</param>
        /// <param name="ValidValues">For settings with a fixed list of valid values, the list of those values.</param>
        public SettingMetadata(string _Default = null, string DataType = null, string SettingDescription = null, string Level = null, List<string> LearningStandards = null, LearningStandardVariantEnum? LearningStandardVariant = null, string Fallback = null, List<SettingMetadataValidValues> ValidValues = null)
        {
            this._Default = _Default;
            this.DataType = DataType;
            this.SettingDescription = SettingDescription;
            this.Level = Level;
            this.LearningStandards = LearningStandards;
            // use default value if no "LearningStandardVariant" provided
            if (LearningStandardVariant == null)
            {
                this.LearningStandardVariant = "either";
            }
            else
            {
                this.LearningStandardVariant = LearningStandardVariant;
            }
            this.Fallback = Fallback;
            this.ValidValues = ValidValues;
        }
        
        /// <summary>
        /// Default value of this setting
        /// </summary>
        /// <value>Default value of this setting</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public string _Default { get; set; }
        /// <summary>
        /// The data type of this setting
        /// </summary>
        /// <value>The data type of this setting</value>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public string DataType { get; set; }
        /// <summary>
        /// description of this setting
        /// </summary>
        /// <value>description of this setting</value>
        [DataMember(Name="settingDescription", EmitDefaultValue=false)]
        public string SettingDescription { get; set; }
        /// <summary>
        /// The level this setting will be applied at, which limits where it can be set. For example, WebPathToContentRoot is applied at the application level, so it&#39;s not valid to set it for a registration.
        /// </summary>
        /// <value>The level this setting will be applied at, which limits where it can be set. For example, WebPathToContentRoot is applied at the application level, so it&#39;s not valid to set it for a registration.</value>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }
        /// <summary>
        /// The list of learning standards this setting applies to. If not present, this setting is not limited to certain learning standards.
        /// </summary>
        /// <value>The list of learning standards this setting applies to. If not present, this setting is not limited to certain learning standards.</value>
        [DataMember(Name="learningStandards", EmitDefaultValue=false)]
        public List<string> LearningStandards { get; set; }
        /// <summary>
        /// A setting that will be used instead of this setting if no value is provided for this setting (This is similar to a default, except that the the value of another setting is being used instead of a fixed default value).
        /// </summary>
        /// <value>A setting that will be used instead of this setting if no value is provided for this setting (This is similar to a default, except that the the value of another setting is being used instead of a fixed default value).</value>
        [DataMember(Name="fallback", EmitDefaultValue=false)]
        public string Fallback { get; set; }
        /// <summary>
        /// For settings with a fixed list of valid values, the list of those values
        /// </summary>
        /// <value>For settings with a fixed list of valid values, the list of those values</value>
        [DataMember(Name="validValues", EmitDefaultValue=false)]
        public List<SettingMetadataValidValues> ValidValues { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingMetadata {\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  SettingDescription: ").Append(SettingDescription).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  LearningStandards: ").Append(LearningStandards).Append("\n");
            sb.Append("  LearningStandardVariant: ").Append(LearningStandardVariant).Append("\n");
            sb.Append("  Fallback: ").Append(Fallback).Append("\n");
            sb.Append("  ValidValues: ").Append(ValidValues).Append("\n");
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
            return this.Equals(obj as SettingMetadata);
        }

        /// <summary>
        /// Returns true if SettingMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of SettingMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
                ) && 
                (
                    this.DataType == other.DataType ||
                    this.DataType != null &&
                    this.DataType.Equals(other.DataType)
                ) && 
                (
                    this.SettingDescription == other.SettingDescription ||
                    this.SettingDescription != null &&
                    this.SettingDescription.Equals(other.SettingDescription)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.LearningStandards == other.LearningStandards ||
                    this.LearningStandards != null &&
                    this.LearningStandards.SequenceEqual(other.LearningStandards)
                ) && 
                (
                    this.LearningStandardVariant == other.LearningStandardVariant ||
                    this.LearningStandardVariant != null &&
                    this.LearningStandardVariant.Equals(other.LearningStandardVariant)
                ) && 
                (
                    this.Fallback == other.Fallback ||
                    this.Fallback != null &&
                    this.Fallback.Equals(other.Fallback)
                ) && 
                (
                    this.ValidValues == other.ValidValues ||
                    this.ValidValues != null &&
                    this.ValidValues.SequenceEqual(other.ValidValues)
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
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                if (this.DataType != null)
                    hash = hash * 59 + this.DataType.GetHashCode();
                if (this.SettingDescription != null)
                    hash = hash * 59 + this.SettingDescription.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.LearningStandards != null)
                    hash = hash * 59 + this.LearningStandards.GetHashCode();
                if (this.LearningStandardVariant != null)
                    hash = hash * 59 + this.LearningStandardVariant.GetHashCode();
                if (this.Fallback != null)
                    hash = hash * 59 + this.Fallback.GetHashCode();
                if (this.ValidValues != null)
                    hash = hash * 59 + this.ValidValues.GetHashCode();
                return hash;
            }
        }
    }

}
