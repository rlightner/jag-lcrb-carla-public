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
    /// Microsoft.Dynamics.CRM.solutioncomponent
    /// </summary>
    public partial class MicrosoftDynamicsCRMsolutioncomponent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsolutioncomponent class.
        /// </summary>
        public MicrosoftDynamicsCRMsolutioncomponent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsolutioncomponent class.
        /// </summary>
        /// <param name="modifiedon">Date and time when the solution was last
        /// modified.</param>
        /// <param name="createdon">Date and time when the solution was
        /// created.</param>
        /// <param name="componenttype">The object type code of the
        /// component.</param>
        /// <param name="rootcomponentbehavior">Indicates the include behavior
        /// of the root component.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who modified the solution.</param>
        /// <param name="ismetadata">Indicates whether this component is
        /// metadata or data.</param>
        /// <param name="rootsolutioncomponentid">The parent ID of the
        /// subcomponent, which will be a root</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the solution.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the solution</param>
        /// <param name="_solutionidValue">Unique identifier of the
        /// solution.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the solution.</param>
        /// <param name="solutioncomponentid">Unique identifier of the solution
        /// component.</param>
        /// <param name="objectid">Unique identifier of the object with which
        /// the component is associated.</param>
        public MicrosoftDynamicsCRMsolutioncomponent(System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? componenttype = default(int?), int? rootcomponentbehavior = default(int?), string versionnumber = default(string), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), bool? ismetadata = default(bool?), System.Guid? rootsolutioncomponentid = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), System.Guid? _createdbyValue = default(System.Guid?), System.Guid? _solutionidValue = default(System.Guid?), System.Guid? _modifiedbyValue = default(System.Guid?), System.Guid? solutioncomponentid = default(System.Guid?), System.Guid? objectid = default(System.Guid?), MicrosoftDynamicsCRMsolution solutionid = default(MicrosoftDynamicsCRMsolution), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsolutioncomponent rootsolutioncomponentidSolutioncomponent = default(MicrosoftDynamicsCRMsolutioncomponent), IList<MicrosoftDynamicsCRMsolutioncomponent> solutioncomponentParentSolutioncomponent = default(IList<MicrosoftDynamicsCRMsolutioncomponent>))
        {
            Modifiedon = modifiedon;
            Createdon = createdon;
            Componenttype = componenttype;
            Rootcomponentbehavior = rootcomponentbehavior;
            Versionnumber = versionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Ismetadata = ismetadata;
            Rootsolutioncomponentid = rootsolutioncomponentid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._createdbyValue = _createdbyValue;
            this._solutionidValue = _solutionidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Solutioncomponentid = solutioncomponentid;
            Objectid = objectid;
            Solutionid = solutionid;
            Createdonbehalfby = createdonbehalfby;
            Modifiedonbehalfby = modifiedonbehalfby;
            RootsolutioncomponentidSolutioncomponent = rootsolutioncomponentidSolutioncomponent;
            SolutioncomponentParentSolutioncomponent = solutioncomponentParentSolutioncomponent;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date and time when the solution was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the solution was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets the object type code of the component.
        /// </summary>
        [JsonProperty(PropertyName = "componenttype")]
        public int? Componenttype { get; set; }

        /// <summary>
        /// Gets or sets indicates the include behavior of the root component.
        /// </summary>
        [JsonProperty(PropertyName = "rootcomponentbehavior")]
        public int? Rootcomponentbehavior { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who modified
        /// the solution.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this component is metadata or data.
        /// </summary>
        [JsonProperty(PropertyName = "ismetadata")]
        public bool? Ismetadata { get; set; }

        /// <summary>
        /// Gets or sets the parent ID of the subcomponent, which will be a
        /// root
        /// </summary>
        [JsonProperty(PropertyName = "rootsolutioncomponentid")]
        public System.Guid? Rootsolutioncomponentid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// solution.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the solution
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the solution.
        /// </summary>
        [JsonProperty(PropertyName = "_solutionid_value")]
        public System.Guid? _solutionidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// solution.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the solution component.
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponentid")]
        public System.Guid? Solutioncomponentid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the object with which the
        /// component is associated.
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public System.Guid? Objectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public MicrosoftDynamicsCRMsolution Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rootsolutioncomponentid_solutioncomponent")]
        public MicrosoftDynamicsCRMsolutioncomponent RootsolutioncomponentidSolutioncomponent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutioncomponent_parent_solutioncomponent")]
        public IList<MicrosoftDynamicsCRMsolutioncomponent> SolutioncomponentParentSolutioncomponent { get; set; }

    }
}
