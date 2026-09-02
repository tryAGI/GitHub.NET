
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The default value for a merge commit message.<br/>
    /// - `PR_TITLE` - default to the pull request's title.<br/>
    /// - `PR_BODY` - default to the pull request's body.<br/>
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessage
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
    public static class WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessage value)
        {
            return value switch
            {
                WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessage.Blank => "BLANK",
                WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessage.PrBody => "PR_BODY",
                WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessage.PrTitle => "PR_TITLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessage? ToEnum(string value)
        {
            return value switch
            {
                "BLANK" => WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessage.Blank,
                "PR_BODY" => WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessage.PrBody,
                "PR_TITLE" => WebhookPullRequestStackedPullRequestBaseRepoMergeCommitMessage.PrTitle,
                _ => null,
            };
        }
    }
}