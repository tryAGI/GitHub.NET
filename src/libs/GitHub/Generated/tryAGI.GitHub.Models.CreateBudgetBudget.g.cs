
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBudgetBudget
    {
        /// <summary>
        /// ID of the budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The type of scope for the budget<br/>
        /// Example: enterprise
        /// </summary>
        /// <example>enterprise</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CreateBudgetBudgetBudgetScopeJsonConverter))]
        public global::tryAGI.GitHub.CreateBudgetBudgetBudgetScope? BudgetScope { get; set; }

        /// <summary>
        /// The name of the entity to apply the budget to<br/>
        /// Example: example-repository-name
        /// </summary>
        /// <example>example-repository-name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_entity_name")]
        public string? BudgetEntityName { get; set; }

        /// <summary>
        /// The budget amount in whole dollars. For license-based products, this represents the number of licenses.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_amount")]
        public int? BudgetAmount { get; set; }

        /// <summary>
        /// Whether to prevent additional spending once the budget is exceeded<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevent_further_usage")]
        public bool? PreventFurtherUsage { get; set; }

        /// <summary>
        /// A single product or sku to apply the budget to.<br/>
        /// Example: actions_linux
        /// </summary>
        /// <example>actions_linux</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_product_sku")]
        public string? BudgetProductSku { get; set; }

        /// <summary>
        /// The type of pricing for the budget<br/>
        /// Example: ProductPricing
        /// </summary>
        /// <example>ProductPricing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.CreateBudgetBudgetBudgetTypeVariant1?, global::tryAGI.GitHub.CreateBudgetBudgetBudgetTypeVariant2?>))]
        public global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.CreateBudgetBudgetBudgetTypeVariant1?, global::tryAGI.GitHub.CreateBudgetBudgetBudgetTypeVariant2?>? BudgetType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_alerting")]
        public global::tryAGI.GitHub.CreateBudgetBudgetBudgetAlerting? BudgetAlerting { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateBudgetBudget" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the budget.
        /// </param>
        /// <param name="budgetScope">
        /// The type of scope for the budget<br/>
        /// Example: enterprise
        /// </param>
        /// <param name="budgetEntityName">
        /// The name of the entity to apply the budget to<br/>
        /// Example: example-repository-name
        /// </param>
        /// <param name="budgetAmount">
        /// The budget amount in whole dollars. For license-based products, this represents the number of licenses.<br/>
        /// Example: 100
        /// </param>
        /// <param name="preventFurtherUsage">
        /// Whether to prevent additional spending once the budget is exceeded<br/>
        /// Example: true
        /// </param>
        /// <param name="budgetProductSku">
        /// A single product or sku to apply the budget to.<br/>
        /// Example: actions_linux
        /// </param>
        /// <param name="budgetType">
        /// The type of pricing for the budget<br/>
        /// Example: ProductPricing
        /// </param>
        /// <param name="budgetAlerting"></param>
        /// <param name="expiresAt">
        /// The date the budget will expire in `YYYY-MM-DD` format. Only dates in the future are accepted.<br/>
        /// If not provided, the budget will not expire.<br/>
        /// Only supported for budgets with `budget_scope` of `user`<br/>
        /// Example: 2026-12-31
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBudgetBudget(
            string? id,
            global::tryAGI.GitHub.CreateBudgetBudgetBudgetScope? budgetScope,
            string? budgetEntityName,
            int? budgetAmount,
            bool? preventFurtherUsage,
            string? budgetProductSku,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.CreateBudgetBudgetBudgetTypeVariant1?, global::tryAGI.GitHub.CreateBudgetBudgetBudgetTypeVariant2?>? budgetType,
            global::tryAGI.GitHub.CreateBudgetBudgetBudgetAlerting? budgetAlerting,
            global::System.DateTime? expiresAt)
        {
            this.Id = id;
            this.BudgetScope = budgetScope;
            this.BudgetEntityName = budgetEntityName;
            this.BudgetAmount = budgetAmount;
            this.PreventFurtherUsage = preventFurtherUsage;
            this.BudgetProductSku = budgetProductSku;
            this.BudgetType = budgetType;
            this.BudgetAlerting = budgetAlerting;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBudgetBudget" /> class.
        /// </summary>
        public CreateBudgetBudget()
        {
        }

    }
}