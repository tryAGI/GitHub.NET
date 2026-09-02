
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByRepoAndIdResponseErrorCode3
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
    public static class AgentTasksGetTaskByRepoAndIdResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByRepoAndIdResponseErrorCode3 value)
        {
            return value switch
            {
                AgentTasksGetTaskByRepoAndIdResponseErrorCode3.AlreadyExists => "already_exists",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode3.Custom => "custom",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode3.Invalid => "invalid",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode3.Missing => "missing",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode3.MissingField => "missing_field",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode3.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByRepoAndIdResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByRepoAndIdResponseErrorCode3.AlreadyExists,
                "custom" => AgentTasksGetTaskByRepoAndIdResponseErrorCode3.Custom,
                "invalid" => AgentTasksGetTaskByRepoAndIdResponseErrorCode3.Invalid,
                "missing" => AgentTasksGetTaskByRepoAndIdResponseErrorCode3.Missing,
                "missing_field" => AgentTasksGetTaskByRepoAndIdResponseErrorCode3.MissingField,
                "unprocessable" => AgentTasksGetTaskByRepoAndIdResponseErrorCode3.Unprocessable,
                _ => null,
            };
        }
    }
}