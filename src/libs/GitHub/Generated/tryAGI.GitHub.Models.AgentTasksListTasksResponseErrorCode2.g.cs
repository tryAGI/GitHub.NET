
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Machine-readable error code
    /// </summary>
    public enum AgentTasksListTasksResponseErrorCode2
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
    public static class AgentTasksListTasksResponseErrorCode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksResponseErrorCode2 value)
        {
            return value switch
            {
                AgentTasksListTasksResponseErrorCode2.AlreadyExists => "already_exists",
                AgentTasksListTasksResponseErrorCode2.Custom => "custom",
                AgentTasksListTasksResponseErrorCode2.Invalid => "invalid",
                AgentTasksListTasksResponseErrorCode2.Missing => "missing",
                AgentTasksListTasksResponseErrorCode2.MissingField => "missing_field",
                AgentTasksListTasksResponseErrorCode2.Unprocessable => "unprocessable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksResponseErrorCode2? ToEnum(string value)
        {
            return value switch
            {
                "already_exists" => AgentTasksListTasksResponseErrorCode2.AlreadyExists,
                "custom" => AgentTasksListTasksResponseErrorCode2.Custom,
                "invalid" => AgentTasksListTasksResponseErrorCode2.Invalid,
                "missing" => AgentTasksListTasksResponseErrorCode2.Missing,
                "missing_field" => AgentTasksListTasksResponseErrorCode2.MissingField,
                "unprocessable" => AgentTasksListTasksResponseErrorCode2.Unprocessable,
                _ => null,
            };
        }
    }
}