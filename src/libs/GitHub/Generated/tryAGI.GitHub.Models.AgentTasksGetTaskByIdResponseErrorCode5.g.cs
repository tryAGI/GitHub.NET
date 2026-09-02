
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseErrorCode5
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
    public static class AgentTasksGetTaskByIdResponseErrorCode5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseErrorCode5 value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseErrorCode5.AlreadyExists => "already_exists",
                AgentTasksGetTaskByIdResponseErrorCode5.Custom => "custom",
                AgentTasksGetTaskByIdResponseErrorCode5.Invalid => "invalid",
                AgentTasksGetTaskByIdResponseErrorCode5.Missing => "missing",
                AgentTasksGetTaskByIdResponseErrorCode5.MissingField => "missing_field",
                AgentTasksGetTaskByIdResponseErrorCode5.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseErrorCode5? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByIdResponseErrorCode5.AlreadyExists,
                "custom" => AgentTasksGetTaskByIdResponseErrorCode5.Custom,
                "invalid" => AgentTasksGetTaskByIdResponseErrorCode5.Invalid,
                "missing" => AgentTasksGetTaskByIdResponseErrorCode5.Missing,
                "missing_field" => AgentTasksGetTaskByIdResponseErrorCode5.MissingField,
                "unprocessable" => AgentTasksGetTaskByIdResponseErrorCode5.Unprocessable,
                _ => null,
            };
        }
    }
}