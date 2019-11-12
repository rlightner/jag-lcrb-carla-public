// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Adoxiotiedhouseassociations.
    /// </summary>
    public static partial class AdoxiotiedhouseassociationsExtensions
    {
            /// <summary>
            /// Get entities from adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioTiedhouseassociationCollection Get(this IAdoxiotiedhouseassociations operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioTiedhouseassociationCollection> GetAsync(this IAdoxiotiedhouseassociations operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioTiedhouseassociationCollection> GetWithHttpMessages(this IAdoxiotiedhouseassociations operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            public static MicrosoftDynamicsCRMadoxioTiedhouseassociation Create(this IAdoxiotiedhouseassociations operations, MicrosoftDynamicsCRMadoxioTiedhouseassociation body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioTiedhouseassociation> CreateAsync(this IAdoxiotiedhouseassociations operations, MicrosoftDynamicsCRMadoxioTiedhouseassociation body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New entity
            /// </param>
            /// <param name='prefer'>
            /// Required in order for the service to return a JSON representation of the
            /// object.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioTiedhouseassociation> CreateWithHttpMessages(this IAdoxiotiedhouseassociations operations, MicrosoftDynamicsCRMadoxioTiedhouseassociation body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_tiedhouseassociations by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseassociationid'>
            /// key: adoxio_tiedhouseassociationid of adoxio_tiedhouseassociation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioTiedhouseassociation TiedhouseassociationsByKey(this IAdoxiotiedhouseassociations operations, System.Guid adoxioTiedhouseassociationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.TiedhouseassociationsByKeyAsync(adoxioTiedhouseassociationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_tiedhouseassociations by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseassociationid'>
            /// key: adoxio_tiedhouseassociationid of adoxio_tiedhouseassociation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioTiedhouseassociation> TiedhouseassociationsByKeyAsync(this IAdoxiotiedhouseassociations operations, System.Guid adoxioTiedhouseassociationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.TiedhouseassociationsByKeyWithHttpMessagesAsync(adoxioTiedhouseassociationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from adoxio_tiedhouseassociations by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseassociationid'>
            /// key: adoxio_tiedhouseassociationid of adoxio_tiedhouseassociation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioTiedhouseassociation> TiedhouseassociationsByKeyWithHttpMessages(this IAdoxiotiedhouseassociations operations, System.Guid adoxioTiedhouseassociationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.TiedhouseassociationsByKeyWithHttpMessagesAsync(adoxioTiedhouseassociationid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseassociationid'>
            /// key: adoxio_tiedhouseassociationid of adoxio_tiedhouseassociation
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void TiedhouseassociationsByKey1(this IAdoxiotiedhouseassociations operations, System.Guid adoxioTiedhouseassociationid, MicrosoftDynamicsCRMadoxioTiedhouseassociation body)
            {
                operations.TiedhouseassociationsByKey1Async(adoxioTiedhouseassociationid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseassociationid'>
            /// key: adoxio_tiedhouseassociationid of adoxio_tiedhouseassociation
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task TiedhouseassociationsByKey1Async(this IAdoxiotiedhouseassociations operations, System.Guid adoxioTiedhouseassociationid, MicrosoftDynamicsCRMadoxioTiedhouseassociation body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.TiedhouseassociationsByKey1WithHttpMessagesAsync(adoxioTiedhouseassociationid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseassociationid'>
            /// key: adoxio_tiedhouseassociationid of adoxio_tiedhouseassociation
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse TiedhouseassociationsByKey1WithHttpMessages(this IAdoxiotiedhouseassociations operations, System.Guid adoxioTiedhouseassociationid, MicrosoftDynamicsCRMadoxioTiedhouseassociation body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.TiedhouseassociationsByKey1WithHttpMessagesAsync(adoxioTiedhouseassociationid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseassociationid'>
            /// key: adoxio_tiedhouseassociationid of adoxio_tiedhouseassociation
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void TiedhouseassociationsByKey2(this IAdoxiotiedhouseassociations operations, System.Guid adoxioTiedhouseassociationid, string ifMatch = default(string))
            {
                operations.TiedhouseassociationsByKey2Async(adoxioTiedhouseassociationid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseassociationid'>
            /// key: adoxio_tiedhouseassociationid of adoxio_tiedhouseassociation
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task TiedhouseassociationsByKey2Async(this IAdoxiotiedhouseassociations operations, System.Guid adoxioTiedhouseassociationid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.TiedhouseassociationsByKey2WithHttpMessagesAsync(adoxioTiedhouseassociationid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from adoxio_tiedhouseassociations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioTiedhouseassociationid'>
            /// key: adoxio_tiedhouseassociationid of adoxio_tiedhouseassociation
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse TiedhouseassociationsByKey2WithHttpMessages(this IAdoxiotiedhouseassociations operations, System.Guid adoxioTiedhouseassociationid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.TiedhouseassociationsByKey2WithHttpMessagesAsync(adoxioTiedhouseassociationid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
