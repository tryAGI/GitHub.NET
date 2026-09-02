#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Merge a pull request asynchronously<br/>
        /// Merges a pull request into the base branch in the background. Merging in this way allows certain types of errors to be retried, and avoids the risk of timeouts for particularly complex merges.<br/>
        /// This is the required method for merging stacked PRs, but also supports unstacked PRs. When using this endpoint to merge a stacked pull request, all pull requests in the stack up to and including the requested PR will be merged into the base branch.<br/>
        /// The response includes a UUID that can be used to fetch the result of the merge. If another asynchronous merge request has already been made for this pull request, the UUID of that request will be returned instead with a 409 response status to indicate that the merge options may be different from those that were requested. If there isn't an existing asynchronous merge request, a 202 response status is used.<br/>
        /// If the pull request is already merged, the merge commit OID will be returned immediately with a 200 status.<br/>
        /// If the pull request cannot be merged (e.g. because it is closed, or still a draft) this result will be returned immediately with a 400 response status. Branch protection rules and repository rules are not run at this stage, only basic pull request state checks are performed.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestMergeAsyncResult> PullsMergeAsyncAsync(
            string owner,
            string repo,
            int pullNumber,

            global::tryAGI.GitHub.PullsMergeAsyncRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge a pull request asynchronously<br/>
        /// Merges a pull request into the base branch in the background. Merging in this way allows certain types of errors to be retried, and avoids the risk of timeouts for particularly complex merges.<br/>
        /// This is the required method for merging stacked PRs, but also supports unstacked PRs. When using this endpoint to merge a stacked pull request, all pull requests in the stack up to and including the requested PR will be merged into the base branch.<br/>
        /// The response includes a UUID that can be used to fetch the result of the merge. If another asynchronous merge request has already been made for this pull request, the UUID of that request will be returned instead with a 409 response status to indicate that the merge options may be different from those that were requested. If there isn't an existing asynchronous merge request, a 202 response status is used.<br/>
        /// If the pull request is already merged, the merge commit OID will be returned immediately with a 200 status.<br/>
        /// If the pull request cannot be merged (e.g. because it is closed, or still a draft) this result will be returned immediately with a 400 response status. Branch protection rules and repository rules are not run at this stage, only basic pull request state checks are performed.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.PullRequestMergeAsyncResult>> PullsMergeAsyncAsResponseAsync(
            string owner,
            string repo,
            int pullNumber,

            global::tryAGI.GitHub.PullsMergeAsyncRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge a pull request asynchronously<br/>
        /// Merges a pull request into the base branch in the background. Merging in this way allows certain types of errors to be retried, and avoids the risk of timeouts for particularly complex merges.<br/>
        /// This is the required method for merging stacked PRs, but also supports unstacked PRs. When using this endpoint to merge a stacked pull request, all pull requests in the stack up to and including the requested PR will be merged into the base branch.<br/>
        /// The response includes a UUID that can be used to fetch the result of the merge. If another asynchronous merge request has already been made for this pull request, the UUID of that request will be returned instead with a 409 response status to indicate that the merge options may be different from those that were requested. If there isn't an existing asynchronous merge request, a 202 response status is used.<br/>
        /// If the pull request is already merged, the merge commit OID will be returned immediately with a 200 status.<br/>
        /// If the pull request cannot be merged (e.g. because it is closed, or still a draft) this result will be returned immediately with a 400 response status. Branch protection rules and repository rules are not run at this stage, only basic pull request state checks are performed.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="commitTitle">
        /// Title for the automatic commit message.
        /// </param>
        /// <param name="commitMessage">
        /// Extra detail to append to automatic commit message.
        /// </param>
        /// <param name="sha">
        /// SHA that pull request head must match to allow merge. If not provided, the current head of the PR at the time of the request will be used; if the PR is pushed in between the merge being requested and being executed, the merge will be cancelled.
        /// </param>
        /// <param name="mergeMethod">
        /// The merge method to use.
        /// </param>
        /// <param name="mergeAction">
        /// The action that will be taken to merge the pull request. `direct_merge` merges the pull request directly without using a merge queue; `merge_queue` adds the pull request to a merge queue; `default` selects the most appropriate option.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestMergeAsyncResult> PullsMergeAsyncAsync(
            string owner,
            string repo,
            int pullNumber,
            string? commitTitle = default,
            string? commitMessage = default,
            string? sha = default,
            global::tryAGI.GitHub.PullsMergeAsyncRequestMergeMethod? mergeMethod = default,
            global::tryAGI.GitHub.PullsMergeAsyncRequestMergeAction? mergeAction = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}