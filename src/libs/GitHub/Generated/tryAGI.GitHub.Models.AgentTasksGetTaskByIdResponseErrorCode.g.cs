
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseErrorCode
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
    public static class AgentTasksGetTaskByIdResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseErrorCode value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseErrorCode.AlreadyExists => "already_exists",
                AgentTasksGetTaskByIdResponseErrorCode.Custom => "custom",
                AgentTasksGetTaskByIdResponseErrorCode.Invalid => "invalid",
                AgentTasksGetTaskByIdResponseErrorCode.Missing => "missing",
                AgentTasksGetTaskByIdResponseErrorCode.MissingField => "missing_field",
                AgentTasksGetTaskByIdResponseErrorCode.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksGetTaskByIdResponseErrorCode.AlreadyExists,
                "custom" => AgentTasksGetTaskByIdResponseErrorCode.Custom,
                "invalid" => AgentTasksGetTaskByIdResponseErrorCode.Invalid,
                "missing" => AgentTasksGetTaskByIdResponseErrorCode.Missing,
                "missing_field" => AgentTasksGetTaskByIdResponseErrorCode.MissingField,
                "unprocessable" => AgentTasksGetTaskByIdResponseErrorCode.Unprocessable,
                _ => null,
            };
        }
    }
}