
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum AgentTasksListTasksForRepoDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksListTasksForRepoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoDirection value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoDirection.Asc => "asc",
                AgentTasksListTasksForRepoDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AgentTasksListTasksForRepoDirection.Asc,
                "desc" => AgentTasksListTasksForRepoDirection.Desc,
                _ => null,
            };
        }
    }
}