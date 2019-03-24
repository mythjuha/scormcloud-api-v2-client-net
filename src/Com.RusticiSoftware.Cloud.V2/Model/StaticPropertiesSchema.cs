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
    /// StaticPropertiesSchema
    /// </summary>
    [DataContract]
    public partial class StaticPropertiesSchema :  IEquatable<StaticPropertiesSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticPropertiesSchema" /> class.
        /// </summary>
        /// <param name="CompletionThreshold">CompletionThreshold.</param>
        /// <param name="LaunchData">LaunchData.</param>
        /// <param name="MaxTimeAllowed">MaxTimeAllowed.</param>
        /// <param name="ScaledPassingScore">ScaledPassingScore.</param>
        /// <param name="ScaledPassingScoreUsed">ScaledPassingScoreUsed.</param>
        /// <param name="TimeLimitAction">TimeLimitAction.</param>
        public StaticPropertiesSchema(string CompletionThreshold = null, string LaunchData = null, string MaxTimeAllowed = null, double? ScaledPassingScore = null, bool? ScaledPassingScoreUsed = null, string TimeLimitAction = null)
        {
            this.CompletionThreshold = CompletionThreshold;
            this.LaunchData = LaunchData;
            this.MaxTimeAllowed = MaxTimeAllowed;
            this.ScaledPassingScore = ScaledPassingScore;
            this.ScaledPassingScoreUsed = ScaledPassingScoreUsed;
            this.TimeLimitAction = TimeLimitAction;
        }
        
        /// <summary>
        /// Gets or Sets CompletionThreshold
        /// </summary>
        [DataMember(Name="completionThreshold", EmitDefaultValue=false)]
        public string CompletionThreshold { get; set; }
        /// <summary>
        /// Gets or Sets LaunchData
        /// </summary>
        [DataMember(Name="launchData", EmitDefaultValue=false)]
        public string LaunchData { get; set; }
        /// <summary>
        /// Gets or Sets MaxTimeAllowed
        /// </summary>
        [DataMember(Name="maxTimeAllowed", EmitDefaultValue=false)]
        public string MaxTimeAllowed { get; set; }
        /// <summary>
        /// Gets or Sets ScaledPassingScore
        /// </summary>
        [DataMember(Name="scaledPassingScore", EmitDefaultValue=false)]
        public double? ScaledPassingScore { get; set; }
        /// <summary>
        /// Gets or Sets ScaledPassingScoreUsed
        /// </summary>
        [DataMember(Name="scaledPassingScoreUsed", EmitDefaultValue=false)]
        public bool? ScaledPassingScoreUsed { get; set; }
        /// <summary>
        /// Gets or Sets TimeLimitAction
        /// </summary>
        [DataMember(Name="timeLimitAction", EmitDefaultValue=false)]
        public string TimeLimitAction { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StaticPropertiesSchema {\n");
            sb.Append("  CompletionThreshold: ").Append(CompletionThreshold).Append("\n");
            sb.Append("  LaunchData: ").Append(LaunchData).Append("\n");
            sb.Append("  MaxTimeAllowed: ").Append(MaxTimeAllowed).Append("\n");
            sb.Append("  ScaledPassingScore: ").Append(ScaledPassingScore).Append("\n");
            sb.Append("  ScaledPassingScoreUsed: ").Append(ScaledPassingScoreUsed).Append("\n");
            sb.Append("  TimeLimitAction: ").Append(TimeLimitAction).Append("\n");
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
            return this.Equals(obj as StaticPropertiesSchema);
        }

        /// <summary>
        /// Returns true if StaticPropertiesSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of StaticPropertiesSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaticPropertiesSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompletionThreshold == other.CompletionThreshold ||
                    this.CompletionThreshold != null &&
                    this.CompletionThreshold.Equals(other.CompletionThreshold)
                ) && 
                (
                    this.LaunchData == other.LaunchData ||
                    this.LaunchData != null &&
                    this.LaunchData.Equals(other.LaunchData)
                ) && 
                (
                    this.MaxTimeAllowed == other.MaxTimeAllowed ||
                    this.MaxTimeAllowed != null &&
                    this.MaxTimeAllowed.Equals(other.MaxTimeAllowed)
                ) && 
                (
                    this.ScaledPassingScore == other.ScaledPassingScore ||
                    this.ScaledPassingScore != null &&
                    this.ScaledPassingScore.Equals(other.ScaledPassingScore)
                ) && 
                (
                    this.ScaledPassingScoreUsed == other.ScaledPassingScoreUsed ||
                    this.ScaledPassingScoreUsed != null &&
                    this.ScaledPassingScoreUsed.Equals(other.ScaledPassingScoreUsed)
                ) && 
                (
                    this.TimeLimitAction == other.TimeLimitAction ||
                    this.TimeLimitAction != null &&
                    this.TimeLimitAction.Equals(other.TimeLimitAction)
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
                if (this.CompletionThreshold != null)
                    hash = hash * 59 + this.CompletionThreshold.GetHashCode();
                if (this.LaunchData != null)
                    hash = hash * 59 + this.LaunchData.GetHashCode();
                if (this.MaxTimeAllowed != null)
                    hash = hash * 59 + this.MaxTimeAllowed.GetHashCode();
                if (this.ScaledPassingScore != null)
                    hash = hash * 59 + this.ScaledPassingScore.GetHashCode();
                if (this.ScaledPassingScoreUsed != null)
                    hash = hash * 59 + this.ScaledPassingScoreUsed.GetHashCode();
                if (this.TimeLimitAction != null)
                    hash = hash * 59 + this.TimeLimitAction.GetHashCode();
                return hash;
            }
        }
    }

}
