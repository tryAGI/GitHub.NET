
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksCreateTaskInRepoResponseErrorCode
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
    public static class AgentTasksCreateTaskInRepoResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksCreateTaskInRepoResponseErrorCode value)
        {
            return value switch
            {
                AgentTasksCreateTaskInRepoResponseErrorCode.AlreadyExists => "already_exists",
                AgentTasksCreateTaskInRepoResponseErrorCode.Custom => "custom",
                AgentTasksCreateTaskInRepoResponseErrorCode.Invalid => "invalid",
                AgentTasksCreateTaskInRepoResponseErrorCode.Missing => "missing",
                AgentTasksCreateTaskInRepoResponseErrorCode.MissingField => "missing_field",
                AgentTasksCreateTaskInRepoResponseErrorCode.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksCreateTaskInRepoResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksCreateTaskInRepoResponseErrorCode.AlreadyExists,
                "custom" => AgentTasksCreateTaskInRepoResponseErrorCode.Custom,
                "invalid" => AgentTasksCreateTaskInRepoResponseErrorCode.Invalid,
                "missing" => AgentTasksCreateTaskInRepoResponseErrorCode.Missing,
                "missing_field" => AgentTasksCreateTaskInRepoResponseErrorCode.MissingField,
                "unprocessable" => AgentTasksCreateTaskInRepoResponseErrorCode.Unprocessable,
                _ => null,
            };
        }
    }
}