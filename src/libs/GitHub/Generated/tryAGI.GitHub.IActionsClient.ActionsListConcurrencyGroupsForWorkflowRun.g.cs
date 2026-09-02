#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List concurrency groups for a workflow run<br/>
        /// Lists all concurrency groups associated with a workflow run or its jobs.<br/>
        /// The set of groups is derived from the run's configuration, so a group is<br/>
        /// included even when the run no longer has any items currently holding or<br/>
        /// waiting in it. In that case the `group_members` array will be empty.<br/>
        /// `total_count` reflects the number of groups the run participates in by<br/>
        /// configuration, not the number with active items.<br/>
        /// This differs from `GET /repos/{owner}/{repo}/actions/concurrency_groups/{group_name}`,<br/>
        /// which returns 404 when a group has no active items. That endpoint reports<br/>
        /// the live state of a group repo-wide, while this endpoint reports the<br/>
        /// groups associated with a specific run by configuration.<br/>
        /// Results are sorted by group name and support cursor-based pagination via<br/>
        /// `before` and `after`. The `after` cursor paginates forward only and does<br/>
        /// not emit a `rel="prev"` Link; use `before` to page backward from a<br/>
        /// forward page's `next` cursor.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ConcurrencyGroupRunList> ActionsListConcurrencyGroupsForWorkflowRunAsync(
            string owner,
            string repo,
            int runId,
            int? perPage = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List concurrency groups for a workflow run<br/>
        /// Lists all concurrency groups associated with a workflow run or its jobs.<br/>
        /// The set of groups is derived from the run's configuration, so a group is<br/>
        /// included even when the run no longer has any items currently holding or<br/>
        /// waiting in it. In that case the `group_members` array will be empty.<br/>
        /// `total_count` reflects the number of groups the run participates in by<br/>
        /// configuration, not the number with active items.<br/>
        /// This differs from `GET /repos/{owner}/{repo}/actions/concurrency_groups/{group_name}`,<br/>
        /// which returns 404 when a group has no active items. That endpoint reports<br/>
        /// the live state of a group repo-wide, while this endpoint reports the<br/>
        /// groups associated with a specific run by configuration.<br/>
        /// Results are sorted by group name and support cursor-based pagination via<br/>
        /// `before` and `after`. The `after` cursor paginates forward only and does<br/>
        /// not emit a `rel="prev"` Link; use `before` to page backward from a<br/>
        /// forward page's `next` cursor.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ConcurrencyGroupRunList>> ActionsListConcurrencyGroupsForWorkflowRunAsResponseAsync(
            string owner,
            string repo,
            int runId,
            int? perPage = default,
            string? before = default,
            string? after = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}