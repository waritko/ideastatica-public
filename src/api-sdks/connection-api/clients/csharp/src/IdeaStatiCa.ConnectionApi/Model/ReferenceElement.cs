/*
 * Connection Rest API 1.0
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = IdeaStatiCa.ConnectionApi.Client.OpenAPIDateConverter;

namespace IdeaStatiCa.ConnectionApi.Model
{
    /// <summary>
    /// Reference element class
    /// </summary>
    [DataContract(Name = "ReferenceElement")]
    public partial class ReferenceElement : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceElement" /> class.
        /// </summary>
        /// <param name="typeName">Element type name.</param>
        /// <param name="id">Element Id.</param>
        /// <param name="element">element.</param>
        public ReferenceElement(string typeName = default(string), int id = default(int), OpenElementId element = default(OpenElementId))
        {
            this.TypeName = typeName;
            this.Id = id;
            this.Element = element;
        }

        /// <summary>
        /// Element type name
        /// </summary>
        /// <value>Element type name</value>
        [DataMember(Name = "typeName", EmitDefaultValue = true)]
        public string TypeName { get; set; }

        /// <summary>
        /// Element Id
        /// </summary>
        /// <value>Element Id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Element
        /// </summary>
        [DataMember(Name = "element", EmitDefaultValue = false)]
        public OpenElementId Element { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReferenceElement {\n");
            sb.Append("  TypeName: ").Append(TypeName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Element: ").Append(Element).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}