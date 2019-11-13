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
    /// Microsoft.Dynamics.CRM.adoxio_tiedhouseconnection
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioTiedhouseconnection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTiedhouseconnection class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioTiedhouseconnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioTiedhouseconnection class.
        /// </summary>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="_adoxioAccountidValue">Unique identifier for Account
        /// associated with Tied House Connection.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="statuscode">Reason for the status of the Tied House
        /// Connection</param>
        /// <param name="statecode">Status of the Tied House Connection</param>
        /// <param name="adoxioTiedhouseconnectionid">Unique identifier for
        /// entity instances</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="_adoxioContactidValue">Unique identifier for Contact
        /// associated with Tied House Connection.</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        public MicrosoftDynamicsCRMadoxioTiedhouseconnection(int? adoxioShare20plusfamilyconnectionproducer = default(int?), string _modifiedonbehalfbyValue = default(string), string _owninguserValue = default(string), string _adoxioAccountidValue = default(string), int? adoxioSolepropconnectiontofederalproducer = default(int?), int? timezoneruleversionnumber = default(int?), string adoxioFederalproducername = default(string), int? adoxioCorpconnectionfederalproducer = default(int?), string adoxioMarketerconnectiontocrsdetails = default(string), int? adoxioAssociateconnectionfederalproducer = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioAssociateconnectionfederalproducerdetails = default(string), string adoxioSharetype = default(string), int? adoxioFederalproducerconnectiontocorp = default(int?), string adoxioPartnersconnectionfederalproducerdetails = default(string), string adoxioShare20plusfamilyconnectionproducerdetail = default(string), int? adoxioSocietyconnectionfederalproducer = default(int?), string adoxioFamilymemberfederalproducerdetails = default(string), int? adoxioInconnectiontofederalproducer = default(int?), string _owneridValue = default(string), string adoxioCrsconnectiontomarketerdetails = default(string), int? statuscode = default(int?), int? adoxioPartnersconnectionfederalproducer = default(int?), int? adoxioFamilymemberfederalproducer = default(int?), int? adoxioIsconnection = default(int?), int? statecode = default(int?), string adoxioTiedhouseconnectionid = default(string), string _owningbusinessunitValue = default(string), int? adoxioConnectiontype = default(int?), int? adoxioMarketerconnectiontocrs = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string versionnumber = default(string), string adoxioSocietyconnectionfederalproducerdetails = default(string), string _createdonbehalfbyValue = default(string), int? importsequencenumber = default(int?), int? adoxioCrsconnectiontomarketer = default(int?), string adoxioFederalproducerconnectiontocorpdetails = default(string), string _createdbyValue = default(string), string adoxioShare20plusconnectionproducerdetails = default(string), string adoxioSolepropconnectiontofederalproducerdetail = default(string), string _adoxioContactidValue = default(string), string adoxioCorpconnectionfederalproducerdetails = default(string), int? adoxioOwnershiptype = default(int?), int? adoxioPercentageofownership = default(int?), string adoxioName = default(string), string _modifiedbyValue = default(string), int? utcconversiontimezonecode = default(int?), string adoxioInconnectiontofederalproducerdetails = default(string), int? adoxioShare20plusconnectionproducer = default(int?), string adoxioAdditionaldetails = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _owningteamValue = default(string), string _adoxioApplicationValue = default(string), string _adoxioTiedhouseValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioTiedhouseconnectionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTiedhouseconnectionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioTiedhouseconnectionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioTiedhouseconnectionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioTiedhouseconnectionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount adoxioAccountId = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioApplication adoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMcontact adoxioContactId = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioTiedhouseassociation adoxioTiedHouse = default(MicrosoftDynamicsCRMadoxioTiedhouseassociation))
        {
            AdoxioShare20plusfamilyconnectionproducer = adoxioShare20plusfamilyconnectionproducer;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owninguserValue = _owninguserValue;
            this._adoxioAccountidValue = _adoxioAccountidValue;
            AdoxioSolepropconnectiontofederalproducer = adoxioSolepropconnectiontofederalproducer;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioFederalproducername = adoxioFederalproducername;
            AdoxioCorpconnectionfederalproducer = adoxioCorpconnectionfederalproducer;
            AdoxioMarketerconnectiontocrsdetails = adoxioMarketerconnectiontocrsdetails;
            AdoxioAssociateconnectionfederalproducer = adoxioAssociateconnectionfederalproducer;
            Modifiedon = modifiedon;
            AdoxioAssociateconnectionfederalproducerdetails = adoxioAssociateconnectionfederalproducerdetails;
            AdoxioSharetype = adoxioSharetype;
            AdoxioFederalproducerconnectiontocorp = adoxioFederalproducerconnectiontocorp;
            AdoxioPartnersconnectionfederalproducerdetails = adoxioPartnersconnectionfederalproducerdetails;
            AdoxioShare20plusfamilyconnectionproducerdetail = adoxioShare20plusfamilyconnectionproducerdetail;
            AdoxioSocietyconnectionfederalproducer = adoxioSocietyconnectionfederalproducer;
            AdoxioFamilymemberfederalproducerdetails = adoxioFamilymemberfederalproducerdetails;
            AdoxioInconnectiontofederalproducer = adoxioInconnectiontofederalproducer;
            this._owneridValue = _owneridValue;
            AdoxioCrsconnectiontomarketerdetails = adoxioCrsconnectiontomarketerdetails;
            Statuscode = statuscode;
            AdoxioPartnersconnectionfederalproducer = adoxioPartnersconnectionfederalproducer;
            AdoxioFamilymemberfederalproducer = adoxioFamilymemberfederalproducer;
            AdoxioIsconnection = adoxioIsconnection;
            Statecode = statecode;
            AdoxioTiedhouseconnectionid = adoxioTiedhouseconnectionid;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioConnectiontype = adoxioConnectiontype;
            AdoxioMarketerconnectiontocrs = adoxioMarketerconnectiontocrs;
            Createdon = createdon;
            Versionnumber = versionnumber;
            AdoxioSocietyconnectionfederalproducerdetails = adoxioSocietyconnectionfederalproducerdetails;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            AdoxioCrsconnectiontomarketer = adoxioCrsconnectiontomarketer;
            AdoxioFederalproducerconnectiontocorpdetails = adoxioFederalproducerconnectiontocorpdetails;
            this._createdbyValue = _createdbyValue;
            AdoxioShare20plusconnectionproducerdetails = adoxioShare20plusconnectionproducerdetails;
            AdoxioSolepropconnectiontofederalproducerdetail = adoxioSolepropconnectiontofederalproducerdetail;
            this._adoxioContactidValue = _adoxioContactidValue;
            AdoxioCorpconnectionfederalproducerdetails = adoxioCorpconnectionfederalproducerdetails;
            AdoxioOwnershiptype = adoxioOwnershiptype;
            AdoxioPercentageofownership = adoxioPercentageofownership;
            AdoxioName = adoxioName;
            this._modifiedbyValue = _modifiedbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioInconnectiontofederalproducerdetails = adoxioInconnectiontofederalproducerdetails;
            AdoxioShare20plusconnectionproducer = adoxioShare20plusconnectionproducer;
            AdoxioAdditionaldetails = adoxioAdditionaldetails;
            Overriddencreatedon = overriddencreatedon;
            this._owningteamValue = _owningteamValue;
            this._adoxioApplicationValue = _adoxioApplicationValue;
            this._adoxioTiedhouseValue = _adoxioTiedhouseValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioTiedhouseconnectionSyncErrors = adoxioTiedhouseconnectionSyncErrors;
            AdoxioTiedhouseconnectionDuplicateMatchingRecord = adoxioTiedhouseconnectionDuplicateMatchingRecord;
            AdoxioTiedhouseconnectionDuplicateBaseRecord = adoxioTiedhouseconnectionDuplicateBaseRecord;
            AdoxioTiedhouseconnectionAsyncOperations = adoxioTiedhouseconnectionAsyncOperations;
            AdoxioTiedhouseconnectionBulkDeleteFailures = adoxioTiedhouseconnectionBulkDeleteFailures;
            AdoxioAccountId = adoxioAccountId;
            AdoxioApplication = adoxioApplication;
            AdoxioContactId = adoxioContactId;
            AdoxioTiedHouse = adoxioTiedHouse;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_share20plusfamilyconnectionproducer")]
        public int? AdoxioShare20plusfamilyconnectionproducer { get; set; }

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
        /// Gets or sets unique identifier for Account associated with Tied
        /// House Connection.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_accountid_value")]
        public string _adoxioAccountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_solepropconnectiontofederalproducer")]
        public int? AdoxioSolepropconnectiontofederalproducer { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalproducername")]
        public string AdoxioFederalproducername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corpconnectionfederalproducer")]
        public int? AdoxioCorpconnectionfederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_marketerconnectiontocrsdetails")]
        public string AdoxioMarketerconnectiontocrsdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_associateconnectionfederalproducer")]
        public int? AdoxioAssociateconnectionfederalproducer { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_associateconnectionfederalproducerdetails")]
        public string AdoxioAssociateconnectionfederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sharetype")]
        public string AdoxioSharetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalproducerconnectiontocorp")]
        public int? AdoxioFederalproducerconnectiontocorp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_partnersconnectionfederalproducerdetails")]
        public string AdoxioPartnersconnectionfederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_share20plusfamilyconnectionproducerdetail")]
        public string AdoxioShare20plusfamilyconnectionproducerdetail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_societyconnectionfederalproducer")]
        public int? AdoxioSocietyconnectionfederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_familymemberfederalproducerdetails")]
        public string AdoxioFamilymemberfederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_inconnectiontofederalproducer")]
        public int? AdoxioInconnectiontofederalproducer { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_crsconnectiontomarketerdetails")]
        public string AdoxioCrsconnectiontomarketerdetails { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Tied House Connection
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_partnersconnectionfederalproducer")]
        public int? AdoxioPartnersconnectionfederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_familymemberfederalproducer")]
        public int? AdoxioFamilymemberfederalproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isconnection")]
        public int? AdoxioIsconnection { get; set; }

        /// <summary>
        /// Gets or sets status of the Tied House Connection
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnectionid")]
        public string AdoxioTiedhouseconnectionid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_connectiontype")]
        public int? AdoxioConnectiontype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_marketerconnectiontocrs")]
        public int? AdoxioMarketerconnectiontocrs { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_societyconnectionfederalproducerdetails")]
        public string AdoxioSocietyconnectionfederalproducerdetails { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_crsconnectiontomarketer")]
        public int? AdoxioCrsconnectiontomarketer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_federalproducerconnectiontocorpdetails")]
        public string AdoxioFederalproducerconnectiontocorpdetails { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_share20plusconnectionproducerdetails")]
        public string AdoxioShare20plusconnectionproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_solepropconnectiontofederalproducerdetail")]
        public string AdoxioSolepropconnectiontofederalproducerdetail { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Contact associated with Tied
        /// House Connection.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_contactid_value")]
        public string _adoxioContactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_corpconnectionfederalproducerdetails")]
        public string AdoxioCorpconnectionfederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ownershiptype")]
        public int? AdoxioOwnershiptype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_percentageofownership")]
        public int? AdoxioPercentageofownership { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_inconnectiontofederalproducerdetails")]
        public string AdoxioInconnectiontofederalproducerdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_share20plusconnectionproducer")]
        public int? AdoxioShare20plusconnectionproducer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_additionaldetails")]
        public string AdoxioAdditionaldetails { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_application_value")]
        public string _adoxioApplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_tiedhouse_value")]
        public string _adoxioTiedhouseValue { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioTiedhouseconnectionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTiedhouseconnectionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioTiedhouseconnectionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioTiedhouseconnectionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tiedhouseconnection_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioTiedhouseconnectionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_AccountId")]
        public MicrosoftDynamicsCRMaccount AdoxioAccountId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Application")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ContactId")]
        public MicrosoftDynamicsCRMcontact AdoxioContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_TiedHouse")]
        public MicrosoftDynamicsCRMadoxioTiedhouseassociation AdoxioTiedHouse { get; set; }

    }
}
