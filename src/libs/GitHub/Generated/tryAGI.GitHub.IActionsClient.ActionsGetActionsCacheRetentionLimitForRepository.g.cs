#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get GitHub Actions cache retention limit for a repository<br/>
        /// Gets GitHub Actions cache retention limit for a repository. This determines how long caches will be retained for, if<br/>
        /// not manually removed or evicted due to size constraints.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:repository` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsCacheRetentionLimitForRepository> ActionsGetActionsCacheRetentionLimitForRepositoryAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get GitHub Actions cache retention limit for a repository<br/>
        /// Gets GitHub Actions cache retention limit for a repository. This determines how long caches will be retained for, if<br/>
        /// not manually removed or evicted due to size constraints.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:repository` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsCacheRetentionLimitForRepository>> ActionsGetActionsCacheRetentionLimitForRepositoryAsResponseAsync(
            string owner,
            string repo,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}