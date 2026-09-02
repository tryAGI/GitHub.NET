
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseErrorCode2
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
    public static class AgentTasksGetTaskByIdResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseErrorCode2 value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseErrorCode2.AlreadyExists => "already_exists",
                AgentTasksGetTaskByIdResponseErrorCode2.Custom => "custom",
                AgentTasksGetTaskByIdResponseErrorCode2.Invalid => "invalid",
                AgentTasksGetTaskByIdResponseErrorCode2.Missing => "missing",
                AgentTasksGetTaskByIdResponseErrorCode2.MissingField => "missing_field",
                AgentTasksGetTaskByIdResponseErrorCode2.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByIdResponseErrorCode2.AlreadyExists,
                "custom" => AgentTasksGetTaskByIdResponseErrorCode2.Custom,
                "invalid" => AgentTasksGetTaskByIdResponseErrorCode2.Invalid,
                "missing" => AgentTasksGetTaskByIdResponseErrorCode2.Missing,
                "missing_field" => AgentTasksGetTaskByIdResponseErrorCode2.MissingField,
                "unprocessable" => AgentTasksGetTaskByIdResponseErrorCode2.Unprocessable,
                _ => null,
            };
        }
    }
}