
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Provider namespace
    /// </summary>
    public enum AgentTasksListTasksResponseTaskArtifactProvider
    {
        /// <summary>
        ///
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksListTasksResponseTaskArtifactProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksResponseTaskArtifactProvider value)
        {
            return value switch
            {
                AgentTasksListTasksResponseTaskArtifactProvider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksResponseTaskArtifactProvider? ToEnum(string value)
        {
            return value switch
            {
                "github" => AgentTasksListTasksResponseTaskArtifactProvider.Github,
                _ => null,
            };
        }
    }
}