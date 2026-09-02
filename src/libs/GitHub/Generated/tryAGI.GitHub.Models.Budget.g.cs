
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Budget
    {
        /// <summary>
        /// The unique identifier for the budget<br/>
        /// Example: 2066deda-923f-43f9-88d2-62395a28c0cdd
        /// </summary>
        /// <example>2066deda-923f-43f9-88d2-62395a28c0cdd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of pricing for the budget<br/>
        /// Example: SkuPricing
        /// </summary>
        /// <example>SkuPricing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.BudgetBudgetTypeVariant1?, global::tryAGI.GitHub.BudgetBudgetTypeVariant2?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.BudgetBudgetTypeVariant1?, global::tryAGI.GitHub.BudgetBudgetTypeVariant2?> BudgetType { get; set; }

        /// <summary>
        /// The budget amount limit in whole dollars. For license-based products, this represents the number of licenses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BudgetAmount { get; set; }

        /// <summary>
        /// The type of limit enforcement for the budget<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevent_further_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PreventFurtherUsage { get; set; }

        /// <summary>
        /// The scope of the budget<br/>
        /// Example: enterprise
        /// </summary>
        /// <example>enterprise</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.BudgetBudgetScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.BudgetBudgetScope BudgetScope { get; set; }

        /// <summary>
        /// The name of the entity for the budget (enterprise does not require a name).<br/>
        /// Example: octocat/hello-world
        /// </summary>
        /// <example>octocat/hello-world</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_entity_name")]
        public string? BudgetEntityName { get; set; }

        /// <summary>
        /// The user login when the budget is scoped to a single user (`user` scope).<br/>
        /// Example: octocat
        /// </summary>
        /// <example>octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// The amount consumed for a user-scoped budget, or for a multi-user budget when filtering by user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumed_amount")]
        public double? ConsumedAmount { get; set; }

        /// <summary>
        /// A single product or sku to apply the budget to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_product_sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BudgetProductSku { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_alerting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.BudgetBudgetAlerting BudgetAlerting { get; set; }

        /// <summary>
        /// The date the budget will expire in `YYYY-MM-DD` format. Only dates in the future are accepted.<br/>
        /// If not provided, the budget will not expire.<br/>
        /// Only supported for budgets with `budget_scope` of `user`<br/>
        /// Example: 2026-12-31
        /// </summary>
        /// <example>2026-12-31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Budget" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the budget<br/>
        /// Example: 2066deda-923f-43f9-88d2-62395a28c0cdd
        /// </param>
        /// <param name="budgetType">
        /// The type of pricing for the budget<br/>
        /// Example: SkuPricing
        /// </param>
        /// <param name="budgetAmount">
        /// The budget amount limit in whole dollars. For license-based products, this represents the number of licenses.
        /// </param>
        /// <param name="preventFurtherUsage">
        /// The type of limit enforcement for the budget<br/>
        /// Example: true
        /// </param>
        /// <param name="budgetScope">
        /// The scope of the budget<br/>
        /// Example: enterprise
        /// </param>
        /// <param name="budgetProductSku">
        /// A single product or sku to apply the budget to.
        /// </param>
        /// <param name="budgetAlerting"></param>
        /// <param name="budgetEntityName">
        /// The name of the entity for the budget (enterprise does not require a name).<br/>
        /// Example: octocat/hello-world
        /// </param>
        /// <param name="user">
        /// The user login when the budget is scoped to a single user (`user` scope).<br/>
        /// Example: octocat
        /// </param>
        /// <param name="consumedAmount">
        /// The amount consumed for a user-scoped budget, or for a multi-user budget when filtering by user.
        /// </param>
        /// <param name="expiresAt">
        /// The date the budget will expire in `YYYY-MM-DD` format. Only dates in the future are accepted.<br/>
        /// If not provided, the budget will not expire.<br/>
        /// Only supported for budgets with `budget_scope` of `user`<br/>
        /// Example: 2026-12-31
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Budget(
            string id,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.BudgetBudgetTypeVariant1?, global::tryAGI.GitHub.BudgetBudgetTypeVariant2?> budgetType,
            int budgetAmount,
            bool preventFurtherUsage,
            global::tryAGI.GitHub.BudgetBudgetScope budgetScope,
            string budgetProductSku,
            global::tryAGI.GitHub.BudgetBudgetAlerting budgetAlerting,
            string? budgetEntityName,
            string? user,
            double? consumedAmount,
            global::System.DateTime? expiresAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BudgetType = budgetType;
            this.BudgetAmount = budgetAmount;
            this.PreventFurtherUsage = preventFurtherUsage;
            this.BudgetScope = budgetScope;
            this.BudgetEntityName = budgetEntityName;
            this.User = user;
            this.ConsumedAmount = consumedAmount;
            this.BudgetProductSku = budgetProductSku ?? throw new global::System.ArgumentNullException(nameof(budgetProductSku));
            this.BudgetAlerting = budgetAlerting ?? throw new global::System.ArgumentNullException(nameof(budgetAlerting));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Budget" /> class.
        /// </summary>
        public Budget()
        {
        }

    }
}