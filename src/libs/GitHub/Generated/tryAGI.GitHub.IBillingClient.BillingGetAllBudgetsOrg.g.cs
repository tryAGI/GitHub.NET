#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Get all budgets for an organization<br/>
        /// Gets all budgets for an organization. The authenticated user must be an organization admin or billing manager.<br/>
        /// Each page returns up to 100 budgets.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="scope"></param>
        /// <param name="user"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.GetAllBudgets> BillingGetAllBudgetsOrgAsync(
            string org,
            int? page = default,
            int? perPage = default,
            global::tryAGI.GitHub.BillingGetAllBudgetsOrgScope? scope = default,
            string? user = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get all budgets for an organization<br/>
        /// Gets all budgets for an organization. The authenticated user must be an organization admin or billing manager.<br/>
        /// Each page returns up to 100 budgets.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="scope"></param>
        /// <param name="user"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.GetAllBudgets>> BillingGetAllBudgetsOrgAsResponseAsync(
            string org,
            int? page = default,
            int? perPage = default,
            global::tryAGI.GitHub.BillingGetAllBudgetsOrgScope? scope = default,
            string? user = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BillingGetAllBudgetsOrgAsync as an IAsyncEnumerable&lt;global::tryAGI.GitHub.Budget&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="scope"></param>
        /// <param name="user"></param>
        /// <param name="page">Initial page number to start enumerating from. Defaults to 1.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.GitHub.Budget> BillingGetAllBudgetsOrgAutoPagingAsync(
            string org,             int? perPage = default,
            global::tryAGI.GitHub.BillingGetAllBudgetsOrgScope? scope = default,
            string? user = default,
            int? page = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}