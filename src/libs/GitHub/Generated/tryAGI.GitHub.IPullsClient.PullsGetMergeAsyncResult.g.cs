#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Get the result of an asynchronous merge<br/>
        /// Fetches the current result of an asynchronous merge request, identified by the UUID that was returned when the merge was requested.<br/>
        /// While the merge is still queued, the response includes the UUID, merge method, and expected head SHA of the request. Once the merge has completed, the response reports whether it was merged, including the merge commit OID on success or a message describing why it could not be merged on failure.<br/>
        /// The result of an asynchronous merge request is retained for 24 hours after its most recent update. After this window the request expires and this endpoint returns a `404` response for its UUID.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.PullRequestMergeAsyncResult> PullsGetMergeAsyncResultAsync(
            string owner,
            string repo,
            int pullNumber,
            string uuid,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the result of an asynchronous merge<br/>
        /// Fetches the current result of an asynchronous merge request, identified by the UUID that was returned when the merge was requested.<br/>
        /// While the merge is still queued, the response includes the UUID, merge method, and expected head SHA of the request. Once the merge has completed, the response reports whether it was merged, including the merge commit OID on success or a message describing why it could not be merged on failure.<br/>
        /// The result of an asynchronous merge request is retained for 24 hours after its most recent update. After this window the request expires and this endpoint returns a `404` response for its UUID.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="uuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.PullRequestMergeAsyncResult>> PullsGetMergeAsyncResultAsResponseAsync(
            string owner,
            string repo,
            int pullNumber,
            string uuid,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}