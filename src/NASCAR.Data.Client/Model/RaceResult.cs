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
    /// RaceResult
    /// </summary>
    [DataContract]
        public partial class RaceResult :  IEquatable<RaceResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RaceResult" /> class.
        /// </summary>
        /// <param name="finishPosition">Finish position.</param>
        /// <param name="driverName">Driver name.</param>
        /// <param name="vehicleNumber">Vehicle number.</param>
        /// <param name="laps">Number of laps.</param>
        /// <param name="bestTime">Best lap time in milliseconds.</param>
        /// <param name="bestSpeed">Best speed in MPH.</param>
        /// <param name="bestLap">Best lap number.</param>
        /// <param name="lastLapTime">Last lap time.</param>
        /// <param name="deltaNextTime">Number of milliseconds behind the next position.</param>
        /// <param name="deltaNextLaps">Number of laps behind the next position.</param>
        /// <param name="deltaLeaderTime">Number of milliseconds behind the leader.</param>
        /// <param name="deltaLeaderLaps">Number of laps behind the leader.</param>
        /// <param name="onTrack">Is on track.</param>
        /// <param name="status">Status.</param>
        /// <param name="comment">Comment.</param>
        /// <param name="startPosition">Start position.</param>
        public RaceResult(int? finishPosition = default(int?), string driverName = default(string), string vehicleNumber = default(string), int? laps = default(int?), int? bestTime = default(int?), double? bestSpeed = default(double?), int? bestLap = default(int?), int? lastLapTime = default(int?), int? deltaNextTime = default(int?), int? deltaNextLaps = default(int?), int? deltaLeaderTime = default(int?), int? deltaLeaderLaps = default(int?), bool? onTrack = default(bool?), string status = default(string), string comment = default(string), int? startPosition = default(int?))
        {
            this.FinishPosition = finishPosition;
            this.DriverName = driverName;
            this.VehicleNumber = vehicleNumber;
            this.Laps = laps;
            this.BestTime = bestTime;
            this.BestSpeed = bestSpeed;
            this.BestLap = bestLap;
            this.LastLapTime = lastLapTime;
            this.DeltaNextTime = deltaNextTime;
            this.DeltaNextLaps = deltaNextLaps;
            this.DeltaLeaderTime = deltaLeaderTime;
            this.DeltaLeaderLaps = deltaLeaderLaps;
            this.OnTrack = onTrack;
            this.Status = status;
            this.Comment = comment;
            this.StartPosition = startPosition;
        }
        
        /// <summary>
        /// Finish position
        /// </summary>
        /// <value>Finish position</value>
        [DataMember(Name="finish_position", EmitDefaultValue=false)]
        public int? FinishPosition { get; set; }

        /// <summary>
        /// Driver name
        /// </summary>
        /// <value>Driver name</value>
        [DataMember(Name="driver_name", EmitDefaultValue=false)]
        public string DriverName { get; set; }

        /// <summary>
        /// Vehicle number
        /// </summary>
        /// <value>Vehicle number</value>
        [DataMember(Name="vehicle_number", EmitDefaultValue=false)]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// Number of laps
        /// </summary>
        /// <value>Number of laps</value>
        [DataMember(Name="laps", EmitDefaultValue=false)]
        public int? Laps { get; set; }

        /// <summary>
        /// Best lap time in milliseconds
        /// </summary>
        /// <value>Best lap time in milliseconds</value>
        [DataMember(Name="best_time", EmitDefaultValue=false)]
        public int? BestTime { get; set; }

        /// <summary>
        /// Best speed in MPH
        /// </summary>
        /// <value>Best speed in MPH</value>
        [DataMember(Name="best_speed", EmitDefaultValue=false)]
        public double? BestSpeed { get; set; }

        /// <summary>
        /// Best lap number
        /// </summary>
        /// <value>Best lap number</value>
        [DataMember(Name="best_lap", EmitDefaultValue=false)]
        public int? BestLap { get; set; }

        /// <summary>
        /// Last lap time
        /// </summary>
        /// <value>Last lap time</value>
        [DataMember(Name="last_lap_time", EmitDefaultValue=false)]
        public int? LastLapTime { get; set; }

        /// <summary>
        /// Number of milliseconds behind the next position
        /// </summary>
        /// <value>Number of milliseconds behind the next position</value>
        [DataMember(Name="delta_next_time", EmitDefaultValue=false)]
        public int? DeltaNextTime { get; set; }

        /// <summary>
        /// Number of laps behind the next position
        /// </summary>
        /// <value>Number of laps behind the next position</value>
        [DataMember(Name="delta_next_laps", EmitDefaultValue=false)]
        public int? DeltaNextLaps { get; set; }

        /// <summary>
        /// Number of milliseconds behind the leader
        /// </summary>
        /// <value>Number of milliseconds behind the leader</value>
        [DataMember(Name="delta_leader_time", EmitDefaultValue=false)]
        public int? DeltaLeaderTime { get; set; }

        /// <summary>
        /// Number of laps behind the leader
        /// </summary>
        /// <value>Number of laps behind the leader</value>
        [DataMember(Name="delta_leader_laps", EmitDefaultValue=false)]
        public int? DeltaLeaderLaps { get; set; }

        /// <summary>
        /// Is on track
        /// </summary>
        /// <value>Is on track</value>
        [DataMember(Name="on_track", EmitDefaultValue=false)]
        public bool? OnTrack { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        /// <value>Status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        /// <value>Comment</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Start position
        /// </summary>
        /// <value>Start position</value>
        [DataMember(Name="start_position", EmitDefaultValue=false)]
        public int? StartPosition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RaceResult {\n");
            sb.Append("  FinishPosition: ").Append(FinishPosition).Append("\n");
            sb.Append("  DriverName: ").Append(DriverName).Append("\n");
            sb.Append("  VehicleNumber: ").Append(VehicleNumber).Append("\n");
            sb.Append("  Laps: ").Append(Laps).Append("\n");
            sb.Append("  BestTime: ").Append(BestTime).Append("\n");
            sb.Append("  BestSpeed: ").Append(BestSpeed).Append("\n");
            sb.Append("  BestLap: ").Append(BestLap).Append("\n");
            sb.Append("  LastLapTime: ").Append(LastLapTime).Append("\n");
            sb.Append("  DeltaNextTime: ").Append(DeltaNextTime).Append("\n");
            sb.Append("  DeltaNextLaps: ").Append(DeltaNextLaps).Append("\n");
            sb.Append("  DeltaLeaderTime: ").Append(DeltaLeaderTime).Append("\n");
            sb.Append("  DeltaLeaderLaps: ").Append(DeltaLeaderLaps).Append("\n");
            sb.Append("  OnTrack: ").Append(OnTrack).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
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
            return this.Equals(input as RaceResult);
        }

        /// <summary>
        /// Returns true if RaceResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RaceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RaceResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FinishPosition == input.FinishPosition ||
                    (this.FinishPosition != null &&
                    this.FinishPosition.Equals(input.FinishPosition))
                ) && 
                (
                    this.DriverName == input.DriverName ||
                    (this.DriverName != null &&
                    this.DriverName.Equals(input.DriverName))
                ) && 
                (
                    this.VehicleNumber == input.VehicleNumber ||
                    (this.VehicleNumber != null &&
                    this.VehicleNumber.Equals(input.VehicleNumber))
                ) && 
                (
                    this.Laps == input.Laps ||
                    (this.Laps != null &&
                    this.Laps.Equals(input.Laps))
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
                    this.BestLap == input.BestLap ||
                    (this.BestLap != null &&
                    this.BestLap.Equals(input.BestLap))
                ) && 
                (
                    this.LastLapTime == input.LastLapTime ||
                    (this.LastLapTime != null &&
                    this.LastLapTime.Equals(input.LastLapTime))
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
                    this.OnTrack == input.OnTrack ||
                    (this.OnTrack != null &&
                    this.OnTrack.Equals(input.OnTrack))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.StartPosition == input.StartPosition ||
                    (this.StartPosition != null &&
                    this.StartPosition.Equals(input.StartPosition))
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
                if (this.FinishPosition != null)
                    hashCode = hashCode * 59 + this.FinishPosition.GetHashCode();
                if (this.DriverName != null)
                    hashCode = hashCode * 59 + this.DriverName.GetHashCode();
                if (this.VehicleNumber != null)
                    hashCode = hashCode * 59 + this.VehicleNumber.GetHashCode();
                if (this.Laps != null)
                    hashCode = hashCode * 59 + this.Laps.GetHashCode();
                if (this.BestTime != null)
                    hashCode = hashCode * 59 + this.BestTime.GetHashCode();
                if (this.BestSpeed != null)
                    hashCode = hashCode * 59 + this.BestSpeed.GetHashCode();
                if (this.BestLap != null)
                    hashCode = hashCode * 59 + this.BestLap.GetHashCode();
                if (this.LastLapTime != null)
                    hashCode = hashCode * 59 + this.LastLapTime.GetHashCode();
                if (this.DeltaNextTime != null)
                    hashCode = hashCode * 59 + this.DeltaNextTime.GetHashCode();
                if (this.DeltaNextLaps != null)
                    hashCode = hashCode * 59 + this.DeltaNextLaps.GetHashCode();
                if (this.DeltaLeaderTime != null)
                    hashCode = hashCode * 59 + this.DeltaLeaderTime.GetHashCode();
                if (this.DeltaLeaderLaps != null)
                    hashCode = hashCode * 59 + this.DeltaLeaderLaps.GetHashCode();
                if (this.OnTrack != null)
                    hashCode = hashCode * 59 + this.OnTrack.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.StartPosition != null)
                    hashCode = hashCode * 59 + this.StartPosition.GetHashCode();
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
