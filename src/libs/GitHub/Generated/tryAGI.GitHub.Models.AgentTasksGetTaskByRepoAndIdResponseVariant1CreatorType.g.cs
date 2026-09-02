
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of the task creator
    /// </summary>
    public enum AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorType value)
        {
            return value switch
            {
                AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorType.Organization => "organization",
                AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorType.Organization,
                "user" => AgentTasksGetTaskByRepoAndIdResponseVariant1CreatorType.User,
                _ => null,
            };
        }
    }
}