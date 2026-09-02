#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Mark a thread as done<br/>
        /// Marks a thread as "done." Marking a thread as "done" is equivalent to marking a notification in your notification inbox on GitHub as done: https://github.com/notifications.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ActivityMarkThreadAsDoneAsync(
            int threadId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mark a thread as done<br/>
        /// Marks a thread as "done." Marking a thread as "done" is equivalent to marking a notification in your notification inbox on GitHub as done: https://github.com/notifications.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse> ActivityMarkThreadAsDoneAsResponseAsync(
            int threadId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}