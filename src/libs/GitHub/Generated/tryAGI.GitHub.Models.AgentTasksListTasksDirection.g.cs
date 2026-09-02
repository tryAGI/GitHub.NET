
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum AgentTasksListTasksDirection
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksListTasksDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksDirection value)
        {
            return value switch
            {
                AgentTasksListTasksDirection.Asc => "asc",
                AgentTasksListTasksDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AgentTasksListTasksDirection.Asc,
                "desc" => AgentTasksListTasksDirection.Desc,
                _ => null,
            };
        }
    }
}