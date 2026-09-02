
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksCreateTaskInRepoResponseErrorCode4
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
    public static class AgentTasksCreateTaskInRepoResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksCreateTaskInRepoResponseErrorCode4 value)
        {
            return value switch
            {
                AgentTasksCreateTaskInRepoResponseErrorCode4.AlreadyExists => "already_exists",
                AgentTasksCreateTaskInRepoResponseErrorCode4.Custom => "custom",
                AgentTasksCreateTaskInRepoResponseErrorCode4.Invalid => "invalid",
                AgentTasksCreateTaskInRepoResponseErrorCode4.Missing => "missing",
                AgentTasksCreateTaskInRepoResponseErrorCode4.MissingField => "missing_field",
                AgentTasksCreateTaskInRepoResponseErrorCode4.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksCreateTaskInRepoResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksCreateTaskInRepoResponseErrorCode4.AlreadyExists,
                "custom" => AgentTasksCreateTaskInRepoResponseErrorCode4.Custom,
                "invalid" => AgentTasksCreateTaskInRepoResponseErrorCode4.Invalid,
                "missing" => AgentTasksCreateTaskInRepoResponseErrorCode4.Missing,
                "missing_field" => AgentTasksCreateTaskInRepoResponseErrorCode4.MissingField,
                "unprocessable" => AgentTasksCreateTaskInRepoResponseErrorCode4.Unprocessable,
                _ => null,
            };
        }
    }
}