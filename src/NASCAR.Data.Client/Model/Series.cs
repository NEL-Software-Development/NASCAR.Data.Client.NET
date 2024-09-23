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
    /// Series
    /// </summary>
    [DataContract]
        public partial class Series :  IEquatable<Series>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Series" /> class.
        /// </summary>
        /// <param name="id">The series id.</param>
        /// <param name="shortName">Series short name.</param>
        /// <param name="name">Series full name.</param>
        /// <param name="abbreviation">Series abbreviation.</param>
        /// <param name="logo">URL to series logo.</param>
        public Series(int? id = default(int?), string shortName = default(string), string name = default(string), string abbreviation = default(string), string logo = default(string))
        {
            this.Id = id;
            this.ShortName = shortName;
            this.Name = name;
            this.Abbreviation = abbreviation;
            this.Logo = logo;
        }
        
        /// <summary>
        /// The series id
        /// </summary>
        /// <value>The series id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Series short name
        /// </summary>
        /// <value>Series short name</value>
        [DataMember(Name="short_name", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Series full name
        /// </summary>
        /// <value>Series full name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Series abbreviation
        /// </summary>
        /// <value>Series abbreviation</value>
        [DataMember(Name="abbreviation", EmitDefaultValue=false)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// URL to series logo
        /// </summary>
        /// <value>URL to series logo</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Series {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
            return this.Equals(input as Series);
        }

        /// <summary>
        /// Returns true if Series instances are equal
        /// </summary>
        /// <param name="input">Instance of Series to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Series input)
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
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Abbreviation == input.Abbreviation ||
                    (this.Abbreviation != null &&
                    this.Abbreviation.Equals(input.Abbreviation))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
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
                if (this.ShortName != null)
                    hashCode = hashCode * 59 + this.ShortName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Abbreviation != null)
                    hashCode = hashCode * 59 + this.Abbreviation.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
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
