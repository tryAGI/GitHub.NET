#nullable enable

namespace tryAGI.GitHub
{
    public partial interface IBillingClient
    {
        /// <summary>
        /// Create a budget for an organization<br/>
        /// Creates a new budget for an organization. The authenticated user must be an<br/>
        /// organization admin or billing manager.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CreateBudget> BillingCreateOrganizationBudgetAsync(
            string org,

            global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a budget for an organization<br/>
        /// Creates a new budget for an organization. The authenticated user must be an<br/>
        /// organization admin or billing manager.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.AutoSDKHttpResponse<global::tryAGI.GitHub.CreateBudget>> BillingCreateOrganizationBudgetAsResponseAsync(
            string org,

            global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequest request,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a budget for an organization<br/>
        /// Creates a new budget for an organization. The authenticated user must be an<br/>
        /// organization admin or billing manager.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="budgetAmount">
        /// The budget amount in whole dollars. For license-based products, this represents the number of licenses.
        /// </param>
        /// <param name="preventFurtherUsage">
        /// Whether to prevent additional spending once the budget is exceeded. For `user` and `multi_user_customer` scopes, this must be `true`.
        /// </param>
        /// <param name="budgetAlerting"></param>
        /// <param name="budgetScope">
        /// The scope of the budget for this organization.<br/>
        /// - `organization`: Apply the budget to the organization.<br/>
        /// - `repository`: Apply the budget to a specific repository in the organization.<br/>
        /// - `multi_user_customer`: Apply a universal budget to all users in the organization.<br/>
        /// - `user`: Apply the budget to a single user in the organization.<br/>
        /// `user` and `multi_user_customer` scopes are only supported when<br/>
        /// `budget_product_sku` is `ai_credits` or `premium_requests`.
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
        /// The username of the user for `user` scope budgets. This field is required when `budget_scope` is `user`.
        /// </param>
        /// <param name="expiresAt">
        /// The date the budget will expire in `YYYY-MM-DD` format. Only dates in the future are accepted.<br/>
        /// If not provided, the budget will not expire.<br/>
        /// Only supported for budgets with `budget_scope` of `user`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.GitHub.CreateBudget> BillingCreateOrganizationBudgetAsync(
            string org,
            int? budgetAmount = default,
            bool? preventFurtherUsage = default,
            global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetAlerting? budgetAlerting = default,
            global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetScope? budgetScope = default,
            string? budgetEntityName = default,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant1?, global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant2?, global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant3?>? budgetType = default,
            string? budgetProductSku = default,
            string? user = default,
            global::System.DateTime? expiresAt = default,
            global::tryAGI.GitHub.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}