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
    /// Microsoft.Dynamics.CRM.exchangesyncidmapping
    /// </summary>
    public partial class MicrosoftDynamicsCRMexchangesyncidmapping
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMexchangesyncidmapping class.
        /// </summary>
        public MicrosoftDynamicsCRMexchangesyncidmapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMexchangesyncidmapping class.
        /// </summary>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics 365 options.</param>
        /// <param name="lastsyncerroroccurredon">Last Sync Error Time</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.</param>
        public MicrosoftDynamicsCRMexchangesyncidmapping(int? objecttypecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? lastsyncerroroccurredon = default(System.DateTimeOffset?), System.Guid? objectid = default(System.Guid?), System.Guid? _owninguserValue = default(System.Guid?), int? tocrmchangetype = default(int?), int? retries = default(int?), bool? isdeletedinexchange = default(bool?), string versionnumber = default(string), int? lastsyncerrorcode = default(int?), System.Guid? _owningbusinessunitValue = default(System.Guid?), System.Guid? _owneridValue = default(System.Guid?), bool? isunlinkedincrm = default(bool?), System.Guid? _owningteamValue = default(System.Guid?), System.Guid? exchangesyncidmappingid = default(System.Guid?), int? fromcrmchangetype = default(int?), int? userdecision = default(int?), string exchangeentryid = default(string), string lastsyncerror = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit))
        {
            Objecttypecode = objecttypecode;
            Modifiedon = modifiedon;
            Lastsyncerroroccurredon = lastsyncerroroccurredon;
            Objectid = objectid;
            this._owninguserValue = _owninguserValue;
            Tocrmchangetype = tocrmchangetype;
            Retries = retries;
            Isdeletedinexchange = isdeletedinexchange;
            Versionnumber = versionnumber;
            Lastsyncerrorcode = lastsyncerrorcode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owneridValue = _owneridValue;
            Isunlinkedincrm = isunlinkedincrm;
            this._owningteamValue = _owningteamValue;
            Exchangesyncidmappingid = exchangesyncidmappingid;
            Fromcrmchangetype = fromcrmchangetype;
            Userdecision = userdecision;
            Exchangeentryid = exchangeentryid;
            Lastsyncerror = lastsyncerror;
            Createdon = createdon;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets last Sync Error Time
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerroroccurredon")]
        public System.DateTimeOffset? Lastsyncerroroccurredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public System.Guid? Objectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tocrmchangetype")]
        public int? Tocrmchangetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "retries")]
        public int? Retries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdeletedinexchange")]
        public bool? Isdeletedinexchange { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerrorcode")]
        public int? Lastsyncerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isunlinkedincrm")]
        public bool? Isunlinkedincrm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangesyncidmappingid")]
        public System.Guid? Exchangesyncidmappingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fromcrmchangetype")]
        public int? Fromcrmchangetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userdecision")]
        public int? Userdecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangeentryid")]
        public string Exchangeentryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerror")]
        public string Lastsyncerror { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics 365 options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

    }
}
