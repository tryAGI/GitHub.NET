
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The action that will be taken to merge the pull request. `direct_merge` merges the pull request directly without using a merge queue; `merge_queue` adds the pull request to a merge queue; `default` selects the most appropriate option.
    /// </summary>
    public enum PullsMergeAsyncRequestMergeAction
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
    public static class PullsMergeAsyncRequestMergeActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsMergeAsyncRequestMergeAction value)
        {
            return value switch
            {
                PullsMergeAsyncRequestMergeAction.Default => "default",
                PullsMergeAsyncRequestMergeAction.DirectMerge => "direct_merge",
                PullsMergeAsyncRequestMergeAction.MergeQueue => "merge_queue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsMergeAsyncRequestMergeAction? ToEnum(string value)
        {
            return value switch
            {
                "default" => PullsMergeAsyncRequestMergeAction.Default,
                "direct_merge" => PullsMergeAsyncRequestMergeAction.DirectMerge,
                "merge_queue" => PullsMergeAsyncRequestMergeAction.MergeQueue,
                _ => null,
            };
        }
    }
}