
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Structured information about billing units consumed by the session.
    /// </summary>
    public sealed partial class AgentTasksGetTaskByRepoAndIdResponseVariant2SessionUsage
    {
        /// <summary>
        /// Billing unit used for this session. New sessions since June 1, 2026 use `ai_credits`, but older sessions use `premium_requests`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AgentTasksGetTaskByRepoAndIdResponseVariant2SessionUsageTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant2SessionUsageType Type { get; set; }

        /// <summary>
        /// Number of billing units used by this session. When the `type` is `ai_credits`, the value is a whole number, expressed in nano units. When presenting this to a human, divide by 1,000,000,000 and round to one decimal place. When aggregating (for example, summing usage across sessions), sum the nano values first, and divide once at the end before presenting to a human to avoid losing precision. When the `type` is `premium_requests`, the value may be fractional (for example `1.5`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant2SessionUsage" /> class.
        /// </summary>
        /// <param name="type">
        /// Billing unit used for this session. New sessions since June 1, 2026 use `ai_credits`, but older sessions use `premium_requests`.
        /// </param>
        /// <param name="amount">
        /// Number of billing units used by this session. When the `type` is `ai_credits`, the value is a whole number, expressed in nano units. When presenting this to a human, divide by 1,000,000,000 and round to one decimal place. When aggregating (for example, summing usage across sessions), sum the nano values first, and divide once at the end before presenting to a human to avoid losing precision. When the `type` is `premium_requests`, the value may be fractional (for example `1.5`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentTasksGetTaskByRepoAndIdResponseVariant2SessionUsage(
            global::tryAGI.GitHub.AgentTasksGetTaskByRepoAndIdResponseVariant2SessionUsageType type,
            double amount)
        {
            this.Type = type;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentTasksGetTaskByRepoAndIdResponseVariant2SessionUsage" /> class.
        /// </summary>
        public AgentTasksGetTaskByRepoAndIdResponseVariant2SessionUsage()
        {
        }

    }
}