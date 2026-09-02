#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List artifact deployment records<br/>
        /// List deployment records for an artifact metadata associated with an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="subjectDigest"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsListArtifactDeploymentRecordsResponse> OrgsListArtifactDeploymentRecordsAsync(
            string org,
            string subjectDigest,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List artifact deployment records<br/>
        /// List deployment records for an artifact metadata associated with an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="subjectDigest"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsListArtifactDeploymentRecordsResponse>> OrgsListArtifactDeploymentRecordsAsResponseAsync(
            string org,
            string subjectDigest,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}