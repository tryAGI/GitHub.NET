
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksListTasksResponseErrorCode
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
    public static class AgentTasksListTasksResponseErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksResponseErrorCode value)
        {
            return value switch
            {
                AgentTasksListTasksResponseErrorCode.AlreadyExists => "already_exists",
                AgentTasksListTasksResponseErrorCode.Custom => "custom",
                AgentTasksListTasksResponseErrorCode.Invalid => "invalid",
                AgentTasksListTasksResponseErrorCode.Missing => "missing",
                AgentTasksListTasksResponseErrorCode.MissingField => "missing_field",
                AgentTasksListTasksResponseErrorCode.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksResponseErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksListTasksResponseErrorCode.AlreadyExists,
                "custom" => AgentTasksListTasksResponseErrorCode.Custom,
                "invalid" => AgentTasksListTasksResponseErrorCode.Invalid,
                "missing" => AgentTasksListTasksResponseErrorCode.Missing,
                "missing_field" => AgentTasksListTasksResponseErrorCode.MissingField,
                "unprocessable" => AgentTasksListTasksResponseErrorCode.Unprocessable,
                _ => null,
            };
        }
    }
}