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
    /// Microsoft.Dynamics.CRM.phonetocaseprocess
    /// </summary>
    public partial class MicrosoftDynamicsCRMphonetocaseprocess
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMphonetocaseprocess class.
        /// </summary>
        public MicrosoftDynamicsCRMphonetocaseprocess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMphonetocaseprocess class.
        /// </summary>
        /// <param name="_modifiedbyValue">Shows who last updated the
        /// record.</param>
        /// <param name="statecode">Shows whether the Delve action record is
        /// pending, completed, or tracking.</param>
        /// <param name="modifiedon">Shows the date and time when the record
        /// was last updated. The date and time are displayed in the time zone
        /// selected in Microsoft Dynamics CRM options.</param>
        /// <param name="traversedpath">Traversed Path</param>
        /// <param name="statuscode">Select the delve action record
        /// status.</param>
        /// <param name="businessprocessflowinstanceid">Unique identifier for
        /// Phone To Case Process bpf entity instances</param>
        /// <param name="duration">Duration between completed on and started
        /// on, used by business process flow.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="versionnumber">Version number of the business process
        /// instance.</param>
        /// <param name="_createdbyValue">Shows who created the record.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_transactioncurrencyidValue">Choose the local currency
        /// for the record to make sure budgets are reported in the correct
        /// currency.</param>
        /// <param name="exchangerate">Shows the conversion rate of the
        /// record's currency. The exchange rate is used to convert all money
        /// fields in the record from the local currency to the system's
        /// default currency.</param>
        /// <param name="_organizationidValue">Unique identifier of the
        /// organization with which the SDK message request is
        /// associated.</param>
        /// <param name="completedon">Date and time when Business Process Flow
        /// instance is completed.</param>
        /// <param name="activestagestartedon">Date and time when current
        /// active stage is started.</param>
        /// <param name="_modifiedonbehalfbyValue">Shows who last updated the
        /// record on behalf of another user.</param>
        /// <param name="_activestageidValue">Unique identifier of the active
        /// stage for the Business Process Flow instance.</param>
        /// <param name="name">Process Name.</param>
        /// <param name="_createdonbehalfbyValue">Shows who created the record
        /// on behalf of another user.</param>
        /// <param name="_incidentidValue">Unique identifier of the workflow
        /// associated to the Business Process Flow instance.</param>
        /// <param name="createdon">Shows the date and time when the record was
        /// created. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics CRM options.</param>
        /// <param name="_processidValue">Unique identifier of the
        /// PhoneToCaseProcess associated to the Business Process Flow
        /// instance.</param>
        public MicrosoftDynamicsCRMphonetocaseprocess(string _modifiedbyValue = default(string), int? statecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string traversedpath = default(string), int? statuscode = default(int?), string businessprocessflowinstanceid = default(string), int? duration = default(int?), int? importsequencenumber = default(int?), string versionnumber = default(string), string _createdbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), decimal? exchangerate = default(decimal?), string _organizationidValue = default(string), System.DateTimeOffset? completedon = default(System.DateTimeOffset?), System.DateTimeOffset? activestagestartedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _activestageidValue = default(string), string name = default(string), string _createdonbehalfbyValue = default(string), string _incidentidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _processidValue = default(string), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMincident incidentid = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMworkflowlog> workflowlogsPhonetocaseprocess = default(IList<MicrosoftDynamicsCRMworkflowlog>), MicrosoftDynamicsCRMprocessstage activestageid = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMsyncerror> phoneToCaseProcessSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser))
        {
            this._modifiedbyValue = _modifiedbyValue;
            Statecode = statecode;
            Modifiedon = modifiedon;
            Traversedpath = traversedpath;
            Statuscode = statuscode;
            Businessprocessflowinstanceid = businessprocessflowinstanceid;
            Duration = duration;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            this._createdbyValue = _createdbyValue;
            Overriddencreatedon = overriddencreatedon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Exchangerate = exchangerate;
            this._organizationidValue = _organizationidValue;
            Completedon = completedon;
            Activestagestartedon = activestagestartedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._activestageidValue = _activestageidValue;
            Name = name;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._incidentidValue = _incidentidValue;
            Createdon = createdon;
            this._processidValue = _processidValue;
            Transactioncurrencyid = transactioncurrencyid;
            Organizationid = organizationid;
            Createdbyname = createdbyname;
            Incidentid = incidentid;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Processid = processid;
            WorkflowlogsPhonetocaseprocess = workflowlogsPhonetocaseprocess;
            Activestageid = activestageid;
            PhoneToCaseProcessSyncErrors = phoneToCaseProcessSyncErrors;
            Modifiedbyname = modifiedbyname;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets shows who last updated the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets shows whether the Delve action record is pending,
        /// completed, or tracking.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was last
        /// updated. The date and time are displayed in the time zone selected
        /// in Microsoft Dynamics CRM options.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets traversed Path
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// Gets or sets select the delve action record status.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Phone To Case Process bpf entity
        /// instances
        /// </summary>
        [JsonProperty(PropertyName = "businessprocessflowinstanceid")]
        public string Businessprocessflowinstanceid { get; set; }

        /// <summary>
        /// Gets or sets duration between completed on and started on, used by
        /// business process flow.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets version number of the business process instance.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets choose the local currency for the record to make sure
        /// budgets are reported in the correct currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the conversion rate of the record's currency.
        /// The exchange rate is used to convert all money fields in the record
        /// from the local currency to the system's default currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// SDK message request is associated.
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when Business Process Flow instance is
        /// completed.
        /// </summary>
        [JsonProperty(PropertyName = "completedon")]
        public System.DateTimeOffset? Completedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when current active stage is started.
        /// </summary>
        [JsonProperty(PropertyName = "activestagestartedon")]
        public System.DateTimeOffset? Activestagestartedon { get; set; }

        /// <summary>
        /// Gets or sets shows who last updated the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the active stage for the Business
        /// Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_activestageid_value")]
        public string _activestageidValue { get; set; }

        /// <summary>
        /// Gets or sets process Name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets shows who created the record on behalf of another
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the workflow associated to the
        /// Business Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_incidentid_value")]
        public string _incidentidValue { get; set; }

        /// <summary>
        /// Gets or sets shows the date and time when the record was created.
        /// The date and time are displayed in the time zone selected in
        /// Microsoft Dynamics CRM options.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the PhoneToCaseProcess associated
        /// to the Business Process Flow instance.
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentid")]
        public MicrosoftDynamicsCRMincident Incidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "workflowlogs_phonetocaseprocess")]
        public IList<MicrosoftDynamicsCRMworkflowlog> WorkflowlogsPhonetocaseprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activestageid")]
        public MicrosoftDynamicsCRMprocessstage Activestageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PhoneToCaseProcess_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PhoneToCaseProcessSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

    }
}
