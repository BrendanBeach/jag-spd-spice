// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DependentManyToManyRelationshipMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMDependentManyToManyRelationshipMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentManyToManyRelationshipMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentManyToManyRelationshipMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentManyToManyRelationshipMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentManyToManyRelationshipMetadata(string intersectEntity = default(string), string fromEntityAttribute = default(string), string toEntityAttribute = default(string), string intersectPrimaryAttribute = default(string), string intersectRelatedAttribute = default(string))
        {
            IntersectEntity = intersectEntity;
            FromEntityAttribute = fromEntityAttribute;
            ToEntityAttribute = toEntityAttribute;
            IntersectPrimaryAttribute = intersectPrimaryAttribute;
            IntersectRelatedAttribute = intersectRelatedAttribute;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntersectEntity")]
        public string IntersectEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FromEntityAttribute")]
        public string FromEntityAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ToEntityAttribute")]
        public string ToEntityAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntersectPrimaryAttribute")]
        public string IntersectPrimaryAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IntersectRelatedAttribute")]
        public string IntersectRelatedAttribute { get; set; }

    }
}
