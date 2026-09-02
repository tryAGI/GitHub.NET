#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Re-run failed jobs from a workflow run<br/>
        /// Re-run all of the failed jobs and their dependent jobs in a workflow run using the `id` of the workflow run.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.EmptyObject> ActionsReRunWorkflowFailedJobsAsync(
            string owner,
            string repo,
            int runId,

            global::tryAGI.GitHub.ActionsReRunWorkflowFailedJobsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Re-run failed jobs from a workflow run<br/>
        /// Re-run all of the failed jobs and their dependent jobs in a workflow run using the `id` of the workflow run.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.EmptyObject>> ActionsReRunWorkflowFailedJobsAsResponseAsync(
            string owner,
            string repo,
            int runId,

            global::tryAGI.GitHub.ActionsReRunWorkflowFailedJobsRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Re-run failed jobs from a workflow run<br/>
        /// Re-run all of the failed jobs and their dependent jobs in a workflow run using the `id` of the workflow run.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="enableDebugLogging">
        /// Whether to enable debug logging for the re-run.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.EmptyObject> ActionsReRunWorkflowFailedJobsAsync(
            string owner,
            string repo,
            int runId,
            bool? enableDebugLogging = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}