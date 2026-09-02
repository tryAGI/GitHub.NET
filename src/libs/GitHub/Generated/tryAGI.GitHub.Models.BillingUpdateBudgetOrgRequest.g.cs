
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingUpdateBudgetOrgRequest
    {
        /// <summary>
        /// The budget amount in whole dollars. For license-based products, this represents the number of licenses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_amount")]
        public int? BudgetAmount { get; set; }

        /// <summary>
        /// Whether to prevent additional spending once the budget is exceeded. For budgets with `user` or `multi_user_customer` scope, this must remain `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevent_further_usage")]
        public bool? PreventFurtherUsage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_alerting")]
        public global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetAlerting? BudgetAlerting { get; set; }

        /// <summary>
        /// The scope of the budget for this organization.<br/>
        /// - `organization`: Apply the budget to the organization.<br/>
        /// - `repository`: Apply the budget to a specific repository in the organization.<br/>
        /// - `multi_user_customer`: Apply a universal budget to all users in the organization.<br/>
        /// - `user`: Apply the budget to a single user in the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.BillingUpdateBudgetOrgRequestBudgetScopeJsonConverter))]
        public global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetScope? BudgetScope { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant1?, global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant2?, global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant3?>))]
        public global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant1?, global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant2?, global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant3?>? BudgetType { get; set; }

        /// <summary>
        /// A single product or SKU that will be covered in the budget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_product_sku")]
        public string? BudgetProductSku { get; set; }

        /// <summary>
        /// The username of the user for `user` scope budgets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// The date the budget will expire in `YYYY-MM-DD` format. Only dates in the future are accepted.<br/>
        /// If not set, the budget will not expire. Setting to `null` or `0` will remove the expiration date from a budget if set.<br/>
        /// Only supported for budgets with `budget_scope` of `user`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::System.DateTime?, int?>))]
        public global::tryAGI.GitHub.OneOf<global::System.DateTime?, int?>? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUpdateBudgetOrgRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUpdateBudgetOrgRequest(
            int? budgetAmount,
            bool? preventFurtherUsage,
            global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetAlerting? budgetAlerting,
            global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetScope? budgetScope,
            string? budgetEntityName,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant1?, global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant2?, global::tryAGI.GitHub.BillingUpdateBudgetOrgRequestBudgetTypeVariant3?>? budgetType,
            string? budgetProductSku,
            string? user,
            global::tryAGI.GitHub.OneOf<global::System.DateTime?, int?>? expiresAt)
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
        /// Initializes a new instance of the <see cref="BillingUpdateBudgetOrgRequest" /> class.
        /// </summary>
        public BillingUpdateBudgetOrgRequest()
        {
        }

    }
}