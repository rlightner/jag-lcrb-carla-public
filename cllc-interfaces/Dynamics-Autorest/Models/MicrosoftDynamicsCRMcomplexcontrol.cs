// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMcomplexcontrol
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcomplexcontrol class.
        /// </summary>
        public MicrosoftDynamicsCRMcomplexcontrol()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMcomplexcontrol class.
        /// </summary>
        public MicrosoftDynamicsCRMcomplexcontrol(string _organizationidValue = default(string), string complexcontrolid = default(string), string complexcontrolidunique = default(string), string complexcontrolxml = default(string), string description = default(string), string name = default(string), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), int? type = default(int?), int? version = default(int?), object versionnumber = default(object))
        {
            this._organizationidValue = _organizationidValue;
            Complexcontrolid = complexcontrolid;
            Complexcontrolidunique = complexcontrolidunique;
            Complexcontrolxml = complexcontrolxml;
            Description = description;
            Name = name;
            Organizationid = organizationid;
            Type = type;
            Version = version;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "complexcontrolid")]
        public string Complexcontrolid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "complexcontrolidunique")]
        public string Complexcontrolidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "complexcontrolxml")]
        public string Complexcontrolxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public int? Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}