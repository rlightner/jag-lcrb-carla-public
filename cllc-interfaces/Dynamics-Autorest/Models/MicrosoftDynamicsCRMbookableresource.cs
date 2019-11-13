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
    /// Microsoft.Dynamics.CRM.bookableresource
    /// </summary>
    public partial class MicrosoftDynamicsCRMbookableresource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresource class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresource class.
        /// </summary>
        /// <param name="_owneridValue">Unique identifier of the user or team
        /// who owns the record.</param>
        /// <param name="_calendaridValue">Specifies the working days and hours
        /// of the resource.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="statuscode">Reason for the status of the Bookable
        /// Resource</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_accountidValue">Select the account that represents
        /// this resource.</param>
        /// <param name="resourcetype">Select whether the resource is a user,
        /// equipment, contact, account, generic resource or a group of
        /// resources.</param>
        /// <param name="_transactioncurrencyidValue">Exchange rate for the
        /// currency associated with the BookableResource with respect to the
        /// base currency.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="_useridValue">Select the user who represents this
        /// resource.</param>
        /// <param name="_contactidValue">Select the contact that represents
        /// this resource.</param>
        /// <param name="bookableresourceid">Unique identifier of the
        /// resource.</param>
        /// <param name="processid">Shows the ID of the process.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="timezone">Specifies the timezone for the resource's
        /// working hours.</param>
        /// <param name="statecode">Status of the Bookable Resource</param>
        /// <param name="stageid">Shows the ID of the stage.</param>
        /// <param name="traversedpath">For internal use only.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="name">Type the name of the resource.</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the bookableresource with respect to the base
        /// currency.</param>
        public MicrosoftDynamicsCRMbookableresource(string _owneridValue = default(string), string _calendaridValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), string _owninguserValue = default(string), string _modifiedbyValue = default(string), int? statuscode = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), string _accountidValue = default(string), int? resourcetype = default(int?), string _transactioncurrencyidValue = default(string), int? importsequencenumber = default(int?), string _owningbusinessunitValue = default(string), string _useridValue = default(string), string _contactidValue = default(string), string bookableresourceid = default(string), string processid = default(string), string _createdbyValue = default(string), int? timezone = default(int?), int? statecode = default(int?), string stageid = default(string), string traversedpath = default(string), string versionnumber = default(string), string _owningteamValue = default(string), string name = default(string), decimal? exchangerate = default(decimal?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourceDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourceDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> bookableresourceAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> bookableresourceAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bookableresourceBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount accountId = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact contactId = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMbookableresourcebooking> bookableresourceBookableresourcebookingResource = default(IList<MicrosoftDynamicsCRMbookableresourcebooking>), IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> bookableresourceBookableresourcecategoryassnResource = default(IList<MicrosoftDynamicsCRMbookableresourcecategoryassn>), IList<MicrosoftDynamicsCRMbookableresourcecharacteristic> bookableresourceBookableresourcecharacteristicResource = default(IList<MicrosoftDynamicsCRMbookableresourcecharacteristic>), IList<MicrosoftDynamicsCRMbookableresourcegroup> bookableresourceBookableresourcegroupChildResource = default(IList<MicrosoftDynamicsCRMbookableresourcegroup>), IList<MicrosoftDynamicsCRMbookableresourcegroup> bookableresourceBookableresourcegroupParentResource = default(IList<MicrosoftDynamicsCRMbookableresourcegroup>), MicrosoftDynamicsCRMsystemuser userId = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcalendar calendarid = default(MicrosoftDynamicsCRMcalendar), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMsyncerror> bookableResourceSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            this._owneridValue = _owneridValue;
            this._calendaridValue = _calendaridValue;
            Overriddencreatedon = overriddencreatedon;
            Modifiedon = modifiedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._accountidValue = _accountidValue;
            Resourcetype = resourcetype;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Importsequencenumber = importsequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._useridValue = _useridValue;
            this._contactidValue = _contactidValue;
            Bookableresourceid = bookableresourceid;
            Processid = processid;
            this._createdbyValue = _createdbyValue;
            Timezone = timezone;
            Statecode = statecode;
            Stageid = stageid;
            Traversedpath = traversedpath;
            Versionnumber = versionnumber;
            this._owningteamValue = _owningteamValue;
            Name = name;
            Exchangerate = exchangerate;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BookableresourceDuplicateMatchingRecord = bookableresourceDuplicateMatchingRecord;
            BookableresourceDuplicateBaseRecord = bookableresourceDuplicateBaseRecord;
            BookableresourceAnnotations = bookableresourceAnnotations;
            BookableresourceAsyncOperations = bookableresourceAsyncOperations;
            BookableresourceBulkDeleteFailures = bookableresourceBulkDeleteFailures;
            AccountId = accountId;
            ContactId = contactId;
            BookableresourceBookableresourcebookingResource = bookableresourceBookableresourcebookingResource;
            BookableresourceBookableresourcecategoryassnResource = bookableresourceBookableresourcecategoryassnResource;
            BookableresourceBookableresourcecharacteristicResource = bookableresourceBookableresourcecharacteristicResource;
            BookableresourceBookableresourcegroupChildResource = bookableresourceBookableresourcegroupChildResource;
            BookableresourceBookableresourcegroupParentResource = bookableresourceBookableresourcegroupParentResource;
            UserId = userId;
            Calendarid = calendarid;
            Transactioncurrencyid = transactioncurrencyid;
            BookableResourceSyncErrors = bookableResourceSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier of the user or team who owns the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// Gets or sets specifies the working days and hours of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "_calendarid_value")]
        public string _calendaridValue { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Bookable Resource
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets select the account that represents this resource.
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// Gets or sets select whether the resource is a user, equipment,
        /// contact, account, generic resource or a group of resources.
        /// </summary>
        [JsonProperty(PropertyName = "resourcetype")]
        public int? Resourcetype { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// BookableResource with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// Gets or sets select the user who represents this resource.
        /// </summary>
        [JsonProperty(PropertyName = "_userid_value")]
        public string _useridValue { get; set; }

        /// <summary>
        /// Gets or sets select the contact that represents this resource.
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourceid")]
        public string Bookableresourceid { get; set; }

        /// <summary>
        /// Gets or sets shows the ID of the process.
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets specifies the timezone for the resource's working
        /// hours.
        /// </summary>
        [JsonProperty(PropertyName = "timezone")]
        public int? Timezone { get; set; }

        /// <summary>
        /// Gets or sets status of the Bookable Resource
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets shows the ID of the stage.
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// Gets or sets type the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// bookableresource with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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
        [JsonProperty(PropertyName = "bookableresource_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourceDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourceDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BookableresourceAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BookableresourceAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BookableresourceBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccountId")]
        public MicrosoftDynamicsCRMaccount AccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactId")]
        public MicrosoftDynamicsCRMcontact ContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcebooking_Resource")]
        public IList<MicrosoftDynamicsCRMbookableresourcebooking> BookableresourceBookableresourcebookingResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcecategoryassn_Resource")]
        public IList<MicrosoftDynamicsCRMbookableresourcecategoryassn> BookableresourceBookableresourcecategoryassnResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcecharacteristic_Resource")]
        public IList<MicrosoftDynamicsCRMbookableresourcecharacteristic> BookableresourceBookableresourcecharacteristicResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcegroup_ChildResource")]
        public IList<MicrosoftDynamicsCRMbookableresourcegroup> BookableresourceBookableresourcegroupChildResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresource_bookableresourcegroup_ParentResource")]
        public IList<MicrosoftDynamicsCRMbookableresourcegroup> BookableresourceBookableresourcegroupParentResource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public MicrosoftDynamicsCRMsystemuser UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calendarid")]
        public MicrosoftDynamicsCRMcalendar Calendarid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BookableResource_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BookableResourceSyncErrors { get; set; }

    }
}
