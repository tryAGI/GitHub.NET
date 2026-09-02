#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersDeleteAttestationsBulkAsync(
            string username,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.UsersDeleteAttestationsBulkRequestVariant1, global::tryAGI.GitHub.UsersDeleteAttestationsBulkRequestVariant2> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> UsersDeleteAttestationsBulkAsResponseAsync(
            string username,

            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.UsersDeleteAttestationsBulkRequestVariant1, global::tryAGI.GitHub.UsersDeleteAttestationsBulkRequestVariant2> request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UsersDeleteAttestationsBulkAsync(
            string username,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}