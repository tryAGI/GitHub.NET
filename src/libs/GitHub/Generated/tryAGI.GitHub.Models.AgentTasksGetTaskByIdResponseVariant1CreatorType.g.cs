
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of the task creator
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseVariant1CreatorType
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
    public static class AgentTasksGetTaskByIdResponseVariant1CreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseVariant1CreatorType value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseVariant1CreatorType.Organization => "organization",
                AgentTasksGetTaskByIdResponseVariant1CreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseVariant1CreatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => AgentTasksGetTaskByIdResponseVariant1CreatorType.Organization,
                "user" => AgentTasksGetTaskByIdResponseVariant1CreatorType.User,
                _ => null,
            };
        }
    }
}