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
    /// RaceResultSummary
    /// </summary>
    [DataContract]
        public partial class RaceResultSummary :  IEquatable<RaceResultSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RaceResultSummary" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="raceName">raceName.</param>
        /// <param name="vehicleNumber">vehicleNumber.</param>
        /// <param name="finishPosition">finishPosition.</param>
        /// <param name="bestTime">bestTime.</param>
        /// <param name="bestSpeed">bestSpeed.</param>
        /// <param name="deltaNextTime">deltaNextTime.</param>
        /// <param name="deltaNextLaps">deltaNextLaps.</param>
        /// <param name="deltaLeaderTime">deltaLeaderTime.</param>
        /// <param name="deltaLeaderLaps">deltaLeaderLaps.</param>
        /// <param name="bestLap">bestLap.</param>
        /// <param name="laps">laps.</param>
        public RaceResultSummary(DateTimeOffset? date = default(DateTimeOffset?), string raceName = default(string), string vehicleNumber = default(string), int? finishPosition = default(int?), int? bestTime = default(int?), double? bestSpeed = default(double?), int? deltaNextTime = default(int?), int? deltaNextLaps = default(int?), int? deltaLeaderTime = default(int?), int? deltaLeaderLaps = default(int?), int? bestLap = default(int?), int? laps = default(int?))
        {
            this.Date = date;
            this.RaceName = raceName;
            this.VehicleNumber = vehicleNumber;
            this.FinishPosition = finishPosition;
            this.BestTime = bestTime;
            this.BestSpeed = bestSpeed;
            this.DeltaNextTime = deltaNextTime;
            this.DeltaNextLaps = deltaNextLaps;
            this.DeltaLeaderTime = deltaLeaderTime;
            this.DeltaLeaderLaps = deltaLeaderLaps;
            this.BestLap = bestLap;
            this.Laps = laps;
        }
        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Gets or Sets RaceName
        /// </summary>
        [DataMember(Name="race_name", EmitDefaultValue=false)]
        public string RaceName { get; set; }

        /// <summary>
        /// Gets or Sets VehicleNumber
        /// </summary>
        [DataMember(Name="vehicle_number", EmitDefaultValue=false)]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// Gets or Sets FinishPosition
        /// </summary>
        [DataMember(Name="finish_position", EmitDefaultValue=false)]
        public int? FinishPosition { get; set; }

        /// <summary>
        /// Gets or Sets BestTime
        /// </summary>
        [DataMember(Name="best_time", EmitDefaultValue=false)]
        public int? BestTime { get; set; }

        /// <summary>
        /// Gets or Sets BestSpeed
        /// </summary>
        [DataMember(Name="best_speed", EmitDefaultValue=false)]
        public double? BestSpeed { get; set; }

        /// <summary>
        /// Gets or Sets DeltaNextTime
        /// </summary>
        [DataMember(Name="delta_next_time", EmitDefaultValue=false)]
        public int? DeltaNextTime { get; set; }

        /// <summary>
        /// Gets or Sets DeltaNextLaps
        /// </summary>
        [DataMember(Name="delta_next_laps", EmitDefaultValue=false)]
        public int? DeltaNextLaps { get; set; }

        /// <summary>
        /// Gets or Sets DeltaLeaderTime
        /// </summary>
        [DataMember(Name="delta_leader_time", EmitDefaultValue=false)]
        public int? DeltaLeaderTime { get; set; }

        /// <summary>
        /// Gets or Sets DeltaLeaderLaps
        /// </summary>
        [DataMember(Name="delta_leader_laps", EmitDefaultValue=false)]
        public int? DeltaLeaderLaps { get; set; }

        /// <summary>
        /// Gets or Sets BestLap
        /// </summary>
        [DataMember(Name="best_lap", EmitDefaultValue=false)]
        public int? BestLap { get; set; }

        /// <summary>
        /// Gets or Sets Laps
        /// </summary>
        [DataMember(Name="laps", EmitDefaultValue=false)]
        public int? Laps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RaceResultSummary {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  RaceName: ").Append(RaceName).Append("\n");
            sb.Append("  VehicleNumber: ").Append(VehicleNumber).Append("\n");
            sb.Append("  FinishPosition: ").Append(FinishPosition).Append("\n");
            sb.Append("  BestTime: ").Append(BestTime).Append("\n");
            sb.Append("  BestSpeed: ").Append(BestSpeed).Append("\n");
            sb.Append("  DeltaNextTime: ").Append(DeltaNextTime).Append("\n");
            sb.Append("  DeltaNextLaps: ").Append(DeltaNextLaps).Append("\n");
            sb.Append("  DeltaLeaderTime: ").Append(DeltaLeaderTime).Append("\n");
            sb.Append("  DeltaLeaderLaps: ").Append(DeltaLeaderLaps).Append("\n");
            sb.Append("  BestLap: ").Append(BestLap).Append("\n");
            sb.Append("  Laps: ").Append(Laps).Append("\n");
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
            return this.Equals(input as RaceResultSummary);
        }

        /// <summary>
        /// Returns true if RaceResultSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of RaceResultSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RaceResultSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.RaceName == input.RaceName ||
                    (this.RaceName != null &&
                    this.RaceName.Equals(input.RaceName))
                ) && 
                (
                    this.VehicleNumber == input.VehicleNumber ||
                    (this.VehicleNumber != null &&
                    this.VehicleNumber.Equals(input.VehicleNumber))
                ) && 
                (
                    this.FinishPosition == input.FinishPosition ||
                    (this.FinishPosition != null &&
                    this.FinishPosition.Equals(input.FinishPosition))
                ) && 
                (
                    this.BestTime == input.BestTime ||
                    (this.BestTime != null &&
                    this.BestTime.Equals(input.BestTime))
                ) && 
                (
                    this.BestSpeed == input.BestSpeed ||
                    (this.BestSpeed != null &&
                    this.BestSpeed.Equals(input.BestSpeed))
                ) && 
                (
                    this.DeltaNextTime == input.DeltaNextTime ||
                    (this.DeltaNextTime != null &&
                    this.DeltaNextTime.Equals(input.DeltaNextTime))
                ) && 
                (
                    this.DeltaNextLaps == input.DeltaNextLaps ||
                    (this.DeltaNextLaps != null &&
                    this.DeltaNextLaps.Equals(input.DeltaNextLaps))
                ) && 
                (
                    this.DeltaLeaderTime == input.DeltaLeaderTime ||
                    (this.DeltaLeaderTime != null &&
                    this.DeltaLeaderTime.Equals(input.DeltaLeaderTime))
                ) && 
                (
                    this.DeltaLeaderLaps == input.DeltaLeaderLaps ||
                    (this.DeltaLeaderLaps != null &&
                    this.DeltaLeaderLaps.Equals(input.DeltaLeaderLaps))
                ) && 
                (
                    this.BestLap == input.BestLap ||
                    (this.BestLap != null &&
                    this.BestLap.Equals(input.BestLap))
                ) && 
                (
                    this.Laps == input.Laps ||
                    (this.Laps != null &&
                    this.Laps.Equals(input.Laps))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.RaceName != null)
                    hashCode = hashCode * 59 + this.RaceName.GetHashCode();
                if (this.VehicleNumber != null)
                    hashCode = hashCode * 59 + this.VehicleNumber.GetHashCode();
                if (this.FinishPosition != null)
                    hashCode = hashCode * 59 + this.FinishPosition.GetHashCode();
                if (this.BestTime != null)
                    hashCode = hashCode * 59 + this.BestTime.GetHashCode();
                if (this.BestSpeed != null)
                    hashCode = hashCode * 59 + this.BestSpeed.GetHashCode();
                if (this.DeltaNextTime != null)
                    hashCode = hashCode * 59 + this.DeltaNextTime.GetHashCode();
                if (this.DeltaNextLaps != null)
                    hashCode = hashCode * 59 + this.DeltaNextLaps.GetHashCode();
                if (this.DeltaLeaderTime != null)
                    hashCode = hashCode * 59 + this.DeltaLeaderTime.GetHashCode();
                if (this.DeltaLeaderLaps != null)
                    hashCode = hashCode * 59 + this.DeltaLeaderLaps.GetHashCode();
                if (this.BestLap != null)
                    hashCode = hashCode * 59 + this.BestLap.GetHashCode();
                if (this.Laps != null)
                    hashCode = hashCode * 59 + this.Laps.GetHashCode();
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
