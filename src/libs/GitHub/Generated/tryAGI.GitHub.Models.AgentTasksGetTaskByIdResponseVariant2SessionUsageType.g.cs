
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Billing unit used for this session. New sessions since June 1, 2026 use `ai_credits`, but older sessions use `premium_requests`.
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseVariant2SessionUsageType
    {
        /// <summary>
        ///
        /// </summary>
        AiCredits,
        /// <summary>
        ///
        /// </summary>
        PremiumRequests,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksGetTaskByIdResponseVariant2SessionUsageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseVariant2SessionUsageType value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseVariant2SessionUsageType.AiCredits => "ai_credits",
                AgentTasksGetTaskByIdResponseVariant2SessionUsageType.PremiumRequests => "premium_requests",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseVariant2SessionUsageType? ToEnum(string value)
        {
            return value switch
            {
                "ai_credits" => AgentTasksGetTaskByIdResponseVariant2SessionUsageType.AiCredits,
                "premium_requests" => AgentTasksGetTaskByIdResponseVariant2SessionUsageType.PremiumRequests,
                _ => null,
            };
        }
    }
}