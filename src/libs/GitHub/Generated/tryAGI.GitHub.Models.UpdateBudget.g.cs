
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateBudget
    {
        /// <summary>
        /// A message indicating the result of the update operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.UpdateBudgetBudget Budget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBudget" /> class.
        /// </summary>
        /// <param name="message">
        /// A message indicating the result of the update operation
        /// </param>
        /// <param name="budget"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBudget(
            string message,
            global::tryAGI.GitHub.UpdateBudgetBudget budget)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Budget = budget ?? throw new global::System.ArgumentNullException(nameof(budget));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBudget" /> class.
        /// </summary>
        public UpdateBudget()
        {
        }

    }
}