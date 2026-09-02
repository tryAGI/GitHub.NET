
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of the task creator
    /// </summary>
    public enum AgentTasksListTasksForRepoResponseTaskCreatorType
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
    public static class AgentTasksListTasksForRepoResponseTaskCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoResponseTaskCreatorType value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoResponseTaskCreatorType.Organization => "organization",
                AgentTasksListTasksForRepoResponseTaskCreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoResponseTaskCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => AgentTasksListTasksForRepoResponseTaskCreatorType.Organization,
                "user" => AgentTasksListTasksForRepoResponseTaskCreatorType.User,
                _ => null,
            };
        }
    }
}