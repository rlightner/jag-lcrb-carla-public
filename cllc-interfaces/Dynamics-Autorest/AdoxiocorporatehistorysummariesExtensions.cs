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
    /// Extension methods for Adoxiocorporatehistorysummaries.
    /// </summary>
    public static partial class AdoxiocorporatehistorysummariesExtensions
    {
            /// <summary>
            /// Get entities from adoxio_corporatehistorysummaries
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
            public static MicrosoftDynamicsCRMadoxioCorporatehistorysummaryCollection Get(this IAdoxiocorporatehistorysummaries operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entities from adoxio_corporatehistorysummaries
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
            public static async Task<MicrosoftDynamicsCRMadoxioCorporatehistorysummaryCollection> GetAsync(this IAdoxiocorporatehistorysummaries operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entities from adoxio_corporatehistorysummaries
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioCorporatehistorysummaryCollection> GetWithHttpMessages(this IAdoxiocorporatehistorysummaries operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_corporatehistorysummaries
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
            public static MicrosoftDynamicsCRMadoxioCorporatehistorysummary Create(this IAdoxiocorporatehistorysummaries operations, MicrosoftDynamicsCRMadoxioCorporatehistorysummary body, string prefer = "return=representation")
            {
                return operations.CreateAsync(body, prefer).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Add new entity to adoxio_corporatehistorysummaries
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
            public static async Task<MicrosoftDynamicsCRMadoxioCorporatehistorysummary> CreateAsync(this IAdoxiocorporatehistorysummaries operations, MicrosoftDynamicsCRMadoxioCorporatehistorysummary body, string prefer = "return=representation", CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, prefer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add new entity to adoxio_corporatehistorysummaries
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioCorporatehistorysummary> CreateWithHttpMessages(this IAdoxiocorporatehistorysummaries operations, MicrosoftDynamicsCRMadoxioCorporatehistorysummary body, string prefer = "return=representation", Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CreateWithHttpMessagesAsync(body, prefer, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_corporatehistorysummaries by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCorporatehistorysummaryid'>
            /// key: adoxio_corporatehistorysummaryid of adoxio_corporatehistorysummary
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioCorporatehistorysummary CorporatehistorysummariesByKey(this IAdoxiocorporatehistorysummaries operations, System.Guid adoxioCorporatehistorysummaryid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.CorporatehistorysummariesByKeyAsync(adoxioCorporatehistorysummaryid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from adoxio_corporatehistorysummaries by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCorporatehistorysummaryid'>
            /// key: adoxio_corporatehistorysummaryid of adoxio_corporatehistorysummary
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
            public static async Task<MicrosoftDynamicsCRMadoxioCorporatehistorysummary> CorporatehistorysummariesByKeyAsync(this IAdoxiocorporatehistorysummaries operations, System.Guid adoxioCorporatehistorysummaryid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CorporatehistorysummariesByKeyWithHttpMessagesAsync(adoxioCorporatehistorysummaryid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get entity from adoxio_corporatehistorysummaries by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCorporatehistorysummaryid'>
            /// key: adoxio_corporatehistorysummaryid of adoxio_corporatehistorysummary
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioCorporatehistorysummary> CorporatehistorysummariesByKeyWithHttpMessages(this IAdoxiocorporatehistorysummaries operations, System.Guid adoxioCorporatehistorysummaryid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CorporatehistorysummariesByKeyWithHttpMessagesAsync(adoxioCorporatehistorysummaryid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_corporatehistorysummaries
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCorporatehistorysummaryid'>
            /// key: adoxio_corporatehistorysummaryid of adoxio_corporatehistorysummary
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void CorporatehistorysummariesByKey1(this IAdoxiocorporatehistorysummaries operations, System.Guid adoxioCorporatehistorysummaryid, MicrosoftDynamicsCRMadoxioCorporatehistorysummary body)
            {
                operations.CorporatehistorysummariesByKey1Async(adoxioCorporatehistorysummaryid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in adoxio_corporatehistorysummaries
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCorporatehistorysummaryid'>
            /// key: adoxio_corporatehistorysummaryid of adoxio_corporatehistorysummary
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CorporatehistorysummariesByKey1Async(this IAdoxiocorporatehistorysummaries operations, System.Guid adoxioCorporatehistorysummaryid, MicrosoftDynamicsCRMadoxioCorporatehistorysummary body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CorporatehistorysummariesByKey1WithHttpMessagesAsync(adoxioCorporatehistorysummaryid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update entity in adoxio_corporatehistorysummaries
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCorporatehistorysummaryid'>
            /// key: adoxio_corporatehistorysummaryid of adoxio_corporatehistorysummary
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse CorporatehistorysummariesByKey1WithHttpMessages(this IAdoxiocorporatehistorysummaries operations, System.Guid adoxioCorporatehistorysummaryid, MicrosoftDynamicsCRMadoxioCorporatehistorysummary body, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CorporatehistorysummariesByKey1WithHttpMessagesAsync(adoxioCorporatehistorysummaryid, body, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_corporatehistorysummaries
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCorporatehistorysummaryid'>
            /// key: adoxio_corporatehistorysummaryid of adoxio_corporatehistorysummary
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void CorporatehistorysummariesByKey2(this IAdoxiocorporatehistorysummaries operations, System.Guid adoxioCorporatehistorysummaryid, string ifMatch = default(string))
            {
                operations.CorporatehistorysummariesByKey2Async(adoxioCorporatehistorysummaryid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from adoxio_corporatehistorysummaries
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCorporatehistorysummaryid'>
            /// key: adoxio_corporatehistorysummaryid of adoxio_corporatehistorysummary
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CorporatehistorysummariesByKey2Async(this IAdoxiocorporatehistorysummaries operations, System.Guid adoxioCorporatehistorysummaryid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CorporatehistorysummariesByKey2WithHttpMessagesAsync(adoxioCorporatehistorysummaryid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete entity from adoxio_corporatehistorysummaries
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioCorporatehistorysummaryid'>
            /// key: adoxio_corporatehistorysummaryid of adoxio_corporatehistorysummary
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse CorporatehistorysummariesByKey2WithHttpMessages(this IAdoxiocorporatehistorysummaries operations, System.Guid adoxioCorporatehistorysummaryid, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.CorporatehistorysummariesByKey2WithHttpMessagesAsync(adoxioCorporatehistorysummaryid, ifMatch, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
