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
    /// RaceInfraction
    /// </summary>
    [DataContract]
        public partial class RaceInfraction :  IEquatable<RaceInfraction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RaceInfraction" /> class.
        /// </summary>
        /// <param name="flagState">Flag state at the time of the infraction: (W,G,G/Y,R,Y).</param>
        /// <param name="infraction">Description of the infraction.</param>
        /// <param name="vehicleNumber">Vehicle number.</param>
        /// <param name="lap">Lap of infraction.</param>
        /// <param name="lapAssessed">Lap infraction was assessed.</param>
        /// <param name="timeOfRace">Time of race the infraction occurred.</param>
        /// <param name="penalty">Penalty assessed.</param>
        /// <param name="notes">Notes.</param>
        public RaceInfraction(string flagState = default(string), string infraction = default(string), string vehicleNumber = default(string), int? lap = default(int?), int? lapAssessed = default(int?), DateTimeOffset? timeOfRace = default(DateTimeOffset?), string penalty = default(string), string notes = default(string))
        {
            this.FlagState = flagState;
            this.Infraction = infraction;
            this.VehicleNumber = vehicleNumber;
            this.Lap = lap;
            this.LapAssessed = lapAssessed;
            this.TimeOfRace = timeOfRace;
            this.Penalty = penalty;
            this.Notes = notes;
        }
        
        /// <summary>
        /// Flag state at the time of the infraction: (W,G,G/Y,R,Y)
        /// </summary>
        /// <value>Flag state at the time of the infraction: (W,G,G/Y,R,Y)</value>
        [DataMember(Name="flag_state", EmitDefaultValue=false)]
        public string FlagState { get; set; }

        /// <summary>
        /// Description of the infraction
        /// </summary>
        /// <value>Description of the infraction</value>
        [DataMember(Name="infraction", EmitDefaultValue=false)]
        public string Infraction { get; set; }

        /// <summary>
        /// Vehicle number
        /// </summary>
        /// <value>Vehicle number</value>
        [DataMember(Name="vehicle_number", EmitDefaultValue=false)]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// Lap of infraction
        /// </summary>
        /// <value>Lap of infraction</value>
        [DataMember(Name="lap", EmitDefaultValue=false)]
        public int? Lap { get; set; }

        /// <summary>
        /// Lap infraction was assessed
        /// </summary>
        /// <value>Lap infraction was assessed</value>
        [DataMember(Name="lap_assessed", EmitDefaultValue=false)]
        public int? LapAssessed { get; set; }

        /// <summary>
        /// Time of race the infraction occurred
        /// </summary>
        /// <value>Time of race the infraction occurred</value>
        [DataMember(Name="time_of_race", EmitDefaultValue=false)]
        public DateTimeOffset? TimeOfRace { get; set; }

        /// <summary>
        /// Penalty assessed
        /// </summary>
        /// <value>Penalty assessed</value>
        [DataMember(Name="penalty", EmitDefaultValue=false)]
        public string Penalty { get; set; }

        /// <summary>
        /// Notes
        /// </summary>
        /// <value>Notes</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RaceInfraction {\n");
            sb.Append("  FlagState: ").Append(FlagState).Append("\n");
            sb.Append("  Infraction: ").Append(Infraction).Append("\n");
            sb.Append("  VehicleNumber: ").Append(VehicleNumber).Append("\n");
            sb.Append("  Lap: ").Append(Lap).Append("\n");
            sb.Append("  LapAssessed: ").Append(LapAssessed).Append("\n");
            sb.Append("  TimeOfRace: ").Append(TimeOfRace).Append("\n");
            sb.Append("  Penalty: ").Append(Penalty).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as RaceInfraction);
        }

        /// <summary>
        /// Returns true if RaceInfraction instances are equal
        /// </summary>
        /// <param name="input">Instance of RaceInfraction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RaceInfraction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlagState == input.FlagState ||
                    (this.FlagState != null &&
                    this.FlagState.Equals(input.FlagState))
                ) && 
                (
                    this.Infraction == input.Infraction ||
                    (this.Infraction != null &&
                    this.Infraction.Equals(input.Infraction))
                ) && 
                (
                    this.VehicleNumber == input.VehicleNumber ||
                    (this.VehicleNumber != null &&
                    this.VehicleNumber.Equals(input.VehicleNumber))
                ) && 
                (
                    this.Lap == input.Lap ||
                    (this.Lap != null &&
                    this.Lap.Equals(input.Lap))
                ) && 
                (
                    this.LapAssessed == input.LapAssessed ||
                    (this.LapAssessed != null &&
                    this.LapAssessed.Equals(input.LapAssessed))
                ) && 
                (
                    this.TimeOfRace == input.TimeOfRace ||
                    (this.TimeOfRace != null &&
                    this.TimeOfRace.Equals(input.TimeOfRace))
                ) && 
                (
                    this.Penalty == input.Penalty ||
                    (this.Penalty != null &&
                    this.Penalty.Equals(input.Penalty))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.FlagState != null)
                    hashCode = hashCode * 59 + this.FlagState.GetHashCode();
                if (this.Infraction != null)
                    hashCode = hashCode * 59 + this.Infraction.GetHashCode();
                if (this.VehicleNumber != null)
                    hashCode = hashCode * 59 + this.VehicleNumber.GetHashCode();
                if (this.Lap != null)
                    hashCode = hashCode * 59 + this.Lap.GetHashCode();
                if (this.LapAssessed != null)
                    hashCode = hashCode * 59 + this.LapAssessed.GetHashCode();
                if (this.TimeOfRace != null)
                    hashCode = hashCode * 59 + this.TimeOfRace.GetHashCode();
                if (this.Penalty != null)
                    hashCode = hashCode * 59 + this.Penalty.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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
