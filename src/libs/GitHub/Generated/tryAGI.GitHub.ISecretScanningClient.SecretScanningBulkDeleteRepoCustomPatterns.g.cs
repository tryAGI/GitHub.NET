#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Bulk delete repository custom patterns<br/>
        /// Bulk deletes secret scanning custom patterns for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task SecretScanningBulkDeleteRepoCustomPatternsAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete repository custom patterns<br/>
        /// Bulk deletes secret scanning custom patterns for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> SecretScanningBulkDeleteRepoCustomPatternsAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete repository custom patterns<br/>
        /// Bulk deletes secret scanning custom patterns for a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="patterns">
        /// The list of custom patterns to delete.
        /// </param>
        /// <param name="postDeleteAction">
        /// What to do with alerts associated with the deleted patterns.<br/>
        /// `delete_alerts` permanently removes the alerts.<br/>
        /// `resolve_alerts` resolves the alerts as "pattern deleted".<br/>
        /// Defaults to `delete_alerts` when not specified.<br/>
        /// Default Value: delete_alerts
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SecretScanningBulkDeleteRepoCustomPatternsAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPatternToDelete> patterns,
            global::tryAGI.GitHub.SecretScanningBulkDeleteRepoCustomPatternsRequestPostDeleteAction? postDeleteAction = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}