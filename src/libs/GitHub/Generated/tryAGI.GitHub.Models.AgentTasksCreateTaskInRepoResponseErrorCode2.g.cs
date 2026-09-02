
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksCreateTaskInRepoResponseErrorCode2
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
    public static class AgentTasksCreateTaskInRepoResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksCreateTaskInRepoResponseErrorCode2 value)
        {
            return value switch
            {
                AgentTasksCreateTaskInRepoResponseErrorCode2.AlreadyExists => "already_exists",
                AgentTasksCreateTaskInRepoResponseErrorCode2.Custom => "custom",
                AgentTasksCreateTaskInRepoResponseErrorCode2.Invalid => "invalid",
                AgentTasksCreateTaskInRepoResponseErrorCode2.Missing => "missing",
                AgentTasksCreateTaskInRepoResponseErrorCode2.MissingField => "missing_field",
                AgentTasksCreateTaskInRepoResponseErrorCode2.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksCreateTaskInRepoResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksCreateTaskInRepoResponseErrorCode2.AlreadyExists,
                "custom" => AgentTasksCreateTaskInRepoResponseErrorCode2.Custom,
                "invalid" => AgentTasksCreateTaskInRepoResponseErrorCode2.Invalid,
                "missing" => AgentTasksCreateTaskInRepoResponseErrorCode2.Missing,
                "missing_field" => AgentTasksCreateTaskInRepoResponseErrorCode2.MissingField,
                "unprocessable" => AgentTasksCreateTaskInRepoResponseErrorCode2.Unprocessable,
                _ => null,
            };
        }
    }
}