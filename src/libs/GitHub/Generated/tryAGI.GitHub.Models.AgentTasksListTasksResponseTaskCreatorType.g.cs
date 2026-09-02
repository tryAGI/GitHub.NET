
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of the task creator
    /// </summary>
    public enum AgentTasksListTasksResponseTaskCreatorType
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
    public static class AgentTasksListTasksResponseTaskCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksResponseTaskCreatorType value)
        {
            return value switch
            {
                AgentTasksListTasksResponseTaskCreatorType.Organization => "organization",
                AgentTasksListTasksResponseTaskCreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksResponseTaskCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => AgentTasksListTasksResponseTaskCreatorType.Organization,
                "user" => AgentTasksListTasksResponseTaskCreatorType.User,
                _ => null,
            };
        }
    }
}