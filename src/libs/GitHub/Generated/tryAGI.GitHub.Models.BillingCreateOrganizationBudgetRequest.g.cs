
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingCreateOrganizationBudgetRequest
    {
        /// <summary>
        /// The budget amount in whole dollars. For license-based products, this represents the number of licenses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_amount")]
        public int? BudgetAmount { get; set; }

        /// <summary>
        /// Whether to prevent additional spending once the budget is exceeded. For `user` and `multi_user_customer` scopes, this must be `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevent_further_usage")]
        public bool? PreventFurtherUsage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_alerting")]
        public global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetAlerting? BudgetAlerting { get; set; }

        /// <summary>
        /// The scope of the budget for this organization.<br/>
        /// - `organization`: Apply the budget to the organization.<br/>
        /// - `repository`: Apply the budget to a specific repository in the organization.<br/>
        /// - `multi_user_customer`: Apply a universal budget to all users in the organization.<br/>
        /// - `user`: Apply the budget to a single user in the organization.<br/>
        /// `user` and `multi_user_customer` scopes are only supported when<br/>
        /// `budget_product_sku` is `ai_credits` or `premium_requests`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.BillingCreateOrganizationBudgetRequestBudgetScopeJsonConverter))]
        public global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetScope? BudgetScope { get; set; }

        /// <summary>
        /// The name of the entity to apply the budget to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_entity_name")]
        public string? BudgetEntityName { get; set; }

        /// <summary>
        /// The type of pricing model used by the budget. Determines how `budget_product_sku` is interpreted.<br/>
        /// - `BundlePricing`: Covers all AI credit SKUs. Set `budget_product_sku` to `ai_credits`.<br/>
        /// - `ProductPricing`: Covers all SKUs that belong to a product. Set `budget_product_sku` to a product such as `actions` or `packages`.<br/>
        /// - `SkuPricing`: Covers a single, specific SKU. Set `budget_product_sku` to a SKU such as `actions_linux`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant1?, global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant2?, global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant3?>))]
        public global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant1?, global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant2?, global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant3?>? BudgetType { get; set; }

        /// <summary>
        /// A single product or SKU that will be covered in the budget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_product_sku")]
        public string? BudgetProductSku { get; set; }

        /// <summary>
        /// The username of the user for `user` scope budgets. This field is required when `budget_scope` is `user`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// The date the budget will expire in `YYYY-MM-DD` format. Only dates in the future are accepted.<br/>
        /// If not provided, the budget will not expire.<br/>
        /// Only supported for budgets with `budget_scope` of `user`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCreateOrganizationBudgetRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingCreateOrganizationBudgetRequest(
            int? budgetAmount,
            bool? preventFurtherUsage,
            global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetAlerting? budgetAlerting,
            global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetScope? budgetScope,
            string? budgetEntityName,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant1?, global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant2?, global::tryAGI.GitHub.BillingCreateOrganizationBudgetRequestBudgetTypeVariant3?>? budgetType,
            string? budgetProductSku,
            string? user,
            global::System.DateTime? expiresAt)
        {
            this.BudgetAmount = budgetAmount;
            this.PreventFurtherUsage = preventFurtherUsage;
            this.BudgetAlerting = budgetAlerting;
            this.BudgetScope = budgetScope;
            this.BudgetEntityName = budgetEntityName;
            this.BudgetType = budgetType;
            this.BudgetProductSku = budgetProductSku;
            this.User = user;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCreateOrganizationBudgetRequest" /> class.
        /// </summary>
        public BillingCreateOrganizationBudgetRequest()
        {
        }

    }
}