/* 
 * NASCAR.Data.API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
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
using SwaggerDateConverter = NASCAR.Data.Client.Client.SwaggerDateConverter;

namespace NASCAR.Data.Client.Model
{
    /// <summary>
    /// RaceWeekDetails
    /// </summary>
    [DataContract]
        public partial class RaceWeekDetails :  IEquatable<RaceWeekDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RaceWeekDetails" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="races">races.</param>
        public RaceWeekDetails(int? id = default(int?), Collection<RaceDetails> races = default(Collection<RaceDetails>))
        {
            this.Id = id;
            this.Races = races;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Races
        /// </summary>
        [DataMember(Name="races", EmitDefaultValue=false)]
        public Collection<RaceDetails> Races { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RaceWeekDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Races: ").Append(Races).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RaceWeekDetails);
        }

        /// <summary>
        /// Returns true if RaceWeekDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of RaceWeekDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RaceWeekDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Races == input.Races ||
                    this.Races != null &&
                    input.Races != null &&
                    this.Races.SequenceEqual(input.Races)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Races != null)
                    hashCode = hashCode * 59 + this.Races.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
