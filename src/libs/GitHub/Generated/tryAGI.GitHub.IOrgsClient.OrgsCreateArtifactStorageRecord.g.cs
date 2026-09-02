#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create artifact metadata storage record<br/>
        /// Create metadata storage records for artifacts associated with an organization.<br/>
        /// This endpoint will create a new artifact storage record on behalf of any artifact matching the provided digest and<br/>
        /// associated with a repository owned by the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsCreateArtifactStorageRecordResponse> OrgsCreateArtifactStorageRecordAsync(
            string org,

            global::tryAGI.GitHub.OrgsCreateArtifactStorageRecordRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create artifact metadata storage record<br/>
        /// Create metadata storage records for artifacts associated with an organization.<br/>
        /// This endpoint will create a new artifact storage record on behalf of any artifact matching the provided digest and<br/>
        /// associated with a repository owned by the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.OrgsCreateArtifactStorageRecordResponse>> OrgsCreateArtifactStorageRecordAsResponseAsync(
            string org,

            global::tryAGI.GitHub.OrgsCreateArtifactStorageRecordRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create artifact metadata storage record<br/>
        /// Create metadata storage records for artifacts associated with an organization.<br/>
        /// This endpoint will create a new artifact storage record on behalf of any artifact matching the provided digest and<br/>
        /// associated with a repository owned by the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the artifact.<br/>
        /// Example: libfoo
        /// </param>
        /// <param name="digest">
        /// The digest of the artifact (algorithm:hex-encoded-digest).<br/>
        /// Example: sha256:0ecbaa601dba202129058746c7d8e3f282d0efb5fff0...
        /// </param>
        /// <param name="version">
        /// The artifact version.<br/>
        /// Example: 1.2.3
        /// </param>
        /// <param name="artifactUrl">
        /// The URL where the artifact is stored.<br/>
        /// Example: https://reg.example.com/artifactory/bar/libfoo-1.2.3
        /// </param>
        /// <param name="path">
        /// The path of the artifact.<br/>
        /// Example: com/github/bar/libfoo-1.2.3
        /// </param>
        /// <param name="registryUrl">
        /// The base URL of the artifact registry.<br/>
        /// Example: https://reg.example.com/artifactory/
        /// </param>
        /// <param name="repository">
        /// The repository name within the registry.<br/>
        /// Example: bar
        /// </param>
        /// <param name="status">
        /// The status of the artifact (e.g., active, inactive).<br/>
        /// Default Value: active<br/>
        /// Example: active
        /// </param>
        /// <param name="githubRepository">
        /// The name of the GitHub repository associated with the artifact. This should be used<br/>
        /// when there are no provenance attestations available for the artifact. The repository<br/>
        /// must belong to the organization specified in the path parameter.<br/>
        /// If a provenance attestation is available for the artifact, the API will use<br/>
        /// the repository information from the attestation instead of this parameter.<br/>
        /// Example: my-github-repo
        /// </param>
        /// <param name="returnRecords">
        /// If true, the endpoint will return the created record in the response body.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.OrgsCreateArtifactStorageRecordResponse> OrgsCreateArtifactStorageRecordAsync(
            string org,
            string name,
            string digest,
            string registryUrl,
            string? version = default,
            string? artifactUrl = default,
            string? path = default,
            string? repository = default,
            global::tryAGI.GitHub.OrgsCreateArtifactStorageRecordRequestStatus? status = default,
            string? githubRepository = default,
            bool? returnRecords = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}