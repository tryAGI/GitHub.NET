
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksListTasksForRepoResponseErrorCode
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
    public static class AgentTasksListTasksForRepoResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoResponseErrorCode value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoResponseErrorCode.AlreadyExists => "already_exists",
                AgentTasksListTasksForRepoResponseErrorCode.Custom => "custom",
                AgentTasksListTasksForRepoResponseErrorCode.Invalid => "invalid",
                AgentTasksListTasksForRepoResponseErrorCode.Missing => "missing",
                AgentTasksListTasksForRepoResponseErrorCode.MissingField => "missing_field",
                AgentTasksListTasksForRepoResponseErrorCode.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksListTasksForRepoResponseErrorCode.AlreadyExists,
                "custom" => AgentTasksListTasksForRepoResponseErrorCode.Custom,
                "invalid" => AgentTasksListTasksForRepoResponseErrorCode.Invalid,
                "missing" => AgentTasksListTasksForRepoResponseErrorCode.Missing,
                "missing_field" => AgentTasksListTasksForRepoResponseErrorCode.MissingField,
                "unprocessable" => AgentTasksListTasksForRepoResponseErrorCode.Unprocessable,
                _ => null,
            };
        }
    }
}