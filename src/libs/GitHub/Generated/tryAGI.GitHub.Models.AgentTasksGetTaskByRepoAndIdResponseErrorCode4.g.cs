
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByRepoAndIdResponseErrorCode4
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
    public static class AgentTasksGetTaskByRepoAndIdResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByRepoAndIdResponseErrorCode4 value)
        {
            return value switch
            {
                AgentTasksGetTaskByRepoAndIdResponseErrorCode4.AlreadyExists => "already_exists",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode4.Custom => "custom",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode4.Invalid => "invalid",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode4.Missing => "missing",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode4.MissingField => "missing_field",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode4.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByRepoAndIdResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByRepoAndIdResponseErrorCode4.AlreadyExists,
                "custom" => AgentTasksGetTaskByRepoAndIdResponseErrorCode4.Custom,
                "invalid" => AgentTasksGetTaskByRepoAndIdResponseErrorCode4.Invalid,
                "missing" => AgentTasksGetTaskByRepoAndIdResponseErrorCode4.Missing,
                "missing_field" => AgentTasksGetTaskByRepoAndIdResponseErrorCode4.MissingField,
                "unprocessable" => AgentTasksGetTaskByRepoAndIdResponseErrorCode4.Unprocessable,
                _ => null,
            };
        }
    }
}