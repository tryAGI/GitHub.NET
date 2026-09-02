
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum PullRequestMergeAsyncResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Enqueued,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Merged,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullRequestMergeAsyncResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestMergeAsyncResultStatus value)
        {
            return value switch
            {
                PullRequestMergeAsyncResultStatus.Enqueued => "enqueued",
                PullRequestMergeAsyncResultStatus.Failed => "failed",
                PullRequestMergeAsyncResultStatus.Merged => "merged",
                PullRequestMergeAsyncResultStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestMergeAsyncResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "enqueued" => PullRequestMergeAsyncResultStatus.Enqueued,
                "failed" => PullRequestMergeAsyncResultStatus.Failed,
                "merged" => PullRequestMergeAsyncResultStatus.Merged,
                "pending" => PullRequestMergeAsyncResultStatus.Pending,
                _ => null,
            };
        }
    }
}