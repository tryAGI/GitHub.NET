
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public enum PullRequestMergeAsyncResultDetailsVariant1MergeMethod
    {
        /// <summary>
        ///
        /// </summary>
        Default,
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
    public static class PullRequestMergeAsyncResultDetailsVariant1MergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullRequestMergeAsyncResultDetailsVariant1MergeMethod value)
        {
            return value switch
            {
                PullRequestMergeAsyncResultDetailsVariant1MergeMethod.Default => "default",
                PullRequestMergeAsyncResultDetailsVariant1MergeMethod.Merge => "merge",
                PullRequestMergeAsyncResultDetailsVariant1MergeMethod.Rebase => "rebase",
                PullRequestMergeAsyncResultDetailsVariant1MergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullRequestMergeAsyncResultDetailsVariant1MergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "default" => PullRequestMergeAsyncResultDetailsVariant1MergeMethod.Default,
                "merge" => PullRequestMergeAsyncResultDetailsVariant1MergeMethod.Merge,
                "rebase" => PullRequestMergeAsyncResultDetailsVariant1MergeMethod.Rebase,
                "squash" => PullRequestMergeAsyncResultDetailsVariant1MergeMethod.Squash,
                _ => null,
            };
        }
    }
}