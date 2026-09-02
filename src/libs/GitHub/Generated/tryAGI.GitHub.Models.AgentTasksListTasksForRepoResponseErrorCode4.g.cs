
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksListTasksForRepoResponseErrorCode4
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
    public static class AgentTasksListTasksForRepoResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoResponseErrorCode4 value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoResponseErrorCode4.AlreadyExists => "already_exists",
                AgentTasksListTasksForRepoResponseErrorCode4.Custom => "custom",
                AgentTasksListTasksForRepoResponseErrorCode4.Invalid => "invalid",
                AgentTasksListTasksForRepoResponseErrorCode4.Missing => "missing",
                AgentTasksListTasksForRepoResponseErrorCode4.MissingField => "missing_field",
                AgentTasksListTasksForRepoResponseErrorCode4.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksListTasksForRepoResponseErrorCode4.AlreadyExists,
                "custom" => AgentTasksListTasksForRepoResponseErrorCode4.Custom,
                "invalid" => AgentTasksListTasksForRepoResponseErrorCode4.Invalid,
                "missing" => AgentTasksListTasksForRepoResponseErrorCode4.Missing,
                "missing_field" => AgentTasksListTasksForRepoResponseErrorCode4.MissingField,
                "unprocessable" => AgentTasksListTasksForRepoResponseErrorCode4.Unprocessable,
                _ => null,
            };
        }
    }
}