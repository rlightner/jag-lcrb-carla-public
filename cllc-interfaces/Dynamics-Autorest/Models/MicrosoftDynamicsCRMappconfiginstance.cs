// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.appconfiginstance
    /// </summary>
    public partial class MicrosoftDynamicsCRMappconfiginstance
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMappconfiginstance class.
        /// </summary>
        public MicrosoftDynamicsCRMappconfiginstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMappconfiginstance class.
        /// </summary>
        public MicrosoftDynamicsCRMappconfiginstance(string _createdbyValue = default(string), string _organizationidValue = default(string), string appconfiginstanceidunique = default(string), int? importsequencenumber = default(int?), string versionnumber = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string appconfiginstanceid = default(string), string _modifiedbyValue = default(string), string solutionid = default(string), string componenttype = default(string), string _appconfigmasteridValue = default(string), bool? ismanaged = default(bool?), int? componentstate = default(int?), string objectid = default(string), string appconfigidunique = default(string), string introducedversion = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _appconfigidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string value = default(string), string _createdonbehalfbyValue = default(string), string _modifiedonbehalfbyValue = default(string), MicrosoftDynamicsCRMappconfigmaster appconfiginstanceAppconfigmaster = default(MicrosoftDynamicsCRMappconfigmaster), MicrosoftDynamicsCRMorganization organizationAppconfiginstanceAppconfiginstance = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser appconfiginstanceCreatedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMappconfig appconfiginstanceAppconfig = default(MicrosoftDynamicsCRMappconfig), MicrosoftDynamicsCRMsystemuser appconfiginstanceModifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser appconfiginstanceModifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser appconfiginstanceCreatedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._createdbyValue = _createdbyValue;
            this._organizationidValue = _organizationidValue;
            Appconfiginstanceidunique = appconfiginstanceidunique;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            Modifiedon = modifiedon;
            Appconfiginstanceid = appconfiginstanceid;
            this._modifiedbyValue = _modifiedbyValue;
            Solutionid = solutionid;
            Componenttype = componenttype;
            this._appconfigmasteridValue = _appconfigmasteridValue;
            Ismanaged = ismanaged;
            Componentstate = componentstate;
            Objectid = objectid;
            Appconfigidunique = appconfigidunique;
            Introducedversion = introducedversion;
            Overwritetime = overwritetime;
            this._appconfigidValue = _appconfigidValue;
            Createdon = createdon;
            Overriddencreatedon = overriddencreatedon;
            Value = value;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AppconfiginstanceAppconfigmaster = appconfiginstanceAppconfigmaster;
            OrganizationAppconfiginstanceAppconfiginstance = organizationAppconfiginstanceAppconfiginstance;
            AppconfiginstanceCreatedonbehalfby = appconfiginstanceCreatedonbehalfby;
            AppconfiginstanceAppconfig = appconfiginstanceAppconfig;
            AppconfiginstanceModifiedby = appconfiginstanceModifiedby;
            AppconfiginstanceModifiedonbehalfby = appconfiginstanceModifiedonbehalfby;
            AppconfiginstanceCreatedby = appconfiginstanceCreatedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfiginstanceidunique")]
        public string Appconfiginstanceidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfiginstanceid")]
        public string Appconfiginstanceid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componenttype")]
        public string Componenttype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_appconfigmasterid_value")]
        public string _appconfigmasteridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public string Objectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfigidunique")]
        public string Appconfigidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_appconfigid_value")]
        public string _appconfigidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfiginstance_appconfigmaster")]
        public MicrosoftDynamicsCRMappconfigmaster AppconfiginstanceAppconfigmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization_appconfiginstance_appconfiginstance")]
        public MicrosoftDynamicsCRMorganization OrganizationAppconfiginstanceAppconfiginstance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfiginstance_createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser AppconfiginstanceCreatedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfiginstance_appconfig")]
        public MicrosoftDynamicsCRMappconfig AppconfiginstanceAppconfig { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfiginstance_modifiedby")]
        public MicrosoftDynamicsCRMsystemuser AppconfiginstanceModifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfiginstance_modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser AppconfiginstanceModifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appconfiginstance_createdby")]
        public MicrosoftDynamicsCRMsystemuser AppconfiginstanceCreatedby { get; set; }

    }
}
