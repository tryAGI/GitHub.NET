#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get a budget by ID for an organization<br/>
        /// Gets a budget by ID. The authenticated user must be an organization admin or billing manager.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="budgetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.GetBudget> BillingGetBudgetOrgAsync(
            string org,
            string budgetId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a budget by ID for an organization<br/>
        /// Gets a budget by ID. The authenticated user must be an organization admin or billing manager.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="budgetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.GetBudget>> BillingGetBudgetOrgAsResponseAsync(
            string org,
            string budgetId,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}