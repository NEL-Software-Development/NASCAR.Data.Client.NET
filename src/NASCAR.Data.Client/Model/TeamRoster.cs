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
    /// TeamRoster
    /// </summary>
    [DataContract]
        public partial class TeamRoster :  IEquatable<TeamRoster>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRoster" /> class.
        /// </summary>
        /// <param name="vehicleNumber">Vehicle number.</param>
        /// <param name="members">Team members.</param>
        public TeamRoster(string vehicleNumber = default(string), Collection<RosterMember> members = default(Collection<RosterMember>))
        {
            this.VehicleNumber = vehicleNumber;
            this.Members = members;
        }
        
        /// <summary>
        /// Vehicle number
        /// </summary>
        /// <value>Vehicle number</value>
        [DataMember(Name="vehicle_number", EmitDefaultValue=false)]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// Team members
        /// </summary>
        /// <value>Team members</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public Collection<RosterMember> Members { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamRoster {\n");
            sb.Append("  VehicleNumber: ").Append(VehicleNumber).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
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
            return this.Equals(input as TeamRoster);
        }

        /// <summary>
        /// Returns true if TeamRoster instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamRoster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamRoster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VehicleNumber == input.VehicleNumber ||
                    (this.VehicleNumber != null &&
                    this.VehicleNumber.Equals(input.VehicleNumber))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
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
                if (this.VehicleNumber != null)
                    hashCode = hashCode * 59 + this.VehicleNumber.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
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
