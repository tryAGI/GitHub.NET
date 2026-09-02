
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksCreateTaskInRepoResponseErrorCode3
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
    public static class AgentTasksCreateTaskInRepoResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksCreateTaskInRepoResponseErrorCode3 value)
        {
            return value switch
            {
                AgentTasksCreateTaskInRepoResponseErrorCode3.AlreadyExists => "already_exists",
                AgentTasksCreateTaskInRepoResponseErrorCode3.Custom => "custom",
                AgentTasksCreateTaskInRepoResponseErrorCode3.Invalid => "invalid",
                AgentTasksCreateTaskInRepoResponseErrorCode3.Missing => "missing",
                AgentTasksCreateTaskInRepoResponseErrorCode3.MissingField => "missing_field",
                AgentTasksCreateTaskInRepoResponseErrorCode3.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksCreateTaskInRepoResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksCreateTaskInRepoResponseErrorCode3.AlreadyExists,
                "custom" => AgentTasksCreateTaskInRepoResponseErrorCode3.Custom,
                "invalid" => AgentTasksCreateTaskInRepoResponseErrorCode3.Invalid,
                "missing" => AgentTasksCreateTaskInRepoResponseErrorCode3.Missing,
                "missing_field" => AgentTasksCreateTaskInRepoResponseErrorCode3.MissingField,
                "unprocessable" => AgentTasksCreateTaskInRepoResponseErrorCode3.Unprocessable,
                _ => null,
            };
        }
    }
}