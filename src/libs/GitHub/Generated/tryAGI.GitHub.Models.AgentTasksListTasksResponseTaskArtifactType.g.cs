
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of artifact. Available Values: `pull`, `branch`.
    /// </summary>
    public enum AgentTasksListTasksResponseTaskArtifactType
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
    public static class AgentTasksListTasksResponseTaskArtifactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksListTasksResponseTaskArtifactType value)
        {
            return value switch
            {
                AgentTasksListTasksResponseTaskArtifactType.Branch => "branch",
                AgentTasksListTasksResponseTaskArtifactType.Pull => "pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksListTasksResponseTaskArtifactType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => AgentTasksListTasksResponseTaskArtifactType.Branch,
                "pull" => AgentTasksListTasksResponseTaskArtifactType.Pull,
                _ => null,
            };
        }
    }
}