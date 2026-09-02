
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum PullRequestMergeAsyncResultDetailsVariant1MergeAction
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        DirectMerge,
        /// <summary>
        ///
        /// </summary>
        MergeQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullRequestMergeAsyncResultDetailsVariant1MergeActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestMergeAsyncResultDetailsVariant1MergeAction value)
        {
            return value switch
            {
                PullRequestMergeAsyncResultDetailsVariant1MergeAction.Default => "default",
                PullRequestMergeAsyncResultDetailsVariant1MergeAction.DirectMerge => "direct_merge",
                PullRequestMergeAsyncResultDetailsVariant1MergeAction.MergeQueue => "merge_queue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestMergeAsyncResultDetailsVariant1MergeAction? ToEnum(string value)
        {
            return value switch
            {
                "default" => PullRequestMergeAsyncResultDetailsVariant1MergeAction.Default,
                "direct_merge" => PullRequestMergeAsyncResultDetailsVariant1MergeAction.DirectMerge,
                "merge_queue" => PullRequestMergeAsyncResultDetailsVariant1MergeAction.MergeQueue,
                _ => null,
            };
        }
    }
}