
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksListTasksForRepoResponseErrorCode3
    {
        /// <summary>
        ///
        /// </summary>
        AlreadyExists,
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Invalid,
        /// <summary>
        ///
        /// </summary>
        Missing,
        /// <summary>
        ///
        /// </summary>
        MissingField,
        /// <summary>
        ///
        /// </summary>
        Unprocessable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksListTasksForRepoResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoResponseErrorCode3 value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoResponseErrorCode3.AlreadyExists => "already_exists",
                AgentTasksListTasksForRepoResponseErrorCode3.Custom => "custom",
                AgentTasksListTasksForRepoResponseErrorCode3.Invalid => "invalid",
                AgentTasksListTasksForRepoResponseErrorCode3.Missing => "missing",
                AgentTasksListTasksForRepoResponseErrorCode3.MissingField => "missing_field",
                AgentTasksListTasksForRepoResponseErrorCode3.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksListTasksForRepoResponseErrorCode3.AlreadyExists,
                "custom" => AgentTasksListTasksForRepoResponseErrorCode3.Custom,
                "invalid" => AgentTasksListTasksForRepoResponseErrorCode3.Invalid,
                "missing" => AgentTasksListTasksForRepoResponseErrorCode3.Missing,
                "missing_field" => AgentTasksListTasksForRepoResponseErrorCode3.MissingField,
                "unprocessable" => AgentTasksListTasksForRepoResponseErrorCode3.Unprocessable,
                _ => null,
            };
        }
    }
}