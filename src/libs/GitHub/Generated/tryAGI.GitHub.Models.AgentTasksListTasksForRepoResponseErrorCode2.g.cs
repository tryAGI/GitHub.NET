
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksListTasksForRepoResponseErrorCode2
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
    public static class AgentTasksListTasksForRepoResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoResponseErrorCode2 value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoResponseErrorCode2.AlreadyExists => "already_exists",
                AgentTasksListTasksForRepoResponseErrorCode2.Custom => "custom",
                AgentTasksListTasksForRepoResponseErrorCode2.Invalid => "invalid",
                AgentTasksListTasksForRepoResponseErrorCode2.Missing => "missing",
                AgentTasksListTasksForRepoResponseErrorCode2.MissingField => "missing_field",
                AgentTasksListTasksForRepoResponseErrorCode2.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksListTasksForRepoResponseErrorCode2.AlreadyExists,
                "custom" => AgentTasksListTasksForRepoResponseErrorCode2.Custom,
                "invalid" => AgentTasksListTasksForRepoResponseErrorCode2.Invalid,
                "missing" => AgentTasksListTasksForRepoResponseErrorCode2.Missing,
                "missing_field" => AgentTasksListTasksForRepoResponseErrorCode2.MissingField,
                "unprocessable" => AgentTasksListTasksForRepoResponseErrorCode2.Unprocessable,
                _ => null,
            };
        }
    }
}