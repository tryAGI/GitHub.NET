#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Disable a selected repository for immutable releases in an organization<br/>
        /// Removes a repository from the list of selected repositories that are enforced for immutable releases in an organization. To use this endpoint, the organization immutable releases policy for `enforced_repositories` must be configured to `selected`.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsDisableSelectedRepositoryImmutableReleasesOrganizationAsync(
            string org,
            int repositoryId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Disable a selected repository for immutable releases in an organization<br/>
        /// Removes a repository from the list of selected repositories that are enforced for immutable releases in an organization. To use this endpoint, the organization immutable releases policy for `enforced_repositories` must be configured to `selected`.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> OrgsDisableSelectedRepositoryImmutableReleasesOrganizationAsResponseAsync(
            string org,
            int repositoryId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}