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

    public partial class MicrosoftDynamicsCRMadoxioLicencetype
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencetype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencetype()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLicencetype class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLicencetype(string _adoxioApplicationfeeproductValue = default(string), string _adoxioLicencefeeproductValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), MicrosoftDynamicsCRMproduct adoxioApplicationFeeProduct = default(MicrosoftDynamicsCRMproduct), MicrosoftDynamicsCRMproduct adoxioLicenceFeeProduct = default(MicrosoftDynamicsCRMproduct), IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> adoxioAdoxioLicencetypeAdoxioApplicationtermsconditionslimitationLicenceType = default(IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation>), IList<MicrosoftDynamicsCRMadoxioInvestigation> adoxioAdoxioLicencetypeAdoxioInvestigation = default(IList<MicrosoftDynamicsCRMadoxioInvestigation>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioAdoxioLicencetypeAdoxioLicencesLicenceType = default(IList<MicrosoftDynamicsCRMadoxioLicences>), IList<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset> adoxioAdoxioLicencetypeAdoxioTermsconditionslimitationspresetLicenceType = default(IList<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset>), string adoxioCode = default(string), int? adoxioDisplayorder = default(int?), IList<MicrosoftDynamicsCRMincident> adoxioIncidentAdoxioLicencetype = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLicencetypeAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLicencetypeBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLicencetypeDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLicencetypeDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsyncerror> adoxioLicencetypeSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioLicencetypeAdoxioApplicationLicenceType = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMadoxioLicencetypeprerequisite> adoxioLicencetypeAdoxioLicencetypeprerequisiteLicenceType = default(IList<MicrosoftDynamicsCRMadoxioLicencetypeprerequisite>), IList<MicrosoftDynamicsCRMadoxioLicencetypeprerequisite> adoxioLicencetypeAdoxioLicencetypeprerequisitePrerequisiteLicenceType = default(IList<MicrosoftDynamicsCRMadoxioLicencetypeprerequisite>), IList<MicrosoftDynamicsCRMadoxioLicencetypestep> adoxioLicencetypeAdoxioLicencetypestepLicenceType = default(IList<MicrosoftDynamicsCRMadoxioLicencetypestep>), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioLicencetypeEstablishment = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>), IList<MicrosoftDynamicsCRMknowledgebaserecord> adoxioLicencetypeKnowledgebaserecord = default(IList<MicrosoftDynamicsCRMknowledgebaserecord>), string adoxioLicencetypeid = default(string), string adoxioName = default(string), string adoxioRequirements = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMknowledgearticle> msdynAdoxioLicencetypeKnowledgearticle = default(IList<MicrosoftDynamicsCRMknowledgearticle>), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), int? statecode = default(int?), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object))
        {
            this._adoxioApplicationfeeproductValue = _adoxioApplicationfeeproductValue;
            this._adoxioLicencefeeproductValue = _adoxioLicencefeeproductValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            AdoxioApplicationFeeProduct = adoxioApplicationFeeProduct;
            AdoxioLicenceFeeProduct = adoxioLicenceFeeProduct;
            AdoxioAdoxioLicencetypeAdoxioApplicationtermsconditionslimitationLicenceType = adoxioAdoxioLicencetypeAdoxioApplicationtermsconditionslimitationLicenceType;
            AdoxioAdoxioLicencetypeAdoxioInvestigation = adoxioAdoxioLicencetypeAdoxioInvestigation;
            AdoxioAdoxioLicencetypeAdoxioLicencesLicenceType = adoxioAdoxioLicencetypeAdoxioLicencesLicenceType;
            AdoxioAdoxioLicencetypeAdoxioTermsconditionslimitationspresetLicenceType = adoxioAdoxioLicencetypeAdoxioTermsconditionslimitationspresetLicenceType;
            AdoxioCode = adoxioCode;
            AdoxioDisplayorder = adoxioDisplayorder;
            AdoxioIncidentAdoxioLicencetype = adoxioIncidentAdoxioLicencetype;
            AdoxioLicencetypeAsyncOperations = adoxioLicencetypeAsyncOperations;
            AdoxioLicencetypeBulkDeleteFailures = adoxioLicencetypeBulkDeleteFailures;
            AdoxioLicencetypeDuplicateBaseRecord = adoxioLicencetypeDuplicateBaseRecord;
            AdoxioLicencetypeDuplicateMatchingRecord = adoxioLicencetypeDuplicateMatchingRecord;
            AdoxioLicencetypeSyncErrors = adoxioLicencetypeSyncErrors;
            AdoxioLicencetypeAdoxioApplicationLicenceType = adoxioLicencetypeAdoxioApplicationLicenceType;
            AdoxioLicencetypeAdoxioLicencetypeprerequisiteLicenceType = adoxioLicencetypeAdoxioLicencetypeprerequisiteLicenceType;
            AdoxioLicencetypeAdoxioLicencetypeprerequisitePrerequisiteLicenceType = adoxioLicencetypeAdoxioLicencetypeprerequisitePrerequisiteLicenceType;
            AdoxioLicencetypeAdoxioLicencetypestepLicenceType = adoxioLicencetypeAdoxioLicencetypestepLicenceType;
            AdoxioLicencetypeEstablishment = adoxioLicencetypeEstablishment;
            AdoxioLicencetypeKnowledgebaserecord = adoxioLicencetypeKnowledgebaserecord;
            AdoxioLicencetypeid = adoxioLicencetypeid;
            AdoxioName = adoxioName;
            AdoxioRequirements = adoxioRequirements;
            Createdbyname = createdbyname;
            Createdon = createdon;
            Createdonbehalfbyname = createdonbehalfbyname;
            Importsequencenumber = importsequencenumber;
            Modifiedbyname = modifiedbyname;
            Modifiedon = modifiedon;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            MsdynAdoxioLicencetypeKnowledgearticle = msdynAdoxioLicencetypeKnowledgearticle;
            Overriddencreatedon = overriddencreatedon;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Statecode = statecode;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicationfeeproduct_value")]
        public string _adoxioApplicationfeeproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licencefeeproduct_value")]
        public string _adoxioLicencefeeproductValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ApplicationFeeProduct")]
        public MicrosoftDynamicsCRMproduct AdoxioApplicationFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LicenceFeeProduct")]
        public MicrosoftDynamicsCRMproduct AdoxioLicenceFeeProduct { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_licencetype_adoxio_applicationtermsconditionslimitation_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioApplicationtermsconditionslimitation> AdoxioAdoxioLicencetypeAdoxioApplicationtermsconditionslimitationLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_licencetype_adoxio_investigation")]
        public IList<MicrosoftDynamicsCRMadoxioInvestigation> AdoxioAdoxioLicencetypeAdoxioInvestigation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_licencetype_adoxio_licences_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioAdoxioLicencetypeAdoxioLicencesLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_adoxio_licencetype_adoxio_termsconditionslimitationspreset_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioTermsconditionslimitationspreset> AdoxioAdoxioLicencetypeAdoxioTermsconditionslimitationspresetLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_code")]
        public string AdoxioCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_displayorder")]
        public int? AdoxioDisplayorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_incident_adoxio_licencetype")]
        public IList<MicrosoftDynamicsCRMincident> AdoxioIncidentAdoxioLicencetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLicencetypeAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLicencetypeBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLicencetypeDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLicencetypeDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLicencetypeSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_application_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioLicencetypeAdoxioApplicationLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_licencetypeprerequisite_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetypeprerequisite> AdoxioLicencetypeAdoxioLicencetypeprerequisiteLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_licencetypeprerequisite_PrerequisiteLicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetypeprerequisite> AdoxioLicencetypeAdoxioLicencetypeprerequisitePrerequisiteLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_adoxio_licencetypestep_LicenceType")]
        public IList<MicrosoftDynamicsCRMadoxioLicencetypestep> AdoxioLicencetypeAdoxioLicencetypestepLicenceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_establishment")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioLicencetypeEstablishment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetype_knowledgebaserecord")]
        public IList<MicrosoftDynamicsCRMknowledgebaserecord> AdoxioLicencetypeKnowledgebaserecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licencetypeid")]
        public string AdoxioLicencetypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_requirements")]
        public string AdoxioRequirements { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "msdyn_adoxio_licencetype_knowledgearticle")]
        public IList<MicrosoftDynamicsCRMknowledgearticle> MsdynAdoxioLicencetypeKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}