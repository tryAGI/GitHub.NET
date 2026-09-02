
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Provider namespace
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseVariant1ArtifactProvider
    {
        /// <summary>
        ///
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksGetTaskByIdResponseVariant1ArtifactProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseVariant1ArtifactProvider value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseVariant1ArtifactProvider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseVariant1ArtifactProvider? ToEnum(string value)
        {
            return value switch
            {
                "github" => AgentTasksGetTaskByIdResponseVariant1ArtifactProvider.Github,
                _ => null,
            };
        }
    }
}