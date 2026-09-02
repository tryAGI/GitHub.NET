#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Create a self-hosted runner group for an organization<br/>
        /// Creates a new self-hosted runner group for an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.RunnerGroupsOrg> ActionsCreateSelfHostedRunnerGroupForOrgAsync(
            string org,

            global::tryAGI.GitHub.ActionsCreateSelfHostedRunnerGroupForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a self-hosted runner group for an organization<br/>
        /// Creates a new self-hosted runner group for an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.RunnerGroupsOrg>> ActionsCreateSelfHostedRunnerGroupForOrgAsResponseAsync(
            string org,

            global::tryAGI.GitHub.ActionsCreateSelfHostedRunnerGroupForOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a self-hosted runner group for an organization<br/>
        /// Creates a new self-hosted runner group for an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// Name of the runner group.
        /// </param>
        /// <param name="visibility">
        /// Visibility of a runner group. You can select all repositories, select individual repositories, or limit access to private repositories.<br/>
        /// Default Value: all
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// List of repository IDs that can access the runner group.
        /// </param>
        /// <param name="runners">
        /// List of runner IDs to add to the runner group.
        /// </param>
        /// <param name="allowsPublicRepositories">
        /// Whether the runner group can be used by `public` repositories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="restrictedToWorkflows">
        /// If `true`, the runner group will be restricted to running only the workflows specified in the `selected_workflows` array.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="selectedWorkflows">
        /// List of workflows the runner group should be allowed to run. This setting will be ignored unless `restricted_to_workflows` is set to `true`.
        /// </param>
        /// <param name="networkConfigurationId">
        /// The identifier of a hosted compute network configuration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.RunnerGroupsOrg> ActionsCreateSelfHostedRunnerGroupForOrgAsync(
            string org,
            string name,
            global::tryAGI.GitHub.ActionsCreateSelfHostedRunnerGroupForOrgRequestVisibility? visibility = default,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds = default,
            global::System.Collections.Generic.IList<int>? runners = default,
            bool? allowsPublicRepositories = default,
            bool? restrictedToWorkflows = default,
            global::System.Collections.Generic.IList<string>? selectedWorkflows = default,
            string? networkConfigurationId = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}