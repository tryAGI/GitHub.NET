#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Bulk delete organization custom patterns<br/>
        /// Bulk deletes secret scanning custom patterns for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task SecretScanningBulkDeleteOrgCustomPatternsAsync(
            string org,

            global::tryAGI.GitHub.SecretScanningBulkDeleteOrgCustomPatternsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete organization custom patterns<br/>
        /// Bulk deletes secret scanning custom patterns for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> SecretScanningBulkDeleteOrgCustomPatternsAsResponseAsync(
            string org,

            global::tryAGI.GitHub.SecretScanningBulkDeleteOrgCustomPatternsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete organization custom patterns<br/>
        /// Bulk deletes secret scanning custom patterns for an organization.<br/>
        /// Personal access tokens (classic) need the `write:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
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
        global::System.Threading.Tasks.Task SecretScanningBulkDeleteOrgCustomPatternsAsync(
            string org,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPatternToDelete> patterns,
            global::tryAGI.GitHub.SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction? postDeleteAction = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}