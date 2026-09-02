
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of the task creator
    /// </summary>
    public enum AgentTasksCreateTaskInRepoResponseCreatorType
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
    public static class AgentTasksCreateTaskInRepoResponseCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksCreateTaskInRepoResponseCreatorType value)
        {
            return value switch
            {
                AgentTasksCreateTaskInRepoResponseCreatorType.Organization => "organization",
                AgentTasksCreateTaskInRepoResponseCreatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksCreateTaskInRepoResponseCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => AgentTasksCreateTaskInRepoResponseCreatorType.Organization,
                "user" => AgentTasksCreateTaskInRepoResponseCreatorType.User,
                _ => null,
            };
        }
    }
}