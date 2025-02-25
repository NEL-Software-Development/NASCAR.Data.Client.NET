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
    /// VehicleDetails
    /// </summary>
    [DataContract]
        public partial class VehicleDetails :  IEquatable<VehicleDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleDetails" /> class.
        /// </summary>
        /// <param name="season">Race season.</param>
        /// <param name="seriesId">Series.</param>
        /// <param name="vehicleNumber">Vehicle Number.</param>
        /// <param name="badge">URL to badge logo.</param>
        /// <param name="results">Season race results.</param>
        public VehicleDetails(int? season = default(int?), int? seriesId = default(int?), string vehicleNumber = default(string), string badge = default(string), Collection<RaceResultSummary> results = default(Collection<RaceResultSummary>))
        {
            this.Season = season;
            this.SeriesId = seriesId;
            this.VehicleNumber = vehicleNumber;
            this.Badge = badge;
            this.Results = results;
        }
        
        /// <summary>
        /// Race season
        /// </summary>
        /// <value>Race season</value>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Series
        /// </summary>
        /// <value>Series</value>
        [DataMember(Name="series_id", EmitDefaultValue=false)]
        public int? SeriesId { get; set; }

        /// <summary>
        /// Vehicle Number
        /// </summary>
        /// <value>Vehicle Number</value>
        [DataMember(Name="vehicle_number", EmitDefaultValue=false)]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// URL to badge logo
        /// </summary>
        /// <value>URL to badge logo</value>
        [DataMember(Name="badge", EmitDefaultValue=false)]
        public string Badge { get; set; }

        /// <summary>
        /// Season race results
        /// </summary>
        /// <value>Season race results</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public Collection<RaceResultSummary> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleDetails {\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  SeriesId: ").Append(SeriesId).Append("\n");
            sb.Append("  VehicleNumber: ").Append(VehicleNumber).Append("\n");
            sb.Append("  Badge: ").Append(Badge).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as VehicleDetails);
        }

        /// <summary>
        /// Returns true if VehicleDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of VehicleDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.SeriesId == input.SeriesId ||
                    (this.SeriesId != null &&
                    this.SeriesId.Equals(input.SeriesId))
                ) && 
                (
                    this.VehicleNumber == input.VehicleNumber ||
                    (this.VehicleNumber != null &&
                    this.VehicleNumber.Equals(input.VehicleNumber))
                ) && 
                (
                    this.Badge == input.Badge ||
                    (this.Badge != null &&
                    this.Badge.Equals(input.Badge))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.SeriesId != null)
                    hashCode = hashCode * 59 + this.SeriesId.GetHashCode();
                if (this.VehicleNumber != null)
                    hashCode = hashCode * 59 + this.VehicleNumber.GetHashCode();
                if (this.Badge != null)
                    hashCode = hashCode * 59 + this.Badge.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
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
