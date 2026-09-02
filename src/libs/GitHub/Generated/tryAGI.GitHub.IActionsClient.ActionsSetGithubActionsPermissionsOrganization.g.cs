#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set GitHub Actions permissions for an organization<br/>
        /// Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsOrganizationAsync(
            string org,

            global::tryAGI.GitHub.ActionsSetGithubActionsPermissionsOrganizationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions permissions for an organization<br/>
        /// Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ActionsSetGithubActionsPermissionsOrganizationAsResponseAsync(
            string org,

            global::tryAGI.GitHub.ActionsSetGithubActionsPermissionsOrganizationRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set GitHub Actions permissions for an organization<br/>
        /// Sets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="enabledRepositories">
        /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
        /// <param name="shaPinningRequired">
        /// Whether actions must be pinned to a full-length commit SHA.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsOrganizationAsync(
            string org,
            global::tryAGI.GitHub.EnabledRepositories enabledRepositories,
            global::tryAGI.GitHub.AllowedActions? allowedActions = default,
            bool? shaPinningRequired = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}