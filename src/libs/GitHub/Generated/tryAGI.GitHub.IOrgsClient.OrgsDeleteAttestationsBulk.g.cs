#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsDeleteAttestationsBulkAsync(
            string org,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.OrgsDeleteAttestationsBulkRequestVariant1, global::tryAGI.GitHub.OrgsDeleteAttestationsBulkRequestVariant2> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> OrgsDeleteAttestationsBulkAsResponseAsync(
            string org,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.OrgsDeleteAttestationsBulkRequestVariant1, global::tryAGI.GitHub.OrgsDeleteAttestationsBulkRequestVariant2> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task OrgsDeleteAttestationsBulkAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}