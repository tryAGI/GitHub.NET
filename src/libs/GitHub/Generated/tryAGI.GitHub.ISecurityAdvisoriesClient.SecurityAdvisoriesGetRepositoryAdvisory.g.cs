#nullable enable

namespace tryAGI.GitHub
{
    public partial interface ISecurityAdvisoriesClient
    {
        /// <summary>
        /// Get a repository security advisory<br/>
        /// Get a repository security advisory using its GitHub Security Advisory (GHSA) identifier.<br/>
        /// Anyone can access any published security advisory on a public repository.<br/>
        /// The authenticated user can access an unpublished security advisory from a repository if they are a security manager or administrator of that repository, or if they are a<br/>
        /// collaborator on the security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:read` scope to to get a published security advisory in a private repository, or any unpublished security advisory that the authenticated user has access to.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.RepositoryAdvisory> SecurityAdvisoriesGetRepositoryAdvisoryAsync(
            string owner,
            string repo,
            string ghsaId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a repository security advisory<br/>
        /// Get a repository security advisory using its GitHub Security Advisory (GHSA) identifier.<br/>
        /// Anyone can access any published security advisory on a public repository.<br/>
        /// The authenticated user can access an unpublished security advisory from a repository if they are a security manager or administrator of that repository, or if they are a<br/>
        /// collaborator on the security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:read` scope to to get a published security advisory in a private repository, or any unpublished security advisory that the authenticated user has access to.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ghsaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.RepositoryAdvisory>> SecurityAdvisoriesGetRepositoryAdvisoryAsResponseAsync(
            string owner,
            string repo,
            string ghsaId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}