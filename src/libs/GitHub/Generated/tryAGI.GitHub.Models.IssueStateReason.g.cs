
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The reason for the current state<br/>
    /// Example: not_planned
    /// </summary>
    public enum IssueStateReason
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Duplicate,
        /// <summary>
        ///
        /// </summary>
        NotPlanned,
        /// <summary>
        ///
        /// </summary>
        Reopened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IssueStateReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueStateReason value)
        {
            return value switch
            {
                IssueStateReason.Completed => "completed",
                IssueStateReason.Duplicate => "duplicate",
                IssueStateReason.NotPlanned => "not_planned",
                IssueStateReason.Reopened => "reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueStateReason? ToEnum(string value)
        {
            return value switch
            {
                "completed" => IssueStateReason.Completed,
                "duplicate" => IssueStateReason.Duplicate,
                "not_planned" => IssueStateReason.NotPlanned,
                "reopened" => IssueStateReason.Reopened,
                _ => null,
            };
        }
    }
}