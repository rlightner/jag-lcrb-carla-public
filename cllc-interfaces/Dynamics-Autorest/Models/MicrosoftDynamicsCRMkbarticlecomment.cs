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
    /// Microsoft.Dynamics.CRM.kbarticlecomment
    /// </summary>
    public partial class MicrosoftDynamicsCRMkbarticlecomment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMkbarticlecomment class.
        /// </summary>
        public MicrosoftDynamicsCRMkbarticlecomment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMkbarticlecomment class.
        /// </summary>
        /// <param name="createdon">Date and time when the knowledge base
        /// article comment was created.</param>
        /// <param name="modifiedon">Date and time when the knowledge base
        /// article comment was last modified.</param>
        /// <param name="_modifiedbyValue">Unique identifier of the user who
        /// last modified the knowledge base article comment.</param>
        /// <param name="organizationid">Unique identifier of the organization
        /// with which the article comment is associated.</param>
        /// <param name="_kbarticleidValue">Unique identifier of the knowledge
        /// base article to which the comment applies.</param>
        /// <param name="kbarticlecommentid">Unique identifier of the knowledge
        /// base article comment.</param>
        /// <param name="commenttext">Comment text for the knowledge base
        /// article.</param>
        /// <param name="_modifiedonbehalfbyValue">Unique identifier of the
        /// delegate user who last modified the kbarticlecomment.</param>
        /// <param name="_createdonbehalfbyValue">Unique identifier of the
        /// delegate user who created the kbarticlecomment.</param>
        /// <param name="title">Title of the knowledge base article
        /// comment.</param>
        /// <param name="_createdbyValue">Unique identifier of the user who
        /// created the knowledge base article comment.</param>
        public MicrosoftDynamicsCRMkbarticlecomment(System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.Guid? _modifiedbyValue = default(System.Guid?), System.Guid? organizationid = default(System.Guid?), System.Guid? _kbarticleidValue = default(System.Guid?), System.Guid? kbarticlecommentid = default(System.Guid?), string commenttext = default(string), System.Guid? _modifiedonbehalfbyValue = default(System.Guid?), System.Guid? _createdonbehalfbyValue = default(System.Guid?), string title = default(string), string versionnumber = default(string), System.Guid? _createdbyValue = default(System.Guid?), IList<MicrosoftDynamicsCRMbulkdeletefailure> kbArticleCommentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMasyncoperation> kbArticleCommentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMkbarticle kbarticleid = default(MicrosoftDynamicsCRMkbarticle), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Createdon = createdon;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            Organizationid = organizationid;
            this._kbarticleidValue = _kbarticleidValue;
            Kbarticlecommentid = kbarticlecommentid;
            Commenttext = commenttext;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Title = title;
            Versionnumber = versionnumber;
            this._createdbyValue = _createdbyValue;
            KbArticleCommentBulkDeleteFailures = kbArticleCommentBulkDeleteFailures;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            KbArticleCommentAsyncOperations = kbArticleCommentAsyncOperations;
            Modifiedonbehalfby = modifiedonbehalfby;
            Kbarticleid = kbarticleid;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date and time when the knowledge base article comment
        /// was created.
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// Gets or sets date and time when the knowledge base article comment
        /// was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who last modified the
        /// knowledge base article comment.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public System.Guid? _modifiedbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the organization with which the
        /// article comment is associated.
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public System.Guid? Organizationid { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the knowledge base article to
        /// which the comment applies.
        /// </summary>
        [JsonProperty(PropertyName = "_kbarticleid_value")]
        public System.Guid? _kbarticleidValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the knowledge base article
        /// comment.
        /// </summary>
        [JsonProperty(PropertyName = "kbarticlecommentid")]
        public System.Guid? Kbarticlecommentid { get; set; }

        /// <summary>
        /// Gets or sets comment text for the knowledge base article.
        /// </summary>
        [JsonProperty(PropertyName = "commenttext")]
        public string Commenttext { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who last
        /// modified the kbarticlecomment.
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public System.Guid? _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the delegate user who created the
        /// kbarticlecomment.
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public System.Guid? _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// Gets or sets title of the knowledge base article comment.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of the user who created the
        /// knowledge base article comment.
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public System.Guid? _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KbArticleComment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> KbArticleCommentBulkDeleteFailures { get; set; }

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
        [JsonProperty(PropertyName = "KbArticleComment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> KbArticleCommentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kbarticleid")]
        public MicrosoftDynamicsCRMkbarticle Kbarticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
