
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBudget
    {
        /// <summary>
        /// A message indicating the result of the create operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CreateBudgetBudget Budget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBudget" /> class.
        /// </summary>
        /// <param name="message">
        /// A message indicating the result of the create operation
        /// </param>
        /// <param name="budget"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBudget(
            string message,
            global::tryAGI.GitHub.CreateBudgetBudget budget)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Budget = budget ?? throw new global::System.ArgumentNullException(nameof(budget));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBudget" /> class.
        /// </summary>
        public CreateBudget()
        {
        }

    }
}