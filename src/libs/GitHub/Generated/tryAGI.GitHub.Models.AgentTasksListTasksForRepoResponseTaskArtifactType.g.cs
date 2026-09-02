
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of artifact. Available Values: `pull`, `branch`.
    /// </summary>
    public enum AgentTasksListTasksForRepoResponseTaskArtifactType
    {
        /// <summary>
        /// `pull`, `branch`.
        /// </summary>
        Branch,
        /// <summary>
        /// `pull`, `branch`.
        /// </summary>
        Pull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTasksListTasksForRepoResponseTaskArtifactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksForRepoResponseTaskArtifactType value)
        {
            return value switch
            {
                AgentTasksListTasksForRepoResponseTaskArtifactType.Branch => "branch",
                AgentTasksListTasksForRepoResponseTaskArtifactType.Pull => "pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksForRepoResponseTaskArtifactType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => AgentTasksListTasksForRepoResponseTaskArtifactType.Branch,
                "pull" => AgentTasksListTasksForRepoResponseTaskArtifactType.Pull,
                _ => null,
            };
        }
    }
}