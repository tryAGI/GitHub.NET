
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessage
    {
        /// <summary>
        ///
        /// </summary>
        Blank,
        /// <summary>
        ///
        /// </summary>
        PrBody,
        /// <summary>
        ///
        /// </summary>
        PrTitle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessage.Blank => "BLANK",
                WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessage.Blank,
                "PR_BODY" => WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhookPullRequestStackedPullRequestHeadRepoMergeCommitMessage.PrTitle,
                _ => null,
            };
        }
    }
}