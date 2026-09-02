
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksListTasksForRepoResponseErrorCode5
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
    public static class AgentTasksListTasksForRepoResponseErrorCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoResponseErrorCode5 value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoResponseErrorCode5.AlreadyExists => "already_exists",
                AgentTasksListTasksForRepoResponseErrorCode5.Custom => "custom",
                AgentTasksListTasksForRepoResponseErrorCode5.Invalid => "invalid",
                AgentTasksListTasksForRepoResponseErrorCode5.Missing => "missing",
                AgentTasksListTasksForRepoResponseErrorCode5.MissingField => "missing_field",
                AgentTasksListTasksForRepoResponseErrorCode5.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoResponseErrorCode5? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksListTasksForRepoResponseErrorCode5.AlreadyExists,
                "custom" => AgentTasksListTasksForRepoResponseErrorCode5.Custom,
                "invalid" => AgentTasksListTasksForRepoResponseErrorCode5.Invalid,
                "missing" => AgentTasksListTasksForRepoResponseErrorCode5.Missing,
                "missing_field" => AgentTasksListTasksForRepoResponseErrorCode5.MissingField,
                "unprocessable" => AgentTasksListTasksForRepoResponseErrorCode5.Unprocessable,
                _ => null,
            };
        }
    }
}