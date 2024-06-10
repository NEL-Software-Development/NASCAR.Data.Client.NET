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
    /// StageResult
    /// </summary>
    [DataContract]
        public partial class StageResult :  IEquatable<StageResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StageResult" /> class.
        /// </summary>
        /// <param name="finishPosition">finishPosition.</param>
        /// <param name="driverName">driverName.</param>
        /// <param name="vehicleNumber">vehicleNumber.</param>
        public StageResult(int? finishPosition = default(int?), string driverName = default(string), string vehicleNumber = default(string))
        {
            this.FinishPosition = finishPosition;
            this.DriverName = driverName;
            this.VehicleNumber = vehicleNumber;
        }
        
        /// <summary>
        /// Gets or Sets FinishPosition
        /// </summary>
        [DataMember(Name="finish_position", EmitDefaultValue=false)]
        public int? FinishPosition { get; set; }

        /// <summary>
        /// Gets or Sets DriverName
        /// </summary>
        [DataMember(Name="driver_name", EmitDefaultValue=false)]
        public string DriverName { get; set; }

        /// <summary>
        /// Gets or Sets VehicleNumber
        /// </summary>
        [DataMember(Name="vehicle_number", EmitDefaultValue=false)]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StageResult {\n");
            sb.Append("  FinishPosition: ").Append(FinishPosition).Append("\n");
            sb.Append("  DriverName: ").Append(DriverName).Append("\n");
            sb.Append("  VehicleNumber: ").Append(VehicleNumber).Append("\n");
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
            return this.Equals(input as StageResult);
        }

        /// <summary>
        /// Returns true if StageResult instances are equal
        /// </summary>
        /// <param name="input">Instance of StageResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StageResult input)
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
