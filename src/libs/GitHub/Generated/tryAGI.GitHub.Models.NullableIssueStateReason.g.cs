
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The reason for the current state<br/>
    /// Example: not_planned
    /// </summary>
    public enum NullableIssueStateReason
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
    public static class NullableIssueStateReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableIssueStateReason value)
        {
            return value switch
            {
                NullableIssueStateReason.Completed => "completed",
                NullableIssueStateReason.Duplicate => "duplicate",
                NullableIssueStateReason.NotPlanned => "not_planned",
                NullableIssueStateReason.Reopened => "reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableIssueStateReason? ToEnum(string value)
        {
            return value switch
            {
                "completed" => NullableIssueStateReason.Completed,
                "duplicate" => NullableIssueStateReason.Duplicate,
                "not_planned" => NullableIssueStateReason.NotPlanned,
                "reopened" => NullableIssueStateReason.Reopened,
                _ => null,
            };
        }
    }
}