#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Get list of conflicting packages during Docker migration for user<br/>
        /// Lists all packages that are in a specific user's namespace, that the requesting user has access to, and that encountered a conflict during Docker migration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Package>> PackagesListDockerMigrationConflictingPackagesForUserAsync(
            string username,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get list of conflicting packages during Docker migration for user<br/>
        /// Lists all packages that are in a specific user's namespace, that the requesting user has access to, and that encountered a conflict during Docker migration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Package>>> PackagesListDockerMigrationConflictingPackagesForUserAsResponseAsync(
            string username,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}