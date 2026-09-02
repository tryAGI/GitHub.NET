#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set custom labels for a self-hosted runner for an organization<br/>
        /// Remove all previous custom labels and set the new custom labels for a specific<br/>
        /// self-hosted runner configured in an organization.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsSetCustomLabelsForSelfHostedRunnerForOrgResponse> ActionsSetCustomLabelsForSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,

            global::tryAGI.GitHub.ActionsSetCustomLabelsForSelfHostedRunnerForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set custom labels for a self-hosted runner for an organization<br/>
        /// Remove all previous custom labels and set the new custom labels for a specific<br/>
        /// self-hosted runner configured in an organization.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsSetCustomLabelsForSelfHostedRunnerForOrgResponse>> ActionsSetCustomLabelsForSelfHostedRunnerForOrgAsResponseAsync(
            string org,
            int runnerId,

            global::tryAGI.GitHub.ActionsSetCustomLabelsForSelfHostedRunnerForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set custom labels for a self-hosted runner for an organization<br/>
        /// Remove all previous custom labels and set the new custom labels for a specific<br/>
        /// self-hosted runner configured in an organization.<br/>
        /// Authenticated users must have admin access to the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint. If the repository is private, the `repo` scope is also required.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="runnerId"></param>
        /// <param name="labels">
        /// The names of the custom labels to set for the runner. You can pass an empty array to remove all custom labels.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsSetCustomLabelsForSelfHostedRunnerForOrgResponse> ActionsSetCustomLabelsForSelfHostedRunnerForOrgAsync(
            string org,
            int runnerId,
            global::System.Collections.Generic.IList<string> labels,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}