#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Review pending deployments for a workflow run<br/>
        /// Approve or reject pending deployments that are waiting on approval by a required reviewer.<br/>
        /// Required reviewers with read access to the repository contents and deployments can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Deployment>> ActionsReviewPendingDeploymentsForRunAsync(
            string owner,
            string repo,
            int runId,

            global::tryAGI.GitHub.ActionsReviewPendingDeploymentsForRunRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Review pending deployments for a workflow run<br/>
        /// Approve or reject pending deployments that are waiting on approval by a required reviewer.<br/>
        /// Required reviewers with read access to the repository contents and deployments can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Deployment>>> ActionsReviewPendingDeploymentsForRunAsResponseAsync(
            string owner,
            string repo,
            int runId,

            global::tryAGI.GitHub.ActionsReviewPendingDeploymentsForRunRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Review pending deployments for a workflow run<br/>
        /// Approve or reject pending deployments that are waiting on approval by a required reviewer.<br/>
        /// Required reviewers with read access to the repository contents and deployments can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="environmentIds">
        /// The list of environment ids to approve or reject<br/>
        /// Example: [161171787, 161171795]
        /// </param>
        /// <param name="state">
        /// Whether to approve or reject deployment to the specified environments.<br/>
        /// Example: approved
        /// </param>
        /// <param name="comment">
        /// A comment to accompany the deployment review<br/>
        /// Example: Ship it!
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.Deployment>> ActionsReviewPendingDeploymentsForRunAsync(
            string owner,
            string repo,
            int runId,
            global::System.Collections.Generic.IList<int> environmentIds,
            global::tryAGI.GitHub.ActionsReviewPendingDeploymentsForRunRequestState state,
            string comment,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}