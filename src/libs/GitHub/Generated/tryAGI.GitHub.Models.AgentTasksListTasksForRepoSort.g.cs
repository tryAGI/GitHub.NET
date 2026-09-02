
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: updated_at
    /// </summary>
    public enum AgentTasksListTasksForRepoSort
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksListTasksForRepoSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoSort value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoSort.CreatedAt => "created_at",
                AgentTasksListTasksForRepoSort.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoSort? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => AgentTasksListTasksForRepoSort.CreatedAt,
                "updated_at" => AgentTasksListTasksForRepoSort.UpdatedAt,
                _ => null,
            };
        }
    }
}