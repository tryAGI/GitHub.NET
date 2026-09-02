
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Provider namespace
    /// </summary>
    public enum AgentTasksListTasksForRepoResponseTaskArtifactProvider
    {
        /// <summary>
        ///
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksListTasksForRepoResponseTaskArtifactProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoResponseTaskArtifactProvider value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoResponseTaskArtifactProvider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoResponseTaskArtifactProvider? ToEnum(string value)
        {
            return value switch
            {
                "github" => AgentTasksListTasksForRepoResponseTaskArtifactProvider.Github,
                _ => null,
            };
        }
    }
}