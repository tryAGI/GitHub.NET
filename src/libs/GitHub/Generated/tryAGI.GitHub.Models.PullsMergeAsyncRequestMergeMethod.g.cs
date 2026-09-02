
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum PullsMergeAsyncRequestMergeMethod
    {
        /// <summary>
        ///
        /// </summary>
        Merge,
        /// <summary>
        ///
        /// </summary>
        Rebase,
        /// <summary>
        ///
        /// </summary>
        Squash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsMergeAsyncRequestMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsMergeAsyncRequestMergeMethod value)
        {
            return value switch
            {
                PullsMergeAsyncRequestMergeMethod.Merge => "merge",
                PullsMergeAsyncRequestMergeMethod.Rebase => "rebase",
                PullsMergeAsyncRequestMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsMergeAsyncRequestMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => PullsMergeAsyncRequestMergeMethod.Merge,
                "rebase" => PullsMergeAsyncRequestMergeMethod.Rebase,
                "squash" => PullsMergeAsyncRequestMergeMethod.Squash,
                _ => null,
            };
        }
    }
}