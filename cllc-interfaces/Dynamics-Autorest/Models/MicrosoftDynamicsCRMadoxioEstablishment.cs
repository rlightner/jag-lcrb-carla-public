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
    /// Microsoft.Dynamics.CRM.adoxio_establishment
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioEstablishment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEstablishment class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioEstablishment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioEstablishment class.
        /// </summary>
        /// <param name="_adoxioLicencetypeidValue">Unique identifier for
        /// Licence Type associated with Establishment.</param>
        /// <param name="adoxioEstablishmentid">Unique identifier for entity
        /// instances</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="_owneridValue">Owner Id</param>
        /// <param name="_adoxioPrimaryinspectoridValue">Unique identifier for
        /// User associated with Establishment.</param>
        /// <param name="_owninguserValue">Unique identifier for the user that
        /// owns the record.</param>
        /// <param name="_owningteamValue">Unique identifier for the team that
        /// owns the record.</param>
        /// <param name="adoxioLocatedatwinery">Is your establishment located
        /// at a winery, brewery, or distillery?</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_owningbusinessunitValue">Unique identifier for the
        /// business unit that owns the record</param>
        /// <param name="_adoxioRegionidValue">Unique identifier for Region
        /// associated with Establishment.</param>
        /// <param name="adoxioName">The name of the custom entity.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="statuscode">Reason for the status of the
        /// Establishment</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="versionnumber">Version Number</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="statecode">Status of the Establishment</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        public MicrosoftDynamicsCRMadoxioEstablishment(System.Guid? _adoxioLicencetypeidValue = default(System.Guid?), System.Guid? adoxioEstablishmentid = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), string adoxioLongitude = default(string), System.Guid? _owneridValue = default(System.Guid?), int? adoxioMondayclose = default(int?), int? adoxioSaturdayclose = default(int?), System.Guid? _adoxioPrimaryinspectoridValue = default(System.Guid?), bool? adoxioLocatedonfirstnationland = default(bool?), System.Guid? _owninguserValue = default(System.Guid?), int? adoxioIsoninland = default(int?), int? adoxioSendmailtoestablishmentuponapproval = default(int?), System.Guid? _owningteamValue = default(System.Guid?), int? adoxioSundayclose = default(int?), string adoxioLatitude = default(string), string adoxioParcelid = default(string), bool? adoxioLocatedatwinery = default(bool?), int? adoxioSundayopen = default(int?), int? adoxioTuesdayclose = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? adoxioOccupantcapacity = default(int?), System.Guid? _owningbusinessunitValue = default(System.Guid?), System.Guid? _adoxioLginValue = default(System.Guid?), System.Guid? _adoxioRegionidValue = default(System.Guid?), int? adoxioSaturdayopen = default(int?), int? adoxioMondayopen = default(int?), string adoxioAddressstreet = default(string), int? adoxioThursdayclose = default(int?), string adoxioName = default(string), bool? adoxioPatronparticipation = default(bool?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? _adoxioLicenceeValue = default(System.Guid?), System.DateTimeOffset? adoxioExpectedopendate = default(System.DateTimeOffset?), System.Guid? _adoxioTerritoryValue = default(System.Guid?), int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), System.Guid? _adoxioPdjurisdictionValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? adoxioWednesdayclose = default(int?), string adoxioAddresscity = default(string), int? adoxioFridayopen = default(int?), System.Guid? _modifiedbyValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? adoxioOccupantload = default(int?), string versionnumber = default(string), bool? adoxioAlreadyopen = default(bool?), bool? adoxioIsstandalonepatio = default(bool?), int? adoxioTuesdayopen = default(int?), bool? adoxioStandardhours = default(bool?), bool? adoxioHasduallicence = default(bool?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), string adoxioPhone = default(string), int? timezoneruleversionnumber = default(int?), System.Guid? _adoxioAreaValue = default(System.Guid?), string adoxioEmail = default(string), int? statecode = default(int?), int? adoxioThursdayopen = default(int?), bool? adoxioMailsenttorestaurant = default(bool?), int? importsequencenumber = default(int?), string adoxioAddresspostalcode = default(string), int? adoxioWednesdayopen = default(int?), int? adoxioFridayclose = default(int?), int? adoxioIsrural = default(int?), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioEstablishmentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioEstablishmentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioEstablishmentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioEstablishmentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioEstablishmentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount adoxioLicencee = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioAdoxioEstablishmentAdoxioApplicationEstablishment = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioInvestigation> adoxioAdoxioEstablishmentAdoxioInvestigationEstablishment = default(IList<MicrosoftDynamicsCRMadoxioInvestigation>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioAdoxioEstablishmentAdoxioLicencesEstablishment = default(IList<MicrosoftDynamicsCRMadoxioLicences>), IList<MicrosoftDynamicsCRMcontact> adoxioAdoxioEstablishmentContactEstablishment = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMincident> adoxioAdoxioEstablishmentIncidentEstablishment = default(IList<MicrosoftDynamicsCRMincident>), MicrosoftDynamicsCRMadoxioTerritory adoxioTerritory = default(MicrosoftDynamicsCRMadoxioTerritory), MicrosoftDynamicsCRMadoxioArea adoxioArea = default(MicrosoftDynamicsCRMadoxioArea), MicrosoftDynamicsCRMadoxioLicencetype adoxioLicenceTypeId = default(MicrosoftDynamicsCRMadoxioLicencetype), MicrosoftDynamicsCRMadoxioLocalgovindigenousnation adoxioLGIN = default(MicrosoftDynamicsCRMadoxioLocalgovindigenousnation), MicrosoftDynamicsCRMadoxioPolicejurisdiction adoxioPDJurisdiction = default(MicrosoftDynamicsCRMadoxioPolicejurisdiction), MicrosoftDynamicsCRMsystemuser adoxioPrimaryInspectorId = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMadoxioContravention> adoxioEstablishmentContraventions = default(IList<MicrosoftDynamicsCRMadoxioContravention>), IList<MicrosoftDynamicsCRMadoxioComplaint> adoxioEstablishmentComplaints = default(IList<MicrosoftDynamicsCRMadoxioComplaint>), IList<MicrosoftDynamicsCRMadoxioCompliancemeeting> adoxioEstablishmentCompliancemeetings = default(IList<MicrosoftDynamicsCRMadoxioCompliancemeeting>), IList<MicrosoftDynamicsCRMadoxioComplianceinvestigation> adoxioEstablishmentInvestigations = default(IList<MicrosoftDynamicsCRMadoxioComplianceinvestigation>), IList<MicrosoftDynamicsCRMadoxioCannabismonthlyreport> adoxioEstablishmentCannabismonthlyreports = default(IList<MicrosoftDynamicsCRMadoxioCannabismonthlyreport>), IList<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> adoxioEstablishmentInventoryreports = default(IList<MicrosoftDynamicsCRMadoxioCannabisinventoryreport>), MicrosoftDynamicsCRMadoxioRegion adoxioRegionId = default(MicrosoftDynamicsCRMadoxioRegion))
        {
            this._adoxioLicencetypeidValue = _adoxioLicencetypeidValue;
            AdoxioEstablishmentid = adoxioEstablishmentid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioLongitude = adoxioLongitude;
            this._owneridValue = _owneridValue;
            AdoxioMondayclose = adoxioMondayclose;
            AdoxioSaturdayclose = adoxioSaturdayclose;
            this._adoxioPrimaryinspectoridValue = _adoxioPrimaryinspectoridValue;
            AdoxioLocatedonfirstnationland = adoxioLocatedonfirstnationland;
            this._owninguserValue = _owninguserValue;
            AdoxioIsoninland = adoxioIsoninland;
            AdoxioSendmailtoestablishmentuponapproval = adoxioSendmailtoestablishmentuponapproval;
            this._owningteamValue = _owningteamValue;
            AdoxioSundayclose = adoxioSundayclose;
            AdoxioLatitude = adoxioLatitude;
            AdoxioParcelid = adoxioParcelid;
            AdoxioLocatedatwinery = adoxioLocatedatwinery;
            AdoxioSundayopen = adoxioSundayopen;
            AdoxioTuesdayclose = adoxioTuesdayclose;
            Overriddencreatedon = overriddencreatedon;
            AdoxioOccupantcapacity = adoxioOccupantcapacity;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._adoxioLginValue = _adoxioLginValue;
            this._adoxioRegionidValue = _adoxioRegionidValue;
            AdoxioSaturdayopen = adoxioSaturdayopen;
            AdoxioMondayopen = adoxioMondayopen;
            AdoxioAddressstreet = adoxioAddressstreet;
            AdoxioThursdayclose = adoxioThursdayclose;
            AdoxioName = adoxioName;
            AdoxioPatronparticipation = adoxioPatronparticipation;
            this._createdbyValue = _createdbyValue;
            this._adoxioLicenceeValue = _adoxioLicenceeValue;
            AdoxioExpectedopendate = adoxioExpectedopendate;
            this._adoxioTerritoryValue = _adoxioTerritoryValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            this._adoxioPdjurisdictionValue = _adoxioPdjurisdictionValue;
            Createdon = createdon;
            AdoxioWednesdayclose = adoxioWednesdayclose;
            AdoxioAddresscity = adoxioAddresscity;
            AdoxioFridayopen = adoxioFridayopen;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            AdoxioOccupantload = adoxioOccupantload;
            Versionnumber = versionnumber;
            AdoxioAlreadyopen = adoxioAlreadyopen;
            AdoxioIsstandalonepatio = adoxioIsstandalonepatio;
            AdoxioTuesdayopen = adoxioTuesdayopen;
            AdoxioStandardhours = adoxioStandardhours;
            AdoxioHasduallicence = adoxioHasduallicence;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioPhone = adoxioPhone;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._adoxioAreaValue = _adoxioAreaValue;
            AdoxioEmail = adoxioEmail;
            Statecode = statecode;
            AdoxioThursdayopen = adoxioThursdayopen;
            AdoxioMailsenttorestaurant = adoxioMailsenttorestaurant;
            Importsequencenumber = importsequencenumber;
            AdoxioAddresspostalcode = adoxioAddresspostalcode;
            AdoxioWednesdayopen = adoxioWednesdayopen;
            AdoxioFridayclose = adoxioFridayclose;
            AdoxioIsrural = adoxioIsrural;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioEstablishmentSyncErrors = adoxioEstablishmentSyncErrors;
            AdoxioEstablishmentDuplicateMatchingRecord = adoxioEstablishmentDuplicateMatchingRecord;
            AdoxioEstablishmentDuplicateBaseRecord = adoxioEstablishmentDuplicateBaseRecord;
            AdoxioEstablishmentAsyncOperations = adoxioEstablishmentAsyncOperations;
            AdoxioEstablishmentBulkDeleteFailures = adoxioEstablishmentBulkDeleteFailures;
            AdoxioLicencee = adoxioLicencee;
            AdoxioAdoxioEstablishmentAdoxioApplicationEstablishment = adoxioAdoxioEstablishmentAdoxioApplicationEstablishment;
            AdoxioAdoxioEstablishmentAdoxioInvestigationEstablishment = adoxioAdoxioEstablishmentAdoxioInvestigationEstablishment;
            AdoxioAdoxioEstablishmentAdoxioLicencesEstablishment = adoxioAdoxioEstablishmentAdoxioLicencesEstablishment;
            AdoxioAdoxioEstablishmentContactEstablishment = adoxioAdoxioEstablishmentContactEstablishment;
            AdoxioAdoxioEstablishmentIncidentEstablishment = adoxioAdoxioEstablishmentIncidentEstablishment;
            AdoxioTerritory = adoxioTerritory;
            AdoxioArea = adoxioArea;
            AdoxioLicenceTypeId = adoxioLicenceTypeId;
            AdoxioLGIN = adoxioLGIN;
            AdoxioPDJurisdiction = adoxioPDJurisdiction;
            AdoxioPrimaryInspectorId = adoxioPrimaryInspectorId;
            AdoxioEstablishmentContraventions = adoxioEstablishmentContraventions;
            AdoxioEstablishmentComplaints = adoxioEstablishmentComplaints;
            AdoxioEstablishmentCompliancemeetings = adoxioEstablishmentCompliancemeetings;
            AdoxioEstablishmentInvestigations = adoxioEstablishmentInvestigations;
            AdoxioEstablishmentCannabismonthlyreports = adoxioEstablishmentCannabismonthlyreports;
            AdoxioEstablishmentInventoryreports = adoxioEstablishmentInventoryreports;
            AdoxioRegionId = adoxioRegionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier for Licence Type associated with
        /// Establishment.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencetypeid_value")]
        public System.Guid? _adoxioLicencetypeidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for entity instances
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishmentid")]
        public System.Guid? AdoxioEstablishmentid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_longitude")]
        public string AdoxioLongitude { get; set; }

        /// <summary>
        /// Gets or sets owner Id
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public System.Guid? _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_mondayclose")]
        public int? AdoxioMondayclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_saturdayclose")]
        public int? AdoxioSaturdayclose { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for User associated with
        /// Establishment.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_primaryinspectorid_value")]
        public System.Guid? _adoxioPrimaryinspectoridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_locatedonfirstnationland")]
        public bool? AdoxioLocatedonfirstnationland { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the user that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public System.Guid? _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isoninland")]
        public int? AdoxioIsoninland { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sendmailtoestablishmentuponapproval")]
        public int? AdoxioSendmailtoestablishmentuponapproval { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the team that owns the record.
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public System.Guid? _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sundayclose")]
        public int? AdoxioSundayclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_latitude")]
        public string AdoxioLatitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_parcelid")]
        public string AdoxioParcelid { get; set; }

        /// <summary>
        /// Gets or sets is your establishment located at a winery, brewery, or
        /// distillery?
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_locatedatwinery")]
        public bool? AdoxioLocatedatwinery { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_sundayopen")]
        public int? AdoxioSundayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tuesdayclose")]
        public int? AdoxioTuesdayclose { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_occupantcapacity")]
        public int? AdoxioOccupantcapacity { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the business unit that owns the
        /// record
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public System.Guid? _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_lgin_value")]
        public System.Guid? _adoxioLginValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for Region associated with
        /// Establishment.
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_regionid_value")]
        public System.Guid? _adoxioRegionidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_saturdayopen")]
        public int? AdoxioSaturdayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_mondayopen")]
        public int? AdoxioMondayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addressstreet")]
        public string AdoxioAddressstreet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thursdayclose")]
        public int? AdoxioThursdayclose { get; set; }

        /// <summary>
        /// Gets or sets the name of the custom entity.
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_patronparticipation")]
        public bool? AdoxioPatronparticipation { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencee_value")]
        public System.Guid? _adoxioLicenceeValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_expectedopendate")]
        public System.DateTimeOffset? AdoxioExpectedopendate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_territory_value")]
        public System.Guid? _adoxioTerritoryValue { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Establishment
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_pdjurisdiction_value")]
        public System.Guid? _adoxioPdjurisdictionValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_wednesdayclose")]
        public int? AdoxioWednesdayclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addresscity")]
        public string AdoxioAddresscity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fridayopen")]
        public int? AdoxioFridayopen { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_occupantload")]
        public int? AdoxioOccupantload { get; set; }

        /// <summary>
        /// Gets or sets version Number
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_alreadyopen")]
        public bool? AdoxioAlreadyopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isstandalonepatio")]
        public bool? AdoxioIsstandalonepatio { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_tuesdayopen")]
        public int? AdoxioTuesdayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_standardhours")]
        public bool? AdoxioStandardhours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_hasduallicence")]
        public bool? AdoxioHasduallicence { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phone")]
        public string AdoxioPhone { get; set; }

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_area_value")]
        public System.Guid? _adoxioAreaValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// Gets or sets status of the Establishment
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_thursdayopen")]
        public int? AdoxioThursdayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_mailsenttorestaurant")]
        public bool? AdoxioMailsenttorestaurant { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_addresspostalcode")]
        public string AdoxioAddresspostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_wednesdayopen")]
        public int? AdoxioWednesdayopen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fridayclose")]
        public int? AdoxioFridayclose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isrural")]
        public int? AdoxioIsrural { get; set; }

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
        [JsonProperty(PropertyName = "adoxio_establishment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioEstablishmentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioEstablishmentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioEstablishmentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioEstablishmentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioEstablishmentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Licencee")]
        public MicrosoftDynamicsCRMaccount AdoxioLicencee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_establishment_adoxio_application_Establishment")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioAdoxioEstablishmentAdoxioApplicationEstablishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_establishment_adoxio_investigation_Establishment")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigation> AdoxioAdoxioEstablishmentAdoxioInvestigationEstablishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_establishment_adoxio_licences_establishment")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioAdoxioEstablishmentAdoxioLicencesEstablishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_establishment_contact_Establishment")]
        public IList<MicrosoftDynamicsCRMcontact> AdoxioAdoxioEstablishmentContactEstablishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_establishment_incident_Establishment")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioAdoxioEstablishmentIncidentEstablishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Territory")]
        public MicrosoftDynamicsCRMadoxioTerritory AdoxioTerritory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Area")]
        public MicrosoftDynamicsCRMadoxioArea AdoxioArea { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceTypeId")]
        public MicrosoftDynamicsCRMadoxioLicencetype AdoxioLicenceTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LGIN")]
        public MicrosoftDynamicsCRMadoxioLocalgovindigenousnation AdoxioLGIN { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_PDJurisdiction")]
        public MicrosoftDynamicsCRMadoxioPolicejurisdiction AdoxioPDJurisdiction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_PrimaryInspectorId")]
        public MicrosoftDynamicsCRMsystemuser AdoxioPrimaryInspectorId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_contraventions")]
        public IList<MicrosoftDynamicsCRMadoxioContravention> AdoxioEstablishmentContraventions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_complaints")]
        public IList<MicrosoftDynamicsCRMadoxioComplaint> AdoxioEstablishmentComplaints { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_compliancemeetings")]
        public IList<MicrosoftDynamicsCRMadoxioCompliancemeeting> AdoxioEstablishmentCompliancemeetings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_investigations")]
        public IList<MicrosoftDynamicsCRMadoxioComplianceinvestigation> AdoxioEstablishmentInvestigations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_cannabismonthlyreports")]
        public IList<MicrosoftDynamicsCRMadoxioCannabismonthlyreport> AdoxioEstablishmentCannabismonthlyreports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_establishment_inventoryreports")]
        public IList<MicrosoftDynamicsCRMadoxioCannabisinventoryreport> AdoxioEstablishmentInventoryreports { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RegionId")]
        public MicrosoftDynamicsCRMadoxioRegion AdoxioRegionId { get; set; }

    }
}
