#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Update a budget for an organization<br/>
        /// Updates an existing budget for an organization. The authenticated user must be an organization admin or billing manager.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="budgetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.UpdateBudget> BillingUpdateBudgetOrgAsync(
            string org,
            string budgetId,

            global::tryAGI.GitHub.BillingUpdateBudgetOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a budget for an organization<br/>
        /// Updates an existing budget for an organization. The authenticated user must be an organization admin or billing manager.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="budgetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.UpdateBudget>> BillingUpdateBudgetOrgAsResponseAsync(
            string org,
            string budgetId,

            global::tryAGI.GitHub.BillingUpdateBudgetOrgRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a budget for an organization<br/>
        /// Updates an existing budget for an organization. The authenticated user must be an organization admin or billing manager.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="budgetId"></param>
        /// <param name="budgetAmount">
        /// The budget amount in whole dollars. For license-based products, this represents the number of licenses.
        /// </param>
        /// <param name="preventFurtherUsage">
        /// Whether to prevent additional spending once the budget is exceeded. For budgets with `user` or `multi_user_customer` scope, this must remain `true`.
        /// </param>
        /// <param name="budgetAlerting"></param>
        /// <param name="budgetScope">
        /// The scope of the budget for this organization.<br/>
        /// - `organization`: Apply the budget to the organization.<br/>
        /// - `repository`: Apply the budget to a specific repository in the organization.<br/>
        /// - `multi_user_customer`: Apply a universal budget to all users in the organization.<br/>
        /// - `user`: Apply the budget to a single user in the organization.
        /// </param>
        /// <param name="budgetEntityName">
        /// The name of the entity to apply the budget to
        /// </param>
        /// <param name="budgetType">
        /// The type of pricing model used by the budget. Determines how `budget_product_sku` is interpreted.<br/>
        /// - `BundlePricing`: Covers all AI credit SKUs. Set `budget_product_sku` to `ai_credits`.<br/>
        /// - `ProductPricing`: Covers all SKUs that belong to a product. Set `budget_product_sku` to a product such as `actions` or `packages`.<br/>
        /// - `SkuPricing`: Covers a single, specific SKU. Set `budget_product_sku` to a SKU such as `actions_linux`.
        /// </param>
        /// <param name="budgetProductSku">
        /// A single product or SKU that will be covered in the budget
        /// </param>
        /// <param name="user">
        /// The username of the user for `user` scope budgets.
        /// </param>
        /// <param name="expiresAt">
        /// The date the budget will expire in `YYYY-MM-DD` format. Only dates in the future are accepted.<br/>
        /// If not set, the budget will not expire. Setting to `null` or `0` will remove the expiration date from a budget if set.<br/>
        /// Only supported for budgets with `budget_scope` of `user`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.UpdateBudget> BillingUpdateBudgetOrgAsync(
            string org,
            string budgetId,
            int? budgetAmount = default,
            bool? preventFurtherUsage = default,
            global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetAlerting? budgetAlerting = default,
            global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetScope? budgetScope = default,
            string? budgetEntityName = default,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant1?, global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant2?, global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant3?>? budgetType = default,
            string? budgetProductSku = default,
            string? user = default,
            global::tryAGI.GitHub.OneOf<global::System.DateTime?, int?>? expiresAt = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}