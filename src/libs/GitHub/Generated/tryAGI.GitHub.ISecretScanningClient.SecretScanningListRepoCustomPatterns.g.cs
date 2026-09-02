#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// List repository custom patterns<br/>
        /// Lists secret scanning custom patterns for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state"></param>
        /// <param name="pushProtection"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPattern>> SecretScanningListRepoCustomPatternsAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.SecretScanningListRepoCustomPatternsState? state = default,
            global::tryAGI.GitHub.SecretScanningListRepoCustomPatternsPushProtection? pushProtection = default,
            global::tryAGI.GitHub.SecretScanningListRepoCustomPatternsSort? sort = default,
            global::tryAGI.GitHub.SecretScanningListRepoCustomPatternsDirection? direction = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List repository custom patterns<br/>
        /// Lists secret scanning custom patterns for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state"></param>
        /// <param name="pushProtection"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPattern>>> SecretScanningListRepoCustomPatternsAsResponseAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.SecretScanningListRepoCustomPatternsState? state = default,
            global::tryAGI.GitHub.SecretScanningListRepoCustomPatternsPushProtection? pushProtection = default,
            global::tryAGI.GitHub.SecretScanningListRepoCustomPatternsSort? sort = default,
            global::tryAGI.GitHub.SecretScanningListRepoCustomPatternsDirection? direction = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}