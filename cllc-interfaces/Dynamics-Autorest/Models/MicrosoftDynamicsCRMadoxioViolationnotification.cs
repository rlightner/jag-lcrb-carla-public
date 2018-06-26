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

    public partial class MicrosoftDynamicsCRMadoxioViolationnotification
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioViolationnotification class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioViolationnotification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioViolationnotification class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioViolationnotification(string _adoxioInvoiceValue = default(string), string _adoxioLicenceValue = default(string), string _adoxioRelatedcontraventionValue = default(string), string _adoxioRespondedpersonValue = default(string), string _adoxioViolationtypeValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _transactioncurrencyidValue = default(string), MicrosoftDynamicsCRMinvoice adoxioInvoice = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMadoxioLicences adoxioLicence = default(MicrosoftDynamicsCRMadoxioLicences), MicrosoftDynamicsCRMadoxioContravention adoxioRelatedContravention = default(MicrosoftDynamicsCRMadoxioContravention), MicrosoftDynamicsCRMcontact adoxioRespondedPerson = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMadoxioViolationtype adoxioViolationType = default(MicrosoftDynamicsCRMadoxioViolationtype), bool? adoxioAgreetodenyfault = default(bool?), bool? adoxioAgreetowaiverofacceptance = default(bool?), int? adoxioContravention = default(int?), string adoxioDescription = default(string), bool? adoxioInvoicepaid = default(bool?), string adoxioLicenseename = default(string), int? adoxioLicenseeresponse = default(int?), double? adoxioMonetarypenaltyamount = default(double?), double? adoxioMonetarypenaltyamountBase = default(double?), string adoxioName = default(string), string adoxioNotificationpaymentbuttonplaceholder = default(string), double? adoxioOverridepenaltyamount = default(double?), double? adoxioOverridepenaltyamountBase = default(double?), int? adoxioOverridesuspensiondays = default(int?), string adoxioPaymentmessage = default(string), int? adoxioPaymentoptions = default(int?), int? adoxioPenaltyactiontype = default(int?), System.DateTimeOffset? adoxioResponsedate = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMasyncoperation> adoxioViolationnotificationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioViolationnotificationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioViolationnotificationDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioViolationnotificationDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsyncerror> adoxioViolationnotificationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string adoxioViolationnotificationid = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), double? exchangerate = default(double?), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), int? statecode = default(int?), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object))
        {
            this._adoxioInvoiceValue = _adoxioInvoiceValue;
            this._adoxioLicenceValue = _adoxioLicenceValue;
            this._adoxioRelatedcontraventionValue = _adoxioRelatedcontraventionValue;
            this._adoxioRespondedpersonValue = _adoxioRespondedpersonValue;
            this._adoxioViolationtypeValue = _adoxioViolationtypeValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            AdoxioInvoice = adoxioInvoice;
            AdoxioLicence = adoxioLicence;
            AdoxioRelatedContravention = adoxioRelatedContravention;
            AdoxioRespondedPerson = adoxioRespondedPerson;
            AdoxioViolationType = adoxioViolationType;
            AdoxioAgreetodenyfault = adoxioAgreetodenyfault;
            AdoxioAgreetowaiverofacceptance = adoxioAgreetowaiverofacceptance;
            AdoxioContravention = adoxioContravention;
            AdoxioDescription = adoxioDescription;
            AdoxioInvoicepaid = adoxioInvoicepaid;
            AdoxioLicenseename = adoxioLicenseename;
            AdoxioLicenseeresponse = adoxioLicenseeresponse;
            AdoxioMonetarypenaltyamount = adoxioMonetarypenaltyamount;
            AdoxioMonetarypenaltyamountBase = adoxioMonetarypenaltyamountBase;
            AdoxioName = adoxioName;
            AdoxioNotificationpaymentbuttonplaceholder = adoxioNotificationpaymentbuttonplaceholder;
            AdoxioOverridepenaltyamount = adoxioOverridepenaltyamount;
            AdoxioOverridepenaltyamountBase = adoxioOverridepenaltyamountBase;
            AdoxioOverridesuspensiondays = adoxioOverridesuspensiondays;
            AdoxioPaymentmessage = adoxioPaymentmessage;
            AdoxioPaymentoptions = adoxioPaymentoptions;
            AdoxioPenaltyactiontype = adoxioPenaltyactiontype;
            AdoxioResponsedate = adoxioResponsedate;
            AdoxioViolationnotificationAsyncOperations = adoxioViolationnotificationAsyncOperations;
            AdoxioViolationnotificationBulkDeleteFailures = adoxioViolationnotificationBulkDeleteFailures;
            AdoxioViolationnotificationDuplicateBaseRecord = adoxioViolationnotificationDuplicateBaseRecord;
            AdoxioViolationnotificationDuplicateMatchingRecord = adoxioViolationnotificationDuplicateMatchingRecord;
            AdoxioViolationnotificationSyncErrors = adoxioViolationnotificationSyncErrors;
            AdoxioViolationnotificationid = adoxioViolationnotificationid;
            Createdbyname = createdbyname;
            Createdon = createdon;
            Createdonbehalfbyname = createdonbehalfbyname;
            Exchangerate = exchangerate;
            Importsequencenumber = importsequencenumber;
            Modifiedbyname = modifiedbyname;
            Modifiedon = modifiedon;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Overriddencreatedon = overriddencreatedon;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Statecode = statecode;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Transactioncurrencyid = transactioncurrencyid;
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
        [JsonProperty(PropertyName = "_adoxio_invoice_value")]
        public string _adoxioInvoiceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_licence_value")]
        public string _adoxioLicenceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_relatedcontravention_value")]
        public string _adoxioRelatedcontraventionValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_respondedperson_value")]
        public string _adoxioRespondedpersonValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_violationtype_value")]
        public string _adoxioViolationtypeValue { get; set; }

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
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Invoice")]
        public MicrosoftDynamicsCRMinvoice AdoxioInvoice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Licence")]
        public MicrosoftDynamicsCRMadoxioLicences AdoxioLicence { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RelatedContravention")]
        public MicrosoftDynamicsCRMadoxioContravention AdoxioRelatedContravention { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_RespondedPerson")]
        public MicrosoftDynamicsCRMcontact AdoxioRespondedPerson { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_ViolationType")]
        public MicrosoftDynamicsCRMadoxioViolationtype AdoxioViolationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agreetodenyfault")]
        public bool? AdoxioAgreetodenyfault { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agreetowaiverofacceptance")]
        public bool? AdoxioAgreetowaiverofacceptance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contravention")]
        public int? AdoxioContravention { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_description")]
        public string AdoxioDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_invoicepaid")]
        public bool? AdoxioInvoicepaid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseename")]
        public string AdoxioLicenseename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_licenseeresponse")]
        public int? AdoxioLicenseeresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_monetarypenaltyamount")]
        public double? AdoxioMonetarypenaltyamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_monetarypenaltyamount_base")]
        public double? AdoxioMonetarypenaltyamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_notificationpaymentbuttonplaceholder")]
        public string AdoxioNotificationpaymentbuttonplaceholder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_overridepenaltyamount")]
        public double? AdoxioOverridepenaltyamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_overridepenaltyamount_base")]
        public double? AdoxioOverridepenaltyamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_overridesuspensiondays")]
        public int? AdoxioOverridesuspensiondays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentmessage")]
        public string AdoxioPaymentmessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_paymentoptions")]
        public int? AdoxioPaymentoptions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_penaltyactiontype")]
        public int? AdoxioPenaltyactiontype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_responsedate")]
        public System.DateTimeOffset? AdoxioResponsedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotification_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioViolationnotificationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotification_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioViolationnotificationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotification_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioViolationnotificationDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotification_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioViolationnotificationDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotification_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioViolationnotificationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_violationnotificationid")]
        public string AdoxioViolationnotificationid { get; set; }

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
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

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
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

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