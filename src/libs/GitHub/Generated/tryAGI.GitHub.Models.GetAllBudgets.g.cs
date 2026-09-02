
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAllBudgets
    {
        /// <summary>
        /// Array of budget objects for the enterprise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budgets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.Budget> Budgets { get; set; }

        /// <summary>
        /// User login included when the response is scoped with the `user` query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Effective user-level budget details returned when the response is scoped with the `user` query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_budget")]
        public global::tryAGI.GitHub.GetAllBudgetsEffectiveBudget? EffectiveBudget { get; set; }

        /// <summary>
        /// Indicates if there are more pages of results available (maps to hasNextPage from billing platform)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next_page")]
        public bool? HasNextPage { get; set; }

        /// <summary>
        /// Total number of budgets matching the query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllBudgets" /> class.
        /// </summary>
        /// <param name="budgets">
        /// Array of budget objects for the enterprise
        /// </param>
        /// <param name="user">
        /// User login included when the response is scoped with the `user` query parameter.
        /// </param>
        /// <param name="effectiveBudget">
        /// Effective user-level budget details returned when the response is scoped with the `user` query parameter.
        /// </param>
        /// <param name="hasNextPage">
        /// Indicates if there are more pages of results available (maps to hasNextPage from billing platform)
        /// </param>
        /// <param name="totalCount">
        /// Total number of budgets matching the query
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllBudgets(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.Budget> budgets,
            string? user,
            global::tryAGI.GitHub.GetAllBudgetsEffectiveBudget? effectiveBudget,
            bool? hasNextPage,
            int? totalCount)
        {
            this.Budgets = budgets ?? throw new global::System.ArgumentNullException(nameof(budgets));
            this.User = user;
            this.EffectiveBudget = effectiveBudget;
            this.HasNextPage = hasNextPage;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllBudgets" /> class.
        /// </summary>
        public GetAllBudgets()
        {
        }

    }
}