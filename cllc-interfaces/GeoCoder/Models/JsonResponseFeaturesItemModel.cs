// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.GeoCoder.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class JsonResponseFeaturesItemModel
    {
        /// <summary>
        /// Initializes a new instance of the JsonResponseFeaturesItemModel
        /// class.
        /// </summary>
        public JsonResponseFeaturesItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JsonResponseFeaturesItemModel
        /// class.
        /// </summary>
        public JsonResponseFeaturesItemModel(string type = default(string), JsonResponseFeaturesItemGeometry geometry = default(JsonResponseFeaturesItemGeometry), JsonResponseFeaturesItem properties = default(JsonResponseFeaturesItem))
        {
            Type = type;
            Geometry = geometry;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "geometry")]
        public JsonResponseFeaturesItemGeometry Geometry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public JsonResponseFeaturesItem Properties { get; set; }

    }
}