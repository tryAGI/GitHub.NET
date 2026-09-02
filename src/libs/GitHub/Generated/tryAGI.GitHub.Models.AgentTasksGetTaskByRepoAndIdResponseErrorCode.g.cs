
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByRepoAndIdResponseErrorCode
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
    public static class AgentTasksGetTaskByRepoAndIdResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByRepoAndIdResponseErrorCode value)
        {
            return value switch
            {
                AgentTasksGetTaskByRepoAndIdResponseErrorCode.AlreadyExists => "already_exists",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode.Custom => "custom",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode.Invalid => "invalid",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode.Missing => "missing",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode.MissingField => "missing_field",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByRepoAndIdResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByRepoAndIdResponseErrorCode.AlreadyExists,
                "custom" => AgentTasksGetTaskByRepoAndIdResponseErrorCode.Custom,
                "invalid" => AgentTasksGetTaskByRepoAndIdResponseErrorCode.Invalid,
                "missing" => AgentTasksGetTaskByRepoAndIdResponseErrorCode.Missing,
                "missing_field" => AgentTasksGetTaskByRepoAndIdResponseErrorCode.MissingField,
                "unprocessable" => AgentTasksGetTaskByRepoAndIdResponseErrorCode.Unprocessable,
                _ => null,
            };
        }
    }
}