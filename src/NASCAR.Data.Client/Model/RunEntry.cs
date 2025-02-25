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
    /// RunEntry
    /// </summary>
    [DataContract]
        public partial class RunEntry :  IEquatable<RunEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunEntry" /> class.
        /// </summary>
        /// <param name="driverName">Driver name.</param>
        /// <param name="driverDetails">URL to driver details.</param>
        /// <param name="vehicleNumber">Vehicle number.</param>
        /// <param name="vehicleDetails">URL to vehicle details.</param>
        /// <param name="ownerName">Owner name.</param>
        /// <param name="crewChief">Crew chief name.</param>
        /// <param name="modelYear">Vehicle model year.</param>
        /// <param name="model">Vehicle model.</param>
        public RunEntry(string driverName = default(string), string driverDetails = default(string), string vehicleNumber = default(string), string vehicleDetails = default(string), string ownerName = default(string), string crewChief = default(string), int? modelYear = default(int?), string model = default(string))
        {
            this.DriverName = driverName;
            this.DriverDetails = driverDetails;
            this.VehicleNumber = vehicleNumber;
            this.VehicleDetails = vehicleDetails;
            this.OwnerName = ownerName;
            this.CrewChief = crewChief;
            this.ModelYear = modelYear;
            this.Model = model;
        }
        
        /// <summary>
        /// Driver name
        /// </summary>
        /// <value>Driver name</value>
        [DataMember(Name="driver_name", EmitDefaultValue=false)]
        public string DriverName { get; set; }

        /// <summary>
        /// URL to driver details
        /// </summary>
        /// <value>URL to driver details</value>
        [DataMember(Name="driver_details", EmitDefaultValue=false)]
        public string DriverDetails { get; set; }

        /// <summary>
        /// Vehicle number
        /// </summary>
        /// <value>Vehicle number</value>
        [DataMember(Name="vehicle_number", EmitDefaultValue=false)]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// URL to vehicle details
        /// </summary>
        /// <value>URL to vehicle details</value>
        [DataMember(Name="vehicle_details", EmitDefaultValue=false)]
        public string VehicleDetails { get; set; }

        /// <summary>
        /// Owner name
        /// </summary>
        /// <value>Owner name</value>
        [DataMember(Name="owner_name", EmitDefaultValue=false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// Crew chief name
        /// </summary>
        /// <value>Crew chief name</value>
        [DataMember(Name="crew_chief", EmitDefaultValue=false)]
        public string CrewChief { get; set; }

        /// <summary>
        /// Vehicle model year
        /// </summary>
        /// <value>Vehicle model year</value>
        [DataMember(Name="model_year", EmitDefaultValue=false)]
        public int? ModelYear { get; set; }

        /// <summary>
        /// Vehicle model
        /// </summary>
        /// <value>Vehicle model</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunEntry {\n");
            sb.Append("  DriverName: ").Append(DriverName).Append("\n");
            sb.Append("  DriverDetails: ").Append(DriverDetails).Append("\n");
            sb.Append("  VehicleNumber: ").Append(VehicleNumber).Append("\n");
            sb.Append("  VehicleDetails: ").Append(VehicleDetails).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  CrewChief: ").Append(CrewChief).Append("\n");
            sb.Append("  ModelYear: ").Append(ModelYear).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
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
            return this.Equals(input as RunEntry);
        }

        /// <summary>
        /// Returns true if RunEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of RunEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DriverName == input.DriverName ||
                    (this.DriverName != null &&
                    this.DriverName.Equals(input.DriverName))
                ) && 
                (
                    this.DriverDetails == input.DriverDetails ||
                    (this.DriverDetails != null &&
                    this.DriverDetails.Equals(input.DriverDetails))
                ) && 
                (
                    this.VehicleNumber == input.VehicleNumber ||
                    (this.VehicleNumber != null &&
                    this.VehicleNumber.Equals(input.VehicleNumber))
                ) && 
                (
                    this.VehicleDetails == input.VehicleDetails ||
                    (this.VehicleDetails != null &&
                    this.VehicleDetails.Equals(input.VehicleDetails))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.CrewChief == input.CrewChief ||
                    (this.CrewChief != null &&
                    this.CrewChief.Equals(input.CrewChief))
                ) && 
                (
                    this.ModelYear == input.ModelYear ||
                    (this.ModelYear != null &&
                    this.ModelYear.Equals(input.ModelYear))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
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
                if (this.DriverName != null)
                    hashCode = hashCode * 59 + this.DriverName.GetHashCode();
                if (this.DriverDetails != null)
                    hashCode = hashCode * 59 + this.DriverDetails.GetHashCode();
                if (this.VehicleNumber != null)
                    hashCode = hashCode * 59 + this.VehicleNumber.GetHashCode();
                if (this.VehicleDetails != null)
                    hashCode = hashCode * 59 + this.VehicleDetails.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.CrewChief != null)
                    hashCode = hashCode * 59 + this.CrewChief.GetHashCode();
                if (this.ModelYear != null)
                    hashCode = hashCode * 59 + this.ModelYear.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
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
