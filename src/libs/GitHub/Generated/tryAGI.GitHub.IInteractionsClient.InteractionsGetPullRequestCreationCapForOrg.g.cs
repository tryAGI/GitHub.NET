#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IInteractionsClient
    {
        /// <summary>
        /// Get pull request creation cap for an org<br/>
        /// Gets the pull request creation cap configuration for an organization.<br/>
        /// The cap limits the total number of open pull requests a user can have across all public<br/>
        /// repositories in the organization at one time.<br/>
        /// Only users with admin access to the organization can view the cap configuration.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.InteractionsGetPullRequestCreationCapForOrgResponse> InteractionsGetPullRequestCreationCapForOrgAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get pull request creation cap for an org<br/>
        /// Gets the pull request creation cap configuration for an organization.<br/>
        /// The cap limits the total number of open pull requests a user can have across all public<br/>
        /// repositories in the organization at one time.<br/>
        /// Only users with admin access to the organization can view the cap configuration.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.InteractionsGetPullRequestCreationCapForOrgResponse>> InteractionsGetPullRequestCreationCapForOrgAsResponseAsync(
            string org,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}