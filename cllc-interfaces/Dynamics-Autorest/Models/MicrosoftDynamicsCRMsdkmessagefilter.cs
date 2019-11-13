// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.sdkmessagefilter
    /// </summary>
    public partial class MicrosoftDynamicsCRMsdkmessagefilter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessagefilter class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessagefilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessagefilter class.
        /// </summary>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization with which the SDK message filter is
        /// associated.</param>
        /// <param name="createdon">Date and time when the SDK message filter
        /// was created.</param>
        /// <param name="availability">Identifies where a method will be
        /// exposed. 0 - Server, 1 - Client, 2 - both.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the SDK message filter.</param>
        /// <param name="_sdkmessageidValue">Unique identifier of the related
        /// SDK message.</param>
        /// <param name="customizationlevel">Customization level of the SDK
        /// message filter.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the sdkmessagefilter.</param>
        /// <param name="isvisible">Indicates whether the filter should be
        /// visible.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the sdkmessagefilter.</param>
        /// <param name="modifiedon">Date and time when the SDK message filter
        /// was last modified.</param>
        /// <param name="iscustomprocessingstepallowed">Indicates whether a
        /// custom SDK message processing step is allowed.</param>
        /// <param name="primaryobjecttypecode">Type of entity with which the
        /// SDK message filter is primarily associated.</param>
        /// <param name="workflowsdkstepenabled">Whether or not the SDK message
        /// can be called from a workflow.</param>
        /// <param name="secondaryobjecttypecode">Type of entity with which the
        /// SDK message filter is secondarily associated.</param>
        /// <param name="sdkmessagefilteridunique">Unique identifier of the SDK
        /// message filter.</param>
        /// <param name="sdkmessagefilterid">Unique identifier of the SDK
        /// message filter entity.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the SDK message filter.</param>
        public MicrosoftDynamicsCRMsdkmessagefilter(string _organizationidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? availability = default(int?), string _modifiedbyValue = default(string), string _sdkmessageidValue = default(string), int? customizationlevel = default(int?), string _modifiedonbehalfbyValue = default(string), bool? isvisible = default(bool?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), bool? iscustomprocessingstepallowed = default(bool?), string primaryobjecttypecode = default(string), string versionnumber = default(string), bool? workflowsdkstepenabled = default(bool?), string secondaryobjecttypecode = default(string), string sdkmessagefilteridunique = default(string), string sdkmessagefilterid = default(string), string _createdbyValue = default(string), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> sdkmessagefilteridSdkmessageprocessingstep = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstep>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsdkmessage sdkmessageid = default(MicrosoftDynamicsCRMsdkmessage), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._organizationidValue = _organizationidValue;
            Createdon = createdon;
            Availability = availability;
            this._modifiedbyValue = _modifiedbyValue;
            this._sdkmessageidValue = _sdkmessageidValue;
            Customizationlevel = customizationlevel;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Isvisible = isvisible;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            Iscustomprocessingstepallowed = iscustomprocessingstepallowed;
            Primaryobjecttypecode = primaryobjecttypecode;
            Versionnumber = versionnumber;
            Workflowsdkstepenabled = workflowsdkstepenabled;
            Secondaryobjecttypecode = secondaryobjecttypecode;
            Sdkmessagefilteridunique = sdkmessagefilteridunique;
            Sdkmessagefilterid = sdkmessagefilterid;
            this._createdbyValue = _createdbyValue;
            Organizationid = organizationid;
            SdkmessagefilteridSdkmessageprocessingstep = sdkmessagefilteridSdkmessageprocessingstep;
            Modifiedby = modifiedby;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Sdkmessageid = sdkmessageid;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// SDK message filter is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the SDK message filter was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets identifies where a method will be exposed. 0 - Server,
        /// 1 - Client, 2 - both.
        /// </summary>
        [JsonProperty(PropertyName = "availability")]
        public int? Availability { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// SDK message filter.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the related SDK message.
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessageid_value")]
        public string _sdkmessageidValue { get; set; }

        /// <summary>
        /// Gets or sets customization level of the SDK message filter.
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the sdkmessagefilter.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the filter should be visible.
        /// </summary>
        [JsonProperty(PropertyName = "isvisible")]
        public bool? Isvisible { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// sdkmessagefilter.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the SDK message filter was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets indicates whether a custom SDK message processing step
        /// is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "iscustomprocessingstepallowed")]
        public bool? Iscustomprocessingstepallowed { get; set; }

        /// <summary>
        /// Gets or sets type of entity with which the SDK message filter is
        /// primarily associated.
        /// </summary>
        [JsonProperty(PropertyName = "primaryobjecttypecode")]
        public string Primaryobjecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets whether or not the SDK message can be called from a
        /// workflow.
        /// </summary>
        [JsonProperty(PropertyName = "workflowsdkstepenabled")]
        public bool? Workflowsdkstepenabled { get; set; }

        /// <summary>
        /// Gets or sets type of entity with which the SDK message filter is
        /// secondarily associated.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryobjecttypecode")]
        public string Secondaryobjecttypecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the SDK message filter.
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessagefilteridunique")]
        public string Sdkmessagefilteridunique { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the SDK message filter entity.
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessagefilterid")]
        public string Sdkmessagefilterid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the SDK
        /// message filter.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessagefilterid_sdkmessageprocessingstep")]
        public IList<MicrosoftDynamicsCRMsdkmessageprocessingstep> SdkmessagefilteridSdkmessageprocessingstep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageid")]
        public MicrosoftDynamicsCRMsdkmessage Sdkmessageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}
