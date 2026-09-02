
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Type of artifact. Available Values: `pull`, `branch`.
    /// </summary>
    public enum AgentTasksGetTaskByIdResponseVariant1ArtifactType
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
    public static class AgentTasksGetTaskByIdResponseVariant1ArtifactTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTasksGetTaskByIdResponseVariant1ArtifactType value)
        {
            return value switch
            {
                AgentTasksGetTaskByIdResponseVariant1ArtifactType.Branch => "branch",
                AgentTasksGetTaskByIdResponseVariant1ArtifactType.Pull => "pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTasksGetTaskByIdResponseVariant1ArtifactType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => AgentTasksGetTaskByIdResponseVariant1ArtifactType.Branch,
                "pull" => AgentTasksGetTaskByIdResponseVariant1ArtifactType.Pull,
                _ => null,
            };
        }
    }
}