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
    /// RetrieveApplicationRibbonResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveApplicationRibbonResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveApplicationRibbonResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveApplicationRibbonResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveApplicationRibbonResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveApplicationRibbonResponse(object compressedApplicationRibbonXml = default(object))
        {
            CompressedApplicationRibbonXml = compressedApplicationRibbonXml;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CompressedApplicationRibbonXml")]
        public object CompressedApplicationRibbonXml { get; set; }

    }
}
