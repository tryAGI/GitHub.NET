
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of artifact. Available Values: `pull`, `branch`.
    /// </summary>
    public enum AgentTasksCreateTaskInRepoResponseArtifactType
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
    public static class AgentTasksCreateTaskInRepoResponseArtifactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksCreateTaskInRepoResponseArtifactType value)
        {
            return value switch
            {
                AgentTasksCreateTaskInRepoResponseArtifactType.Branch => "branch",
                AgentTasksCreateTaskInRepoResponseArtifactType.Pull => "pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksCreateTaskInRepoResponseArtifactType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => AgentTasksCreateTaskInRepoResponseArtifactType.Branch,
                "pull" => AgentTasksCreateTaskInRepoResponseArtifactType.Pull,
                _ => null,
            };
        }
    }
}