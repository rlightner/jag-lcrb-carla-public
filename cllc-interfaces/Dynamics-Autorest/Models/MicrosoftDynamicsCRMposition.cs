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
    /// Microsoft.Dynamics.CRM.position
    /// </summary>
    public partial class MicrosoftDynamicsCRMposition
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMposition
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMposition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMposition
        /// class.
        /// </summary>
        /// <param name="timezoneruleversionnumber">For internal use
        /// only.</param>
        /// <param name="_parentpositionidValue">Parent position.</param>
        /// <param name="exchangerate">Exchange rate for the currency
        /// associated with the position with respect to the base
        /// currency.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// modified the record.</param>
        /// <param name="createdon">Date and time when the record was
        /// created.</param>
        /// <param name="_organizationidValue">Unique identifier for the
        /// organization</param>
        /// <param name="modifiedon">Date and time when the record was
        /// modified.</param>
        /// <param name="statecode">Status of the Position</param>
        /// <param name="utcconversiontimezonecode">Time zone code that was in
        /// use when the record was created.</param>
        /// <param name="name">The name of the position.</param>
        /// <param name="positionid">Unique identifier for position entity
        /// instances</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the record.</param>
        /// <param name="importsequencenumber">Sequence number of the import
        /// that created this record.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the record.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the record.</param>
        /// <param name="statuscode">Reason for the status of the
        /// Position</param>
        /// <param name="description">The description of the position.</param>
        /// <param name="overriddencreatedon">Date and time that the record was
        /// migrated.</param>
        /// <param name="_transactioncurrencyidValue">Unique identifier of the
        /// currency associated with the position.</param>
        public MicrosoftDynamicsCRMposition(int? timezoneruleversionnumber = default(int?), System.Guid? _parentpositionidValue = default(System.Guid?), decimal? exchangerate = default(decimal?), System.Guid? _modifiedbyValue = default(System.Guid?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.Guid? _organizationidValue = default(System.Guid?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), int? statecode = default(int?), int? utcconversiontimezonecode = default(int?), string name = default(string), System.Guid? positionid = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), int? importsequencenumber = default(int?), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), int? statuscode = default(int?), string versionnumber = default(string), string description = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.Guid? _transactioncurrencyidValue = default(System.Guid?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMasyncoperation> positionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMsystemuser> positionUsers = default(IList<MicrosoftDynamicsCRMsystemuser>), MicrosoftDynamicsCRMposition parentpositionid = default(MicrosoftDynamicsCRMposition), IList<MicrosoftDynamicsCRMposition> positionParentPosition = default(IList<MicrosoftDynamicsCRMposition>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMconnection> positionConnection1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> positionConnection2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMsyncerror> positionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>))
        {
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._parentpositionidValue = _parentpositionidValue;
            Exchangerate = exchangerate;
            this._modifiedbyValue = _modifiedbyValue;
            Createdon = createdon;
            this._organizationidValue = _organizationidValue;
            Modifiedon = modifiedon;
            Statecode = statecode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Name = name;
            Positionid = positionid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            Description = description;
            Overriddencreatedon = overriddencreatedon;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            PositionAsyncOperations = positionAsyncOperations;
            PositionUsers = positionUsers;
            Parentpositionid = parentpositionid;
            PositionParentPosition = positionParentPosition;
            Transactioncurrencyid = transactioncurrencyid;
            PositionConnection1 = positionConnection1;
            PositionConnection2 = positionConnection2;
            PositionSyncErrors = positionSyncErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets for internal use only.
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// Gets or sets parent position.
        /// </summary>
        [JsonProperty(PropertyName = "_parentpositionid_value")]
        public System.Guid? _parentpositionidValue { get; set; }

        /// <summary>
        /// Gets or sets exchange rate for the currency associated with the
        /// position with respect to the base currency.
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who modified the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for the organization
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public System.Guid? _organizationidValue { get; set; }

        /// <summary>
        /// Gets or sets date and time when the record was modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets status of the Position
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// Gets or sets time zone code that was in use when the record was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// Gets or sets the name of the position.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique identifier for position entity instances
        /// </summary>
        [JsonProperty(PropertyName = "positionid")]
        public System.Guid? Positionid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets sequence number of the import that created this
        /// record.
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the record.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the record.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets reason for the status of the Position
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets the description of the position.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets date and time that the record was migrated.
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the currency associated with the
        /// position.
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public System.Guid? _transactioncurrencyidValue { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> PositionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_users")]
        public IList<MicrosoftDynamicsCRMsystemuser> PositionUsers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parentpositionid")]
        public MicrosoftDynamicsCRMposition Parentpositionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_parent_position")]
        public IList<MicrosoftDynamicsCRMposition> PositionParentPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_connection1")]
        public IList<MicrosoftDynamicsCRMconnection> PositionConnection1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "position_connection2")]
        public IList<MicrosoftDynamicsCRMconnection> PositionConnection2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Position_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> PositionSyncErrors { get; set; }

    }
}
