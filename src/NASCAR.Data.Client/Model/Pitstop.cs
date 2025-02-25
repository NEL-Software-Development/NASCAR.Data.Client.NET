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
    /// Pitstop
    /// </summary>
    [DataContract]
        public partial class Pitstop :  IEquatable<Pitstop>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pitstop" /> class.
        /// </summary>
        /// <param name="lap">Lap.</param>
        /// <param name="leaderLap">Leader lap.</param>
        /// <param name="vehicleNumber">Vehicle number.</param>
        /// <param name="enterFlagstate">Enter flag state.</param>
        /// <param name="enterRacetime">Exit flag state.</param>
        /// <param name="enterTravelduration">Enter travel duration.</param>
        /// <param name="adjustmentLeft">Adjustment left.</param>
        /// <param name="adjustmentRight">Adjustment right.</param>
        /// <param name="bodyRepairs">Body repairs.</param>
        /// <param name="fuelCans">Number of fuel cans.</param>
        /// <param name="leftfrontTirechanged">Left front tire changed.</param>
        /// <param name="leftrearTirechanged">Left rear tire changed.</param>
        /// <param name="rightfrontTirechanged">Right front tire changed.</param>
        /// <param name="rightrearTirechanged">Right rear tire changed.</param>
        /// <param name="infraction">Infraction.</param>
        /// <param name="video">Video.</param>
        /// <param name="pitboxEnter">Pit box enter.</param>
        /// <param name="pitboxExit">Pit box exit.</param>
        /// <param name="exitFlagstate">Exit flag state.</param>
        /// <param name="exitRacetime">Exit race time.</param>
        /// <param name="exitTravelduration">Exit travel duration.</param>
        /// <param name="totalDuration">Total duration.</param>
        public Pitstop(int? lap = default(int?), int? leaderLap = default(int?), string vehicleNumber = default(string), int? enterFlagstate = default(int?), double? enterRacetime = default(double?), double? enterTravelduration = default(double?), bool? adjustmentLeft = default(bool?), bool? adjustmentRight = default(bool?), bool? bodyRepairs = default(bool?), int? fuelCans = default(int?), bool? leftfrontTirechanged = default(bool?), bool? leftrearTirechanged = default(bool?), bool? rightfrontTirechanged = default(bool?), bool? rightrearTirechanged = default(bool?), string infraction = default(string), string video = default(string), double? pitboxEnter = default(double?), double? pitboxExit = default(double?), int? exitFlagstate = default(int?), double? exitRacetime = default(double?), double? exitTravelduration = default(double?), double? totalDuration = default(double?))
        {
            this.Lap = lap;
            this.LeaderLap = leaderLap;
            this.VehicleNumber = vehicleNumber;
            this.EnterFlagstate = enterFlagstate;
            this.EnterRacetime = enterRacetime;
            this.EnterTravelduration = enterTravelduration;
            this.AdjustmentLeft = adjustmentLeft;
            this.AdjustmentRight = adjustmentRight;
            this.BodyRepairs = bodyRepairs;
            this.FuelCans = fuelCans;
            this.LeftfrontTirechanged = leftfrontTirechanged;
            this.LeftrearTirechanged = leftrearTirechanged;
            this.RightfrontTirechanged = rightfrontTirechanged;
            this.RightrearTirechanged = rightrearTirechanged;
            this.Infraction = infraction;
            this.Video = video;
            this.PitboxEnter = pitboxEnter;
            this.PitboxExit = pitboxExit;
            this.ExitFlagstate = exitFlagstate;
            this.ExitRacetime = exitRacetime;
            this.ExitTravelduration = exitTravelduration;
            this.TotalDuration = totalDuration;
        }
        
        /// <summary>
        /// Lap
        /// </summary>
        /// <value>Lap</value>
        [DataMember(Name="lap", EmitDefaultValue=false)]
        public int? Lap { get; set; }

        /// <summary>
        /// Leader lap
        /// </summary>
        /// <value>Leader lap</value>
        [DataMember(Name="leader_lap", EmitDefaultValue=false)]
        public int? LeaderLap { get; set; }

        /// <summary>
        /// Vehicle number
        /// </summary>
        /// <value>Vehicle number</value>
        [DataMember(Name="vehicle_number", EmitDefaultValue=false)]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// Enter flag state
        /// </summary>
        /// <value>Enter flag state</value>
        [DataMember(Name="enter_flagstate", EmitDefaultValue=false)]
        public int? EnterFlagstate { get; set; }

        /// <summary>
        /// Exit flag state
        /// </summary>
        /// <value>Exit flag state</value>
        [DataMember(Name="enter_racetime", EmitDefaultValue=false)]
        public double? EnterRacetime { get; set; }

        /// <summary>
        /// Enter travel duration
        /// </summary>
        /// <value>Enter travel duration</value>
        [DataMember(Name="enter_travelduration", EmitDefaultValue=false)]
        public double? EnterTravelduration { get; set; }

        /// <summary>
        /// Adjustment left
        /// </summary>
        /// <value>Adjustment left</value>
        [DataMember(Name="adjustment_left", EmitDefaultValue=false)]
        public bool? AdjustmentLeft { get; set; }

        /// <summary>
        /// Adjustment right
        /// </summary>
        /// <value>Adjustment right</value>
        [DataMember(Name="adjustment_right", EmitDefaultValue=false)]
        public bool? AdjustmentRight { get; set; }

        /// <summary>
        /// Body repairs
        /// </summary>
        /// <value>Body repairs</value>
        [DataMember(Name="body_repairs", EmitDefaultValue=false)]
        public bool? BodyRepairs { get; set; }

        /// <summary>
        /// Number of fuel cans
        /// </summary>
        /// <value>Number of fuel cans</value>
        [DataMember(Name="fuel_cans", EmitDefaultValue=false)]
        public int? FuelCans { get; set; }

        /// <summary>
        /// Left front tire changed
        /// </summary>
        /// <value>Left front tire changed</value>
        [DataMember(Name="leftfront_tirechanged", EmitDefaultValue=false)]
        public bool? LeftfrontTirechanged { get; set; }

        /// <summary>
        /// Left rear tire changed
        /// </summary>
        /// <value>Left rear tire changed</value>
        [DataMember(Name="Leftrear_tirechanged", EmitDefaultValue=false)]
        public bool? LeftrearTirechanged { get; set; }

        /// <summary>
        /// Right front tire changed
        /// </summary>
        /// <value>Right front tire changed</value>
        [DataMember(Name="rightfront_tirechanged", EmitDefaultValue=false)]
        public bool? RightfrontTirechanged { get; set; }

        /// <summary>
        /// Right rear tire changed
        /// </summary>
        /// <value>Right rear tire changed</value>
        [DataMember(Name="rightrear_tirechanged", EmitDefaultValue=false)]
        public bool? RightrearTirechanged { get; set; }

        /// <summary>
        /// Infraction
        /// </summary>
        /// <value>Infraction</value>
        [DataMember(Name="infraction", EmitDefaultValue=false)]
        public string Infraction { get; set; }

        /// <summary>
        /// Video
        /// </summary>
        /// <value>Video</value>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public string Video { get; set; }

        /// <summary>
        /// Pit box enter
        /// </summary>
        /// <value>Pit box enter</value>
        [DataMember(Name="pitbox_enter", EmitDefaultValue=false)]
        public double? PitboxEnter { get; set; }

        /// <summary>
        /// Pit box exit
        /// </summary>
        /// <value>Pit box exit</value>
        [DataMember(Name="pitbox_exit", EmitDefaultValue=false)]
        public double? PitboxExit { get; set; }

        /// <summary>
        /// Exit flag state
        /// </summary>
        /// <value>Exit flag state</value>
        [DataMember(Name="exit_flagstate", EmitDefaultValue=false)]
        public int? ExitFlagstate { get; set; }

        /// <summary>
        /// Exit race time
        /// </summary>
        /// <value>Exit race time</value>
        [DataMember(Name="exit_racetime", EmitDefaultValue=false)]
        public double? ExitRacetime { get; set; }

        /// <summary>
        /// Exit travel duration
        /// </summary>
        /// <value>Exit travel duration</value>
        [DataMember(Name="exit_travelduration", EmitDefaultValue=false)]
        public double? ExitTravelduration { get; set; }

        /// <summary>
        /// Total duration
        /// </summary>
        /// <value>Total duration</value>
        [DataMember(Name="total_duration", EmitDefaultValue=false)]
        public double? TotalDuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pitstop {\n");
            sb.Append("  Lap: ").Append(Lap).Append("\n");
            sb.Append("  LeaderLap: ").Append(LeaderLap).Append("\n");
            sb.Append("  VehicleNumber: ").Append(VehicleNumber).Append("\n");
            sb.Append("  EnterFlagstate: ").Append(EnterFlagstate).Append("\n");
            sb.Append("  EnterRacetime: ").Append(EnterRacetime).Append("\n");
            sb.Append("  EnterTravelduration: ").Append(EnterTravelduration).Append("\n");
            sb.Append("  AdjustmentLeft: ").Append(AdjustmentLeft).Append("\n");
            sb.Append("  AdjustmentRight: ").Append(AdjustmentRight).Append("\n");
            sb.Append("  BodyRepairs: ").Append(BodyRepairs).Append("\n");
            sb.Append("  FuelCans: ").Append(FuelCans).Append("\n");
            sb.Append("  LeftfrontTirechanged: ").Append(LeftfrontTirechanged).Append("\n");
            sb.Append("  LeftrearTirechanged: ").Append(LeftrearTirechanged).Append("\n");
            sb.Append("  RightfrontTirechanged: ").Append(RightfrontTirechanged).Append("\n");
            sb.Append("  RightrearTirechanged: ").Append(RightrearTirechanged).Append("\n");
            sb.Append("  Infraction: ").Append(Infraction).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  PitboxEnter: ").Append(PitboxEnter).Append("\n");
            sb.Append("  PitboxExit: ").Append(PitboxExit).Append("\n");
            sb.Append("  ExitFlagstate: ").Append(ExitFlagstate).Append("\n");
            sb.Append("  ExitRacetime: ").Append(ExitRacetime).Append("\n");
            sb.Append("  ExitTravelduration: ").Append(ExitTravelduration).Append("\n");
            sb.Append("  TotalDuration: ").Append(TotalDuration).Append("\n");
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
            return this.Equals(input as Pitstop);
        }

        /// <summary>
        /// Returns true if Pitstop instances are equal
        /// </summary>
        /// <param name="input">Instance of Pitstop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pitstop input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Lap == input.Lap ||
                    (this.Lap != null &&
                    this.Lap.Equals(input.Lap))
                ) && 
                (
                    this.LeaderLap == input.LeaderLap ||
                    (this.LeaderLap != null &&
                    this.LeaderLap.Equals(input.LeaderLap))
                ) && 
                (
                    this.VehicleNumber == input.VehicleNumber ||
                    (this.VehicleNumber != null &&
                    this.VehicleNumber.Equals(input.VehicleNumber))
                ) && 
                (
                    this.EnterFlagstate == input.EnterFlagstate ||
                    (this.EnterFlagstate != null &&
                    this.EnterFlagstate.Equals(input.EnterFlagstate))
                ) && 
                (
                    this.EnterRacetime == input.EnterRacetime ||
                    (this.EnterRacetime != null &&
                    this.EnterRacetime.Equals(input.EnterRacetime))
                ) && 
                (
                    this.EnterTravelduration == input.EnterTravelduration ||
                    (this.EnterTravelduration != null &&
                    this.EnterTravelduration.Equals(input.EnterTravelduration))
                ) && 
                (
                    this.AdjustmentLeft == input.AdjustmentLeft ||
                    (this.AdjustmentLeft != null &&
                    this.AdjustmentLeft.Equals(input.AdjustmentLeft))
                ) && 
                (
                    this.AdjustmentRight == input.AdjustmentRight ||
                    (this.AdjustmentRight != null &&
                    this.AdjustmentRight.Equals(input.AdjustmentRight))
                ) && 
                (
                    this.BodyRepairs == input.BodyRepairs ||
                    (this.BodyRepairs != null &&
                    this.BodyRepairs.Equals(input.BodyRepairs))
                ) && 
                (
                    this.FuelCans == input.FuelCans ||
                    (this.FuelCans != null &&
                    this.FuelCans.Equals(input.FuelCans))
                ) && 
                (
                    this.LeftfrontTirechanged == input.LeftfrontTirechanged ||
                    (this.LeftfrontTirechanged != null &&
                    this.LeftfrontTirechanged.Equals(input.LeftfrontTirechanged))
                ) && 
                (
                    this.LeftrearTirechanged == input.LeftrearTirechanged ||
                    (this.LeftrearTirechanged != null &&
                    this.LeftrearTirechanged.Equals(input.LeftrearTirechanged))
                ) && 
                (
                    this.RightfrontTirechanged == input.RightfrontTirechanged ||
                    (this.RightfrontTirechanged != null &&
                    this.RightfrontTirechanged.Equals(input.RightfrontTirechanged))
                ) && 
                (
                    this.RightrearTirechanged == input.RightrearTirechanged ||
                    (this.RightrearTirechanged != null &&
                    this.RightrearTirechanged.Equals(input.RightrearTirechanged))
                ) && 
                (
                    this.Infraction == input.Infraction ||
                    (this.Infraction != null &&
                    this.Infraction.Equals(input.Infraction))
                ) && 
                (
                    this.Video == input.Video ||
                    (this.Video != null &&
                    this.Video.Equals(input.Video))
                ) && 
                (
                    this.PitboxEnter == input.PitboxEnter ||
                    (this.PitboxEnter != null &&
                    this.PitboxEnter.Equals(input.PitboxEnter))
                ) && 
                (
                    this.PitboxExit == input.PitboxExit ||
                    (this.PitboxExit != null &&
                    this.PitboxExit.Equals(input.PitboxExit))
                ) && 
                (
                    this.ExitFlagstate == input.ExitFlagstate ||
                    (this.ExitFlagstate != null &&
                    this.ExitFlagstate.Equals(input.ExitFlagstate))
                ) && 
                (
                    this.ExitRacetime == input.ExitRacetime ||
                    (this.ExitRacetime != null &&
                    this.ExitRacetime.Equals(input.ExitRacetime))
                ) && 
                (
                    this.ExitTravelduration == input.ExitTravelduration ||
                    (this.ExitTravelduration != null &&
                    this.ExitTravelduration.Equals(input.ExitTravelduration))
                ) && 
                (
                    this.TotalDuration == input.TotalDuration ||
                    (this.TotalDuration != null &&
                    this.TotalDuration.Equals(input.TotalDuration))
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
                if (this.Lap != null)
                    hashCode = hashCode * 59 + this.Lap.GetHashCode();
                if (this.LeaderLap != null)
                    hashCode = hashCode * 59 + this.LeaderLap.GetHashCode();
                if (this.VehicleNumber != null)
                    hashCode = hashCode * 59 + this.VehicleNumber.GetHashCode();
                if (this.EnterFlagstate != null)
                    hashCode = hashCode * 59 + this.EnterFlagstate.GetHashCode();
                if (this.EnterRacetime != null)
                    hashCode = hashCode * 59 + this.EnterRacetime.GetHashCode();
                if (this.EnterTravelduration != null)
                    hashCode = hashCode * 59 + this.EnterTravelduration.GetHashCode();
                if (this.AdjustmentLeft != null)
                    hashCode = hashCode * 59 + this.AdjustmentLeft.GetHashCode();
                if (this.AdjustmentRight != null)
                    hashCode = hashCode * 59 + this.AdjustmentRight.GetHashCode();
                if (this.BodyRepairs != null)
                    hashCode = hashCode * 59 + this.BodyRepairs.GetHashCode();
                if (this.FuelCans != null)
                    hashCode = hashCode * 59 + this.FuelCans.GetHashCode();
                if (this.LeftfrontTirechanged != null)
                    hashCode = hashCode * 59 + this.LeftfrontTirechanged.GetHashCode();
                if (this.LeftrearTirechanged != null)
                    hashCode = hashCode * 59 + this.LeftrearTirechanged.GetHashCode();
                if (this.RightfrontTirechanged != null)
                    hashCode = hashCode * 59 + this.RightfrontTirechanged.GetHashCode();
                if (this.RightrearTirechanged != null)
                    hashCode = hashCode * 59 + this.RightrearTirechanged.GetHashCode();
                if (this.Infraction != null)
                    hashCode = hashCode * 59 + this.Infraction.GetHashCode();
                if (this.Video != null)
                    hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.PitboxEnter != null)
                    hashCode = hashCode * 59 + this.PitboxEnter.GetHashCode();
                if (this.PitboxExit != null)
                    hashCode = hashCode * 59 + this.PitboxExit.GetHashCode();
                if (this.ExitFlagstate != null)
                    hashCode = hashCode * 59 + this.ExitFlagstate.GetHashCode();
                if (this.ExitRacetime != null)
                    hashCode = hashCode * 59 + this.ExitRacetime.GetHashCode();
                if (this.ExitTravelduration != null)
                    hashCode = hashCode * 59 + this.ExitTravelduration.GetHashCode();
                if (this.TotalDuration != null)
                    hashCode = hashCode * 59 + this.TotalDuration.GetHashCode();
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
