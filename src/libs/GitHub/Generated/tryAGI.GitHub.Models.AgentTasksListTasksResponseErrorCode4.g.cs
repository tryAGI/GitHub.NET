
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksListTasksResponseErrorCode4
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
    public static class AgentTasksListTasksResponseErrorCode4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksResponseErrorCode4 value)
        {
            return value switch
            {
                AgentTasksListTasksResponseErrorCode4.AlreadyExists => "already_exists",
                AgentTasksListTasksResponseErrorCode4.Custom => "custom",
                AgentTasksListTasksResponseErrorCode4.Invalid => "invalid",
                AgentTasksListTasksResponseErrorCode4.Missing => "missing",
                AgentTasksListTasksResponseErrorCode4.MissingField => "missing_field",
                AgentTasksListTasksResponseErrorCode4.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksResponseErrorCode4? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksListTasksResponseErrorCode4.AlreadyExists,
                "custom" => AgentTasksListTasksResponseErrorCode4.Custom,
                "invalid" => AgentTasksListTasksResponseErrorCode4.Invalid,
                "missing" => AgentTasksListTasksResponseErrorCode4.Missing,
                "missing_field" => AgentTasksListTasksResponseErrorCode4.MissingField,
                "unprocessable" => AgentTasksListTasksResponseErrorCode4.Unprocessable,
                _ => null,
            };
        }
    }
}