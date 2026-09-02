#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IDependencyGraphClient
    {
        /// <summary>
        /// Fetch a software bill of materials (SBOM) for a repository.<br/>
        /// Fetches a previously generated software bill of materials (SBOM) for a repository.<br/>
        /// When the SBOM is ready, the response is a 302 redirect to a temporary download URL for the SBOM in SPDX JSON format.<br/>
        /// The generated SBOM report may be retained for up to one week from the original request.<br/>
        /// The temporary download URL returned by this endpoint expires separately, and its expiry is set when the fetch request is made.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sbomUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task DependencyGraphFetchSbomReportAsync(
            string owner,
            string repo,
            string sbomUuid,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch a software bill of materials (SBOM) for a repository.<br/>
        /// Fetches a previously generated software bill of materials (SBOM) for a repository.<br/>
        /// When the SBOM is ready, the response is a 302 redirect to a temporary download URL for the SBOM in SPDX JSON format.<br/>
        /// The generated SBOM report may be retained for up to one week from the original request.<br/>
        /// The temporary download URL returned by this endpoint expires separately, and its expiry is set when the fetch request is made.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sbomUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> DependencyGraphFetchSbomReportAsResponseAsync(
            string owner,
            string repo,
            string sbomUuid,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}