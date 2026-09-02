
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksListTasksResponseErrorCode3
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
    public static class AgentTasksListTasksResponseErrorCode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksResponseErrorCode3 value)
        {
            return value switch
            {
                AgentTasksListTasksResponseErrorCode3.AlreadyExists => "already_exists",
                AgentTasksListTasksResponseErrorCode3.Custom => "custom",
                AgentTasksListTasksResponseErrorCode3.Invalid => "invalid",
                AgentTasksListTasksResponseErrorCode3.Missing => "missing",
                AgentTasksListTasksResponseErrorCode3.MissingField => "missing_field",
                AgentTasksListTasksResponseErrorCode3.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksResponseErrorCode3? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksListTasksResponseErrorCode3.AlreadyExists,
                "custom" => AgentTasksListTasksResponseErrorCode3.Custom,
                "invalid" => AgentTasksListTasksResponseErrorCode3.Invalid,
                "missing" => AgentTasksListTasksResponseErrorCode3.Missing,
                "missing_field" => AgentTasksListTasksResponseErrorCode3.MissingField,
                "unprocessable" => AgentTasksListTasksResponseErrorCode3.Unprocessable,
                _ => null,
            };
        }
    }
}