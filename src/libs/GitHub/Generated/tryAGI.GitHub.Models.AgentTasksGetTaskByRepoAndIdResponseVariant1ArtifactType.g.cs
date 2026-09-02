
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of artifact. Available Values: `pull`, `branch`.
    /// </summary>
    public enum AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType
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
    public static class AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType value)
        {
            return value switch
            {
                AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType.Branch => "branch",
                AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType.Pull => "pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType.Branch,
                "pull" => AgentTasksGetTaskByRepoAndIdResponseVariant1ArtifactType.Pull,
                _ => null,
            };
        }
    }
}