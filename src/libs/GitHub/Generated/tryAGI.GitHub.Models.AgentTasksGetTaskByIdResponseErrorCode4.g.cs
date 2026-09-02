
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseErrorCode4
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
    public static class AgentTasksGetTaskByIdResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseErrorCode4 value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseErrorCode4.AlreadyExists => "already_exists",
                AgentTasksGetTaskByIdResponseErrorCode4.Custom => "custom",
                AgentTasksGetTaskByIdResponseErrorCode4.Invalid => "invalid",
                AgentTasksGetTaskByIdResponseErrorCode4.Missing => "missing",
                AgentTasksGetTaskByIdResponseErrorCode4.MissingField => "missing_field",
                AgentTasksGetTaskByIdResponseErrorCode4.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByIdResponseErrorCode4.AlreadyExists,
                "custom" => AgentTasksGetTaskByIdResponseErrorCode4.Custom,
                "invalid" => AgentTasksGetTaskByIdResponseErrorCode4.Invalid,
                "missing" => AgentTasksGetTaskByIdResponseErrorCode4.Missing,
                "missing_field" => AgentTasksGetTaskByIdResponseErrorCode4.MissingField,
                "unprocessable" => AgentTasksGetTaskByIdResponseErrorCode4.Unprocessable,
                _ => null,
            };
        }
    }
}