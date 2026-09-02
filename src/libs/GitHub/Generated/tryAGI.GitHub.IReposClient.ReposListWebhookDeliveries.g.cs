#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List deliveries for a repository webhook<br/>
        /// Returns a list of webhook deliveries for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::tryAGI.GitHub.HookDeliveryItem>> ReposListWebhookDeliveriesAsync(
            string owner,
            string repo,
            int hookId,
            int? perPage = default,
            string? cursor = default,
            global::tryAGI.GitHub.ReposListWebhookDeliveriesStatus? status = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List deliveries for a repository webhook<br/>
        /// Returns a list of webhook deliveries for a webhook configured in a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="hookId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::tryAGI.GitHub.HookDeliveryItem>>> ReposListWebhookDeliveriesAsResponseAsync(
            string owner,
            string repo,
            int hookId,
            int? perPage = default,
            string? cursor = default,
            global::tryAGI.GitHub.ReposListWebhookDeliveriesStatus? status = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}