#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get a concurrency group for a repository<br/>
        /// Gets a specific concurrency group for a repository, including all instances in the group's queue.<br/>
        /// Returns 404 if the group is inactive or does not exist.<br/>
        /// Optionally, pass `ahead_of_run` or `ahead_of_job` to filter the results to only the items<br/>
        /// ahead of the specified workflow run or job in the queue, plus the specified item itself<br/>
        /// (returned as the last element). This is useful for determining what is blocking a particular<br/>
        /// run or job. Returns 422 if the specified run or job is not in this concurrency group.<br/>
        /// When using `ahead_of_run`, this matches workflow-level concurrency and any reusable-workflow<br/>
        /// leases held on behalf of that run. Job-level leases within the run are not considered to<br/>
        /// block the run as a whole. Use `ahead_of_job` to match job-level concurrency and reusable-workflow<br/>
        /// leases on the job's ancestor paths.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="concurrencyGroupName"></param>
        /// <param name="aheadOfRun"></param>
        /// <param name="aheadOfJob"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.ConcurrencyGroup> ActionsGetConcurrencyGroupForRepositoryAsync(
            string owner,
            string repo,
            string concurrencyGroupName,
            int? aheadOfRun = default,
            int? aheadOfJob = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a concurrency group for a repository<br/>
        /// Gets a specific concurrency group for a repository, including all instances in the group's queue.<br/>
        /// Returns 404 if the group is inactive or does not exist.<br/>
        /// Optionally, pass `ahead_of_run` or `ahead_of_job` to filter the results to only the items<br/>
        /// ahead of the specified workflow run or job in the queue, plus the specified item itself<br/>
        /// (returned as the last element). This is useful for determining what is blocking a particular<br/>
        /// run or job. Returns 422 if the specified run or job is not in this concurrency group.<br/>
        /// When using `ahead_of_run`, this matches workflow-level concurrency and any reusable-workflow<br/>
        /// leases held on behalf of that run. Job-level leases within the run are not considered to<br/>
        /// block the run as a whole. Use `ahead_of_job` to match job-level concurrency and reusable-workflow<br/>
        /// leases on the job's ancestor paths.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="concurrencyGroupName"></param>
        /// <param name="aheadOfRun"></param>
        /// <param name="aheadOfJob"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.ConcurrencyGroup>> ActionsGetConcurrencyGroupForRepositoryAsResponseAsync(
            string owner,
            string repo,
            string concurrencyGroupName,
            int? aheadOfRun = default,
            int? aheadOfJob = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}