#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List workflow run artifacts<br/>
        /// Lists artifacts for a workflow run.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="name"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ActionsListWorkflowRunArtifactsResponse> ActionsListWorkflowRunArtifactsAsync(
            string owner,
            string repo,
            int runId,
            int? perPage = default,
            int? page = default,
            string? name = default,
            global::tryAGI.GitHub.ActionsListWorkflowRunArtifactsDirection? direction = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List workflow run artifacts<br/>
        /// Lists artifacts for a workflow run.<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="name"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ActionsListWorkflowRunArtifactsResponse>> ActionsListWorkflowRunArtifactsAsResponseAsync(
            string owner,
            string repo,
            int runId,
            int? perPage = default,
            int? page = default,
            string? name = default,
            global::tryAGI.GitHub.ActionsListWorkflowRunArtifactsDirection? direction = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ActionsListWorkflowRunArtifactsAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.Artifact&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="name"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.Artifact> ActionsListWorkflowRunArtifactsAutoPagingAsync(
            string owner,
            string repo,
            int runId,             int? perPage = default,
            string? name = default,
            global::tryAGI.GitHub.ActionsListWorkflowRunArtifactsDirection? direction = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}