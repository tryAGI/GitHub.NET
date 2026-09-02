
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Provider namespace
    /// </summary>
    public enum AgentTasksCreateTaskInRepoResponseArtifactProvider
    {
        /// <summary>
        ///
        /// </summary>
        Github,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksCreateTaskInRepoResponseArtifactProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksCreateTaskInRepoResponseArtifactProvider value)
        {
            return value switch
            {
                AgentTasksCreateTaskInRepoResponseArtifactProvider.Github => "github",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksCreateTaskInRepoResponseArtifactProvider? ToEnum(string value)
        {
            return value switch
            {
                "github" => AgentTasksCreateTaskInRepoResponseArtifactProvider.Github,
                _ => null,
            };
        }
    }
}