
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetBudget
    {
        /// <summary>
        /// ID of the budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of scope for the budget<br/>
        /// Example: enterprise
        /// </summary>
        /// <example>enterprise</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.GetBudgetBudgetScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.GetBudgetBudgetScope BudgetScope { get; set; }

        /// <summary>
        /// The name of the entity to apply the budget to<br/>
        /// Example: octocat/hello-world
        /// </summary>
        /// <example>octocat/hello-world</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_entity_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BudgetEntityName { get; set; }

        /// <summary>
        /// The user login when the budget is scoped to a single user (`user` scope).<br/>
        /// Example: octocat
        /// </summary>
        /// <example>octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// The budget amount in whole dollars. For license-based products, this represents the number of licenses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BudgetAmount { get; set; }

        /// <summary>
        /// Whether to prevent additional spending once the budget is exceeded<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevent_further_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PreventFurtherUsage { get; set; }

        /// <summary>
        /// A single product or sku to apply the budget to.<br/>
        /// Example: actions_linux
        /// </summary>
        /// <example>actions_linux</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_product_sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BudgetProductSku { get; set; }

        /// <summary>
        /// The type of pricing for the budget<br/>
        /// Example: ProductPricing
        /// </summary>
        /// <example>ProductPricing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.GetBudgetBudgetTypeVariant1?, global::tryAGI.GitHub.GetBudgetBudgetTypeVariant2?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.GetBudgetBudgetTypeVariant1?, global::tryAGI.GitHub.GetBudgetBudgetTypeVariant2?> BudgetType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_alerting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.GetBudgetBudgetAlerting BudgetAlerting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBudget" /> class.
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
        /// Example: octocat/hello-world
        /// </param>
        /// <param name="budgetAmount">
        /// The budget amount in whole dollars. For license-based products, this represents the number of licenses.
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
        /// <param name="user">
        /// The user login when the budget is scoped to a single user (`user` scope).<br/>
        /// Example: octocat
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBudget(
            string id,
            global::tryAGI.GitHub.GetBudgetBudgetScope budgetScope,
            string budgetEntityName,
            int budgetAmount,
            bool preventFurtherUsage,
            string budgetProductSku,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.GetBudgetBudgetTypeVariant1?, global::tryAGI.GitHub.GetBudgetBudgetTypeVariant2?> budgetType,
            global::tryAGI.GitHub.GetBudgetBudgetAlerting budgetAlerting,
            string? user)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BudgetScope = budgetScope;
            this.BudgetEntityName = budgetEntityName ?? throw new global::System.ArgumentNullException(nameof(budgetEntityName));
            this.User = user;
            this.BudgetAmount = budgetAmount;
            this.PreventFurtherUsage = preventFurtherUsage;
            this.BudgetProductSku = budgetProductSku ?? throw new global::System.ArgumentNullException(nameof(budgetProductSku));
            this.BudgetType = budgetType;
            this.BudgetAlerting = budgetAlerting ?? throw new global::System.ArgumentNullException(nameof(budgetAlerting));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBudget" /> class.
        /// </summary>
        public GetBudget()
        {
        }

    }
}