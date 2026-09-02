#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete attestations by ID<br/>
        /// Delete an artifact attestation by unique ID that is associated with a repository owned by a user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="attestationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersDeleteAttestationsByIdAsync(
            string username,
            int attestationId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete attestations by ID<br/>
        /// Delete an artifact attestation by unique ID that is associated with a repository owned by a user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="attestationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> UsersDeleteAttestationsByIdAsResponseAsync(
            string username,
            int attestationId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}