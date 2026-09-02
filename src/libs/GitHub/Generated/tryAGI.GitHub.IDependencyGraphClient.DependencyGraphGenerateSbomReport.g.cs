#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IDependencyGraphClient
    {
        /// <summary>
        /// Request generation of a software bill of materials (SBOM) for a repository.<br/>
        /// Triggers a job to generate a software bill of materials (SBOM) for a repository in SPDX JSON format.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.DependencyGraphGenerateSbomReportResponse> DependencyGraphGenerateSbomReportAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request generation of a software bill of materials (SBOM) for a repository.<br/>
        /// Triggers a job to generate a software bill of materials (SBOM) for a repository in SPDX JSON format.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.DependencyGraphGenerateSbomReportResponse>> DependencyGraphGenerateSbomReportAsResponseAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}