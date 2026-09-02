#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List artifact storage records<br/>
        /// List artifact storage records with a given subject digest for repositories owned by an organization.<br/>
        /// Results are filtered by the authenticated user's permissions; records for repositories the user cannot read are omitted. Fine-grained access tokens require the `artifact-metadata:read` permission.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="subjectDigest"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsListArtifactStorageRecordsResponse> OrgsListArtifactStorageRecordsAsync(
            string org,
            string subjectDigest,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List artifact storage records<br/>
        /// List artifact storage records with a given subject digest for repositories owned by an organization.<br/>
        /// Results are filtered by the authenticated user's permissions; records for repositories the user cannot read are omitted. Fine-grained access tokens require the `artifact-metadata:read` permission.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="subjectDigest"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsListArtifactStorageRecordsResponse>> OrgsListArtifactStorageRecordsAsResponseAsync(
            string org,
            string subjectDigest,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}