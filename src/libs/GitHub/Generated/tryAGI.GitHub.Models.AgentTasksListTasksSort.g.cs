
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: updated_at
    /// </summary>
    public enum AgentTasksListTasksSort
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
    public static class AgentTasksListTasksSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksSort value)
        {
            return value switch
            {
                AgentTasksListTasksSort.CreatedAt => "created_at",
                AgentTasksListTasksSort.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksSort? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => AgentTasksListTasksSort.CreatedAt,
                "updated_at" => AgentTasksListTasksSort.UpdatedAt,
                _ => null,
            };
        }
    }
}