#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete attestations by subject digest<br/>
        /// Delete an artifact attestation by subject digest.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="subjectDigest"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersDeleteAttestationsBySubjectDigestAsync(
            string username,
            string subjectDigest,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete attestations by subject digest<br/>
        /// Delete an artifact attestation by subject digest.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="subjectDigest"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> UsersDeleteAttestationsBySubjectDigestAsResponseAsync(
            string username,
            string subjectDigest,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}