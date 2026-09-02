
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByRepoAndIdResponseErrorCode2
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
    public static class AgentTasksGetTaskByRepoAndIdResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByRepoAndIdResponseErrorCode2 value)
        {
            return value switch
            {
                AgentTasksGetTaskByRepoAndIdResponseErrorCode2.AlreadyExists => "already_exists",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode2.Custom => "custom",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode2.Invalid => "invalid",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode2.Missing => "missing",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode2.MissingField => "missing_field",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode2.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByRepoAndIdResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByRepoAndIdResponseErrorCode2.AlreadyExists,
                "custom" => AgentTasksGetTaskByRepoAndIdResponseErrorCode2.Custom,
                "invalid" => AgentTasksGetTaskByRepoAndIdResponseErrorCode2.Invalid,
                "missing" => AgentTasksGetTaskByRepoAndIdResponseErrorCode2.Missing,
                "missing_field" => AgentTasksGetTaskByRepoAndIdResponseErrorCode2.MissingField,
                "unprocessable" => AgentTasksGetTaskByRepoAndIdResponseErrorCode2.Unprocessable,
                _ => null,
            };
        }
    }
}