
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByRepoAndIdResponseErrorCode5
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
    public static class AgentTasksGetTaskByRepoAndIdResponseErrorCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByRepoAndIdResponseErrorCode5 value)
        {
            return value switch
            {
                AgentTasksGetTaskByRepoAndIdResponseErrorCode5.AlreadyExists => "already_exists",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode5.Custom => "custom",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode5.Invalid => "invalid",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode5.Missing => "missing",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode5.MissingField => "missing_field",
                AgentTasksGetTaskByRepoAndIdResponseErrorCode5.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByRepoAndIdResponseErrorCode5? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByRepoAndIdResponseErrorCode5.AlreadyExists,
                "custom" => AgentTasksGetTaskByRepoAndIdResponseErrorCode5.Custom,
                "invalid" => AgentTasksGetTaskByRepoAndIdResponseErrorCode5.Invalid,
                "missing" => AgentTasksGetTaskByRepoAndIdResponseErrorCode5.Missing,
                "missing_field" => AgentTasksGetTaskByRepoAndIdResponseErrorCode5.MissingField,
                "unprocessable" => AgentTasksGetTaskByRepoAndIdResponseErrorCode5.Unprocessable,
                _ => null,
            };
        }
    }
}