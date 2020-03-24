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
    /// Extension methods for Endorsementduplicatematchingrecord.
    /// </summary>
    public static partial class EndorsementduplicatematchingrecordExtensions
    {
            /// <summary>
            /// Get adoxio_endorsement_DuplicateMatchingRecord from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
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
            public static MicrosoftDynamicsCRMduplicaterecordCollection Get(this IEndorsementduplicatematchingrecord operations, string adoxioEndorsementid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioEndorsementid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_endorsement_DuplicateMatchingRecord from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
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
            public static async Task<MicrosoftDynamicsCRMduplicaterecordCollection> GetAsync(this IEndorsementduplicatematchingrecord operations, string adoxioEndorsementid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioEndorsementid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_endorsement_DuplicateMatchingRecord from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMduplicaterecordCollection> GetWithHttpMessages(this IEndorsementduplicatematchingrecord operations, string adoxioEndorsementid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioEndorsementid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_endorsement_DuplicateMatchingRecord from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='duplicateid'>
            /// key: duplicateid of duplicaterecord
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMduplicaterecord DuplicateMatchingRecordByKey(this IEndorsementduplicatematchingrecord operations, string adoxioEndorsementid, string duplicateid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.DuplicateMatchingRecordByKeyAsync(adoxioEndorsementid, duplicateid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_endorsement_DuplicateMatchingRecord from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='duplicateid'>
            /// key: duplicateid of duplicaterecord
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
            public static async Task<MicrosoftDynamicsCRMduplicaterecord> DuplicateMatchingRecordByKeyAsync(this IEndorsementduplicatematchingrecord operations, string adoxioEndorsementid, string duplicateid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DuplicateMatchingRecordByKeyWithHttpMessagesAsync(adoxioEndorsementid, duplicateid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_endorsement_DuplicateMatchingRecord from adoxio_endorsements
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioEndorsementid'>
            /// key: adoxio_endorsementid of adoxio_endorsement
            /// </param>
            /// <param name='duplicateid'>
            /// key: duplicateid of duplicaterecord
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
            public static HttpOperationResponse<MicrosoftDynamicsCRMduplicaterecord> DuplicateMatchingRecordByKeyWithHttpMessages(this IEndorsementduplicatematchingrecord operations, string adoxioEndorsementid, string duplicateid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.DuplicateMatchingRecordByKeyWithHttpMessagesAsync(adoxioEndorsementid, duplicateid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}