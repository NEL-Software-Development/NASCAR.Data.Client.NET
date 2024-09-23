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
    /// DriverSummaryByTrack
    /// </summary>
    [DataContract]
        public partial class DriverSummaryByTrack :  IEquatable<DriverSummaryByTrack>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DriverSummaryByTrack" /> class.
        /// </summary>
        /// <param name="averageStart">Average start position.</param>
        /// <param name="averageFinish">Average finish position.</param>
        /// <param name="dnf">The number of races where the driver did not finish.</param>
        /// <param name="driverId">Driver Id.</param>
        /// <param name="lapsCompleted">The number of laps completed.</param>
        /// <param name="lapsLed">The number of laps led.</param>
        /// <param name="leadLapFinish">The number of finishes where the driver was on the lead lap.</param>
        /// <param name="milesCompleted">Total miles completed.</param>
        /// <param name="poles">The number of times the driver earned the pole position.</param>
        /// <param name="runningAtFinish">Running at finish.</param>
        /// <param name="seriesId">Series ID.</param>
        /// <param name="top5">The number of top 5 finishes.</param>
        /// <param name="top10">The number of top 10 finishes.</param>
        /// <param name="totalRaces">The total number of races.</param>
        /// <param name="wins">Race wins.</param>
        /// <param name="season">Race season.</param>
        /// <param name="trackId">Track Id.</param>
        /// <param name="trackName">Track name.</param>
        public DriverSummaryByTrack(double? averageStart = default(double?), double? averageFinish = default(double?), int? dnf = default(int?), int? driverId = default(int?), int? lapsCompleted = default(int?), int? lapsLed = default(int?), int? leadLapFinish = default(int?), double? milesCompleted = default(double?), int? poles = default(int?), int? runningAtFinish = default(int?), int? seriesId = default(int?), int? top5 = default(int?), int? top10 = default(int?), int? totalRaces = default(int?), int? wins = default(int?), int? season = default(int?), int? trackId = default(int?), string trackName = default(string))
        {
            this.AverageStart = averageStart;
            this.AverageFinish = averageFinish;
            this.Dnf = dnf;
            this.DriverId = driverId;
            this.LapsCompleted = lapsCompleted;
            this.LapsLed = lapsLed;
            this.LeadLapFinish = leadLapFinish;
            this.MilesCompleted = milesCompleted;
            this.Poles = poles;
            this.RunningAtFinish = runningAtFinish;
            this.SeriesId = seriesId;
            this.Top5 = top5;
            this.Top10 = top10;
            this.TotalRaces = totalRaces;
            this.Wins = wins;
            this.Season = season;
            this.TrackId = trackId;
            this.TrackName = trackName;
        }
        
        /// <summary>
        /// Average start position
        /// </summary>
        /// <value>Average start position</value>
        [DataMember(Name="average_start", EmitDefaultValue=false)]
        public double? AverageStart { get; set; }

        /// <summary>
        /// Average finish position
        /// </summary>
        /// <value>Average finish position</value>
        [DataMember(Name="average_finish", EmitDefaultValue=false)]
        public double? AverageFinish { get; set; }

        /// <summary>
        /// The number of races where the driver did not finish
        /// </summary>
        /// <value>The number of races where the driver did not finish</value>
        [DataMember(Name="dnf", EmitDefaultValue=false)]
        public int? Dnf { get; set; }

        /// <summary>
        /// Driver Id
        /// </summary>
        /// <value>Driver Id</value>
        [DataMember(Name="driver_id", EmitDefaultValue=false)]
        public int? DriverId { get; set; }

        /// <summary>
        /// The number of laps completed
        /// </summary>
        /// <value>The number of laps completed</value>
        [DataMember(Name="laps_completed", EmitDefaultValue=false)]
        public int? LapsCompleted { get; set; }

        /// <summary>
        /// The number of laps led
        /// </summary>
        /// <value>The number of laps led</value>
        [DataMember(Name="laps_led", EmitDefaultValue=false)]
        public int? LapsLed { get; set; }

        /// <summary>
        /// The number of finishes where the driver was on the lead lap
        /// </summary>
        /// <value>The number of finishes where the driver was on the lead lap</value>
        [DataMember(Name="lead_lap_finish", EmitDefaultValue=false)]
        public int? LeadLapFinish { get; set; }

        /// <summary>
        /// Total miles completed
        /// </summary>
        /// <value>Total miles completed</value>
        [DataMember(Name="miles_completed", EmitDefaultValue=false)]
        public double? MilesCompleted { get; set; }

        /// <summary>
        /// The number of times the driver earned the pole position
        /// </summary>
        /// <value>The number of times the driver earned the pole position</value>
        [DataMember(Name="poles", EmitDefaultValue=false)]
        public int? Poles { get; set; }

        /// <summary>
        /// Running at finish
        /// </summary>
        /// <value>Running at finish</value>
        [DataMember(Name="running_at_finish", EmitDefaultValue=false)]
        public int? RunningAtFinish { get; set; }

        /// <summary>
        /// Series ID
        /// </summary>
        /// <value>Series ID</value>
        [DataMember(Name="series_id", EmitDefaultValue=false)]
        public int? SeriesId { get; set; }

        /// <summary>
        /// The number of top 5 finishes
        /// </summary>
        /// <value>The number of top 5 finishes</value>
        [DataMember(Name="top5", EmitDefaultValue=false)]
        public int? Top5 { get; set; }

        /// <summary>
        /// The number of top 10 finishes
        /// </summary>
        /// <value>The number of top 10 finishes</value>
        [DataMember(Name="top10", EmitDefaultValue=false)]
        public int? Top10 { get; set; }

        /// <summary>
        /// The total number of races
        /// </summary>
        /// <value>The total number of races</value>
        [DataMember(Name="total_races", EmitDefaultValue=false)]
        public int? TotalRaces { get; set; }

        /// <summary>
        /// Race wins
        /// </summary>
        /// <value>Race wins</value>
        [DataMember(Name="wins", EmitDefaultValue=false)]
        public int? Wins { get; set; }

        /// <summary>
        /// Race season
        /// </summary>
        /// <value>Race season</value>
        [DataMember(Name="season", EmitDefaultValue=false)]
        public int? Season { get; set; }

        /// <summary>
        /// Track Id
        /// </summary>
        /// <value>Track Id</value>
        [DataMember(Name="track_id", EmitDefaultValue=false)]
        public int? TrackId { get; set; }

        /// <summary>
        /// Track name
        /// </summary>
        /// <value>Track name</value>
        [DataMember(Name="track_name", EmitDefaultValue=false)]
        public string TrackName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DriverSummaryByTrack {\n");
            sb.Append("  AverageStart: ").Append(AverageStart).Append("\n");
            sb.Append("  AverageFinish: ").Append(AverageFinish).Append("\n");
            sb.Append("  Dnf: ").Append(Dnf).Append("\n");
            sb.Append("  DriverId: ").Append(DriverId).Append("\n");
            sb.Append("  LapsCompleted: ").Append(LapsCompleted).Append("\n");
            sb.Append("  LapsLed: ").Append(LapsLed).Append("\n");
            sb.Append("  LeadLapFinish: ").Append(LeadLapFinish).Append("\n");
            sb.Append("  MilesCompleted: ").Append(MilesCompleted).Append("\n");
            sb.Append("  Poles: ").Append(Poles).Append("\n");
            sb.Append("  RunningAtFinish: ").Append(RunningAtFinish).Append("\n");
            sb.Append("  SeriesId: ").Append(SeriesId).Append("\n");
            sb.Append("  Top5: ").Append(Top5).Append("\n");
            sb.Append("  Top10: ").Append(Top10).Append("\n");
            sb.Append("  TotalRaces: ").Append(TotalRaces).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
            sb.Append("  Season: ").Append(Season).Append("\n");
            sb.Append("  TrackId: ").Append(TrackId).Append("\n");
            sb.Append("  TrackName: ").Append(TrackName).Append("\n");
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
            return this.Equals(input as DriverSummaryByTrack);
        }

        /// <summary>
        /// Returns true if DriverSummaryByTrack instances are equal
        /// </summary>
        /// <param name="input">Instance of DriverSummaryByTrack to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DriverSummaryByTrack input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AverageStart == input.AverageStart ||
                    (this.AverageStart != null &&
                    this.AverageStart.Equals(input.AverageStart))
                ) && 
                (
                    this.AverageFinish == input.AverageFinish ||
                    (this.AverageFinish != null &&
                    this.AverageFinish.Equals(input.AverageFinish))
                ) && 
                (
                    this.Dnf == input.Dnf ||
                    (this.Dnf != null &&
                    this.Dnf.Equals(input.Dnf))
                ) && 
                (
                    this.DriverId == input.DriverId ||
                    (this.DriverId != null &&
                    this.DriverId.Equals(input.DriverId))
                ) && 
                (
                    this.LapsCompleted == input.LapsCompleted ||
                    (this.LapsCompleted != null &&
                    this.LapsCompleted.Equals(input.LapsCompleted))
                ) && 
                (
                    this.LapsLed == input.LapsLed ||
                    (this.LapsLed != null &&
                    this.LapsLed.Equals(input.LapsLed))
                ) && 
                (
                    this.LeadLapFinish == input.LeadLapFinish ||
                    (this.LeadLapFinish != null &&
                    this.LeadLapFinish.Equals(input.LeadLapFinish))
                ) && 
                (
                    this.MilesCompleted == input.MilesCompleted ||
                    (this.MilesCompleted != null &&
                    this.MilesCompleted.Equals(input.MilesCompleted))
                ) && 
                (
                    this.Poles == input.Poles ||
                    (this.Poles != null &&
                    this.Poles.Equals(input.Poles))
                ) && 
                (
                    this.RunningAtFinish == input.RunningAtFinish ||
                    (this.RunningAtFinish != null &&
                    this.RunningAtFinish.Equals(input.RunningAtFinish))
                ) && 
                (
                    this.SeriesId == input.SeriesId ||
                    (this.SeriesId != null &&
                    this.SeriesId.Equals(input.SeriesId))
                ) && 
                (
                    this.Top5 == input.Top5 ||
                    (this.Top5 != null &&
                    this.Top5.Equals(input.Top5))
                ) && 
                (
                    this.Top10 == input.Top10 ||
                    (this.Top10 != null &&
                    this.Top10.Equals(input.Top10))
                ) && 
                (
                    this.TotalRaces == input.TotalRaces ||
                    (this.TotalRaces != null &&
                    this.TotalRaces.Equals(input.TotalRaces))
                ) && 
                (
                    this.Wins == input.Wins ||
                    (this.Wins != null &&
                    this.Wins.Equals(input.Wins))
                ) && 
                (
                    this.Season == input.Season ||
                    (this.Season != null &&
                    this.Season.Equals(input.Season))
                ) && 
                (
                    this.TrackId == input.TrackId ||
                    (this.TrackId != null &&
                    this.TrackId.Equals(input.TrackId))
                ) && 
                (
                    this.TrackName == input.TrackName ||
                    (this.TrackName != null &&
                    this.TrackName.Equals(input.TrackName))
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
                if (this.AverageStart != null)
                    hashCode = hashCode * 59 + this.AverageStart.GetHashCode();
                if (this.AverageFinish != null)
                    hashCode = hashCode * 59 + this.AverageFinish.GetHashCode();
                if (this.Dnf != null)
                    hashCode = hashCode * 59 + this.Dnf.GetHashCode();
                if (this.DriverId != null)
                    hashCode = hashCode * 59 + this.DriverId.GetHashCode();
                if (this.LapsCompleted != null)
                    hashCode = hashCode * 59 + this.LapsCompleted.GetHashCode();
                if (this.LapsLed != null)
                    hashCode = hashCode * 59 + this.LapsLed.GetHashCode();
                if (this.LeadLapFinish != null)
                    hashCode = hashCode * 59 + this.LeadLapFinish.GetHashCode();
                if (this.MilesCompleted != null)
                    hashCode = hashCode * 59 + this.MilesCompleted.GetHashCode();
                if (this.Poles != null)
                    hashCode = hashCode * 59 + this.Poles.GetHashCode();
                if (this.RunningAtFinish != null)
                    hashCode = hashCode * 59 + this.RunningAtFinish.GetHashCode();
                if (this.SeriesId != null)
                    hashCode = hashCode * 59 + this.SeriesId.GetHashCode();
                if (this.Top5 != null)
                    hashCode = hashCode * 59 + this.Top5.GetHashCode();
                if (this.Top10 != null)
                    hashCode = hashCode * 59 + this.Top10.GetHashCode();
                if (this.TotalRaces != null)
                    hashCode = hashCode * 59 + this.TotalRaces.GetHashCode();
                if (this.Wins != null)
                    hashCode = hashCode * 59 + this.Wins.GetHashCode();
                if (this.Season != null)
                    hashCode = hashCode * 59 + this.Season.GetHashCode();
                if (this.TrackId != null)
                    hashCode = hashCode * 59 + this.TrackId.GetHashCode();
                if (this.TrackName != null)
                    hashCode = hashCode * 59 + this.TrackName.GetHashCode();
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
