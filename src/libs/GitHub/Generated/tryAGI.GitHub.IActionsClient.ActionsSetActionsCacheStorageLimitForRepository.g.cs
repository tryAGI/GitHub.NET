#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set GitHub Actions cache storage limit for a repository<br/>
        /// Sets GitHub Actions cache storage limit for a repository. This determines the maximum size of caches that can be<br/>
        /// stored before eviction occurs.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:repository` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheStorageLimitForRepositoryAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.ActionsCacheStorageLimitForRepository request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache storage limit for a repository<br/>
        /// Sets GitHub Actions cache storage limit for a repository. This determines the maximum size of caches that can be<br/>
        /// stored before eviction occurs.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:repository` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ActionsSetActionsCacheStorageLimitForRepositoryAsResponseAsync(
            string owner,
            string repo,

            global::tryAGI.GitHub.ActionsCacheStorageLimitForRepository request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions cache storage limit for a repository<br/>
        /// Sets GitHub Actions cache storage limit for a repository. This determines the maximum size of caches that can be<br/>
        /// stored before eviction occurs.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:repository` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="maxCacheSizeGb">
        /// The maximum total cache size for this repository, in gigabytes.<br/>
        /// Example: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetActionsCacheStorageLimitForRepositoryAsync(
            string owner,
            string repo,
            long? maxCacheSizeGb = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}