
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The merge method to use.
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestAutoMergeMergeMethod
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
    public static class WebhookPullRequestStackedPullRequestAutoMergeMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestAutoMergeMergeMethod value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestAutoMergeMergeMethod.Merge => "merge",
                WebhookPullRequestStackedPullRequestAutoMergeMergeMethod.Rebase => "rebase",
                WebhookPullRequestStackedPullRequestAutoMergeMergeMethod.Squash => "squash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestAutoMergeMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => WebhookPullRequestStackedPullRequestAutoMergeMergeMethod.Merge,
                "rebase" => WebhookPullRequestStackedPullRequestAutoMergeMergeMethod.Rebase,
                "squash" => WebhookPullRequestStackedPullRequestAutoMergeMergeMethod.Squash,
                _ => null,
            };
        }
    }
}