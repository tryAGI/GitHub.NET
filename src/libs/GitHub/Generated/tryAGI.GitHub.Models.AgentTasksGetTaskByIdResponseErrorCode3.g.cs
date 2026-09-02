
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseErrorCode3
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
    public static class AgentTasksGetTaskByIdResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseErrorCode3 value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseErrorCode3.AlreadyExists => "already_exists",
                AgentTasksGetTaskByIdResponseErrorCode3.Custom => "custom",
                AgentTasksGetTaskByIdResponseErrorCode3.Invalid => "invalid",
                AgentTasksGetTaskByIdResponseErrorCode3.Missing => "missing",
                AgentTasksGetTaskByIdResponseErrorCode3.MissingField => "missing_field",
                AgentTasksGetTaskByIdResponseErrorCode3.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByIdResponseErrorCode3.AlreadyExists,
                "custom" => AgentTasksGetTaskByIdResponseErrorCode3.Custom,
                "invalid" => AgentTasksGetTaskByIdResponseErrorCode3.Invalid,
                "missing" => AgentTasksGetTaskByIdResponseErrorCode3.Missing,
                "missing_field" => AgentTasksGetTaskByIdResponseErrorCode3.MissingField,
                "unprocessable" => AgentTasksGetTaskByIdResponseErrorCode3.Unprocessable,
                _ => null,
            };
        }
    }
}