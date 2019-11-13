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
    /// Microsoft.Dynamics.CRM.entitlement
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlement
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMentitlement
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMentitlement
        /// class.
        /// </summary>
        /// <param name="decreaseremainingon">Select whether to decrease the
        /// remaining terms when the case is created or when it is
        /// resolved.</param>
        /// <param name="startdate">Enter the date when the entitlement
        /// starts.</param>
        /// <param name="statecode">For internal use only.</param>
        /// <param name="kbaccesslevel">Select the access someone will have to
        /// the knowledge base on the portal.</param>
        /// <param name="entitlementid">Unique identifier for entity
        /// instances</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="versionnumber">Version number of the entitlement
        /// item.</param>
        /// <param name="importsequencenumber">Unique identifier of the data
        /// import or data migration that created this record.</param>
        /// <param name="enddate">Enter the date when the entitlement
        /// ends.</param>
        /// <param name="_customeridValue">Choose a contact or account for
        /// which this entitlement has been defined.</param>
        /// <param name="restrictcasecreation">Tells whether case creation is
        /// restricted based on entitlement terms.</param>
        /// <param name="isdefault">Shows whether this entitlement is the
        /// default one for the specified customer.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the contact with respect to the base
        /// currency.</param>
        /// <param name="allocationtypecode">Select the type of entitlement
        /// terms.</param>
        /// <param name="_accountidValue">Unique identifier for Account
        /// associated with Entitlement.</param>
        /// <param name="remainingterms">Type the total number of entitlement
        /// terms that are left.</param>
        /// <param name="_contactidValue">Unique identifier for Contact
        /// associated with Entitlement.</param>
        /// <param name="processid">Unique identifier of the Process.</param>
        /// <param name="description">Type additional information to describe
        /// the Entitlement</param>
        /// <param name="_transactioncurrencyidValue">Unique identifier of the
        /// currency associated with the contact.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="_slaidValue">Choose the service level agreement (SLA)
        /// associated with the entitlement.</param>
        /// <param name="createdon">Date and time when the entitlement was
        /// created.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="statuscode">Select the reason code that explains the
        /// status of the entitlement.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="totalterms">Type the total number of entitlement
        /// terms.</param>
        /// <param name="_owneridValue">Enter the user or team who owns the
        /// entitlement. This field is updated every time the item is assigned
        /// to a different user.</param>
        /// <param name="stageid">Unique identifier of the Stage.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="traversedpath">For internal use only.</param>
        /// <param name="_entitlementtemplateidValue">Unique identifier for
        /// Entitlement Template associated with Entitlement.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the entitlement.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="name">Type a meaningful name for the
        /// entitlement.</param>
        public MicrosoftDynamicsCRMentitlement(int? decreaseremainingon = default(int?), System.DateTimeOffset? startdate = default(System.DateTimeOffset?), int? statecode = default(int?), int? kbaccesslevel = default(int?), string entitlementid = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string versionnumber = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? enddate = default(System.DateTimeOffset?), string _customeridValue = default(string), bool? restrictcasecreation = default(bool?), bool? isdefault = default(bool?), string _owningteamValue = default(string), decimal? exchangerate = default(decimal?), int? allocationtypecode = default(int?), string _accountidValue = default(string), decimal? remainingterms = default(decimal?), string _contactidValue = default(string), string processid = default(string), string description = default(string), string _transactioncurrencyidValue = default(string), string _owningbusinessunitValue = default(string), string _slaidValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _owninguserValue = default(string), int? statuscode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), decimal? totalterms = default(decimal?), string _owneridValue = default(string), string stageid = default(string), int? utcconversiontimezonecode = default(int?), string _modifiedonbehalfbyValue = default(string), string traversedpath = default(string), string _entitlementtemplateidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), string name = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> entitlementActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> entitlementAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> entitlementEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> entitlementFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> entitlementLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> entitlementPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> entitlementServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> entitlementTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> entitlementRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMconnection> entitlementConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> entitlementConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> entitlementAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> entitlementAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> entitlementBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMentitlementchannel> entitlementEntitlementchannelEntitlementId = default(IList<MicrosoftDynamicsCRMentitlementchannel>), IList<MicrosoftDynamicsCRMproduct> productEntitlementAssociation = default(IList<MicrosoftDynamicsCRMproduct>), MicrosoftDynamicsCRMentitlementtemplate entitlementtemplateid = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMaccount accountid = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact contactid = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsocialactivity> entitlementSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), MicrosoftDynamicsCRMsla slaid = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMcontact> entitlementcontactsAssociation = default(IList<MicrosoftDynamicsCRMcontact>), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMincident> entitlementCases = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMsyncerror> entitlementSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> entitlementAbsScheduledprocessexecutions = default(IList<MicrosoftDynamicsCRMabsScheduledprocessexecution>))
        {
            Decreaseremainingon = decreaseremainingon;
            Startdate = startdate;
            Statecode = statecode;
            Kbaccesslevel = kbaccesslevel;
            Entitlementid = entitlementid;
            Modifiedon = modifiedon;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            Enddate = enddate;
            this._customeridValue = _customeridValue;
            Restrictcasecreation = restrictcasecreation;
            Isdefault = isdefault;
            this._owningteamValue = _owningteamValue;
            Exchangerate = exchangerate;
            Allocationtypecode = allocationtypecode;
            this._accountidValue = _accountidValue;
            Remainingterms = remainingterms;
            this._contactidValue = _contactidValue;
            Processid = processid;
            Description = description;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._slaidValue = _slaidValue;
            Createdon = createdon;
            this._owninguserValue = _owninguserValue;
            Statuscode = statuscode;
            Overriddencreatedon = overriddencreatedon;
            Totalterms = totalterms;
            this._owneridValue = _owneridValue;
            Stageid = stageid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Traversedpath = traversedpath;
            this._entitlementtemplateidValue = _entitlementtemplateidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Name = name;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            EntitlementActivityPointers = entitlementActivityPointers;
            EntitlementAppointments = entitlementAppointments;
            EntitlementEmails = entitlementEmails;
            EntitlementFaxes = entitlementFaxes;
            EntitlementLetters = entitlementLetters;
            EntitlementPhoneCalls = entitlementPhoneCalls;
            EntitlementServiceAppointments = entitlementServiceAppointments;
            EntitlementTasks = entitlementTasks;
            EntitlementRecurringAppointmentMasters = entitlementRecurringAppointmentMasters;
            EntitlementConnections1 = entitlementConnections1;
            EntitlementConnections2 = entitlementConnections2;
            EntitlementDuplicateMatchingRecord = entitlementDuplicateMatchingRecord;
            EntitlementDuplicateBaseRecord = entitlementDuplicateBaseRecord;
            EntitlementAnnotations = entitlementAnnotations;
            EntitlementAsyncOperations = entitlementAsyncOperations;
            EntitlementBulkDeleteFailures = entitlementBulkDeleteFailures;
            CustomeridAccount = customeridAccount;
            EntitlementEntitlementchannelEntitlementId = entitlementEntitlementchannelEntitlementId;
            ProductEntitlementAssociation = productEntitlementAssociation;
            Entitlementtemplateid = entitlementtemplateid;
            Accountid = accountid;
            Contactid = contactid;
            Transactioncurrencyid = transactioncurrencyid;
            EntitlementSocialActivities = entitlementSocialActivities;
            Slaid = slaid;
            EntitlementcontactsAssociation = entitlementcontactsAssociation;
            CustomeridContact = customeridContact;
            EntitlementCases = entitlementCases;
            EntitlementSyncErrors = entitlementSyncErrors;
            EntitlementAbsScheduledprocessexecutions = entitlementAbsScheduledprocessexecutions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets select whether to decrease the remaining terms when
        /// the case is created or when it is resolved.
        /// </summary>
        [JsonProperty(PropertyName = "decreaseremainingon")]
        public int? Decreaseremainingon { get; set; }

        /// <summary>
        /// Gets or sets enter the date when the entitlement starts.
        /// </summary>
        [JsonProperty(PropertyName = "startdate")]
        public System.DateTimeOffset? Startdate { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets select the access someone will have to the knowledge
        /// base on the portal.
        /// </summary>
        [JsonProperty(PropertyName = "kbaccesslevel")]
        public int? Kbaccesslevel { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "entitlementid")]
        public string Entitlementid { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets version number of the entitlement item.
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the data import or data migration
        /// that created this record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets enter the date when the entitlement ends.
        /// </summary>
        [JsonProperty(PropertyName = "enddate")]
        public System.DateTimeOffset? Enddate { get; set; }

        /// <summary>
        /// Gets or sets choose a contact or account for which this entitlement
        /// has been defined.
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// Gets or sets tells whether case creation is restricted based on
        /// entitlement terms.
        /// </summary>
        [JsonProperty(PropertyName = "restrictcasecreation")]
        public bool? Restrictcasecreation { get; set; }

        /// <summary>
        /// Gets or sets shows whether this entitlement is the default one for
        /// the specified customer.
        /// </summary>
        [JsonProperty(PropertyName = "isdefault")]
        public bool? Isdefault { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// contact with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets select the type of entitlement terms.
        /// </summary>
        [JsonProperty(PropertyName = "allocationtypecode")]
        public int? Allocationtypecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Account associated with
        /// Entitlement.
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// Gets or sets type the total number of entitlement terms that are
        /// left.
        /// </summary>
        [JsonProperty(PropertyName = "remainingterms")]
        public decimal? Remainingterms { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Contact associated with
        /// Entitlement.
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the Process.
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// Gets or sets type additional information to describe the
        /// Entitlement
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the currency associated with the
        /// contact.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets choose the service level agreement (SLA) associated
        /// with the entitlement.
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the entitlement was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets select the reason code that explains the status of the
        /// entitlement.
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets type the total number of entitlement terms.
        /// </summary>
        [JsonProperty(PropertyName = "totalterms")]
        public decimal? Totalterms { get; set; }

        /// <summary>
        /// Gets or sets enter the user or team who owns the entitlement. This
        /// field is updated every time the item is assigned to a different
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the Stage.
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Entitlement Template associated
        /// with Entitlement.
        /// </summary>
        [JsonProperty(PropertyName = "_entitlementtemplateid_value")]
        public string _entitlementtemplateidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// entitlement.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets type a meaningful name for the entitlement.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

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
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

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

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> EntitlementActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> EntitlementAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Emails")]
        public IList<MicrosoftDynamicsCRMemail> EntitlementEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> EntitlementFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Letters")]
        public IList<MicrosoftDynamicsCRMletter> EntitlementLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> EntitlementPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> EntitlementServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> EntitlementTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> EntitlementRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> EntitlementConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> EntitlementConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> EntitlementAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EntitlementAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EntitlementBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_entitlementchannel_EntitlementId")]
        public IList<MicrosoftDynamicsCRMentitlementchannel> EntitlementEntitlementchannelEntitlementId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_entitlement_association")]
        public IList<MicrosoftDynamicsCRMproduct> ProductEntitlementAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementtemplateid")]
        public MicrosoftDynamicsCRMentitlementtemplate Entitlementtemplateid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "accountid")]
        public MicrosoftDynamicsCRMaccount Accountid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactid")]
        public MicrosoftDynamicsCRMcontact Contactid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> EntitlementSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slaid")]
        public MicrosoftDynamicsCRMsla Slaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementcontacts_association")]
        public IList<MicrosoftDynamicsCRMcontact> EntitlementcontactsAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_cases")]
        public IList<MicrosoftDynamicsCRMincident> EntitlementCases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Entitlement_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> EntitlementSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlement_abs_scheduledprocessexecutions")]
        public IList<MicrosoftDynamicsCRMabsScheduledprocessexecution> EntitlementAbsScheduledprocessexecutions { get; set; }

    }
}
