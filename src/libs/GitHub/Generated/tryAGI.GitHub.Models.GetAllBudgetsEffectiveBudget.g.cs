
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Effective user-level budget details returned when the response is scoped with the `user` query parameter.
    /// </summary>
    public sealed partial class GetAllBudgetsEffectiveBudget
    {
        /// <summary>
        /// The unique identifier of the effective budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The budget amount for the effective budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BudgetAmount { get; set; }

        /// <summary>
        /// The consumed amount for the specified user within the effective budget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumed_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ConsumedAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllBudgetsEffectiveBudget" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the effective budget.
        /// </param>
        /// <param name="budgetAmount">
        /// The budget amount for the effective budget.
        /// </param>
        /// <param name="consumedAmount">
        /// The consumed amount for the specified user within the effective budget.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAllBudgetsEffectiveBudget(
            string id,
            int budgetAmount,
            double consumedAmount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BudgetAmount = budgetAmount;
            this.ConsumedAmount = consumedAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllBudgetsEffectiveBudget" /> class.
        /// </summary>
        public GetAllBudgetsEffectiveBudget()
        {
        }

    }
}