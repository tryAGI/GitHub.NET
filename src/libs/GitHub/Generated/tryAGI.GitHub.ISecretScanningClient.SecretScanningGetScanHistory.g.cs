#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Get secret scanning scan history for a repository<br/>
        /// Lists the latest default incremental and backfill scans by type for a repository.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint requires [GitHub Advanced Security](https://docs.github.com/get-started/learning-about-github/about-github-advanced-security).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.SecretScanningScanHistory> SecretScanningGetScanHistoryAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get secret scanning scan history for a repository<br/>
        /// Lists the latest default incremental and backfill scans by type for a repository.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint requires [GitHub Advanced Security](https://docs.github.com/get-started/learning-about-github/about-github-advanced-security).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.SecretScanningScanHistory>> SecretScanningGetScanHistoryAsResponseAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}