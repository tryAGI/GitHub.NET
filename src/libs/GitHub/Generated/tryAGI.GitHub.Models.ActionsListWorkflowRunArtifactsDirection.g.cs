
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ActionsListWorkflowRunArtifactsDirection
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
    public static class ActionsListWorkflowRunArtifactsDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListWorkflowRunArtifactsDirection value)
        {
            return value switch
            {
                ActionsListWorkflowRunArtifactsDirection.Asc => "asc",
                ActionsListWorkflowRunArtifactsDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListWorkflowRunArtifactsDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ActionsListWorkflowRunArtifactsDirection.Asc,
                "desc" => ActionsListWorkflowRunArtifactsDirection.Desc,
                _ => null,
            };
        }
    }
}