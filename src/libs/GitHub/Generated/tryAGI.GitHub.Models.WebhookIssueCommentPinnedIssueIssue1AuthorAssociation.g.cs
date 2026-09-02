
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentPinnedIssueIssue1AuthorAssociation
    {
        /// <summary>
        ///
        /// </summary>
        Collaborator,
        /// <summary>
        ///
        /// </summary>
        Contributor,
        /// <summary>
        ///
        /// </summary>
        FirstTimer,
        /// <summary>
        ///
        /// </summary>
        FirstTimeContributor,
        /// <summary>
        ///
        /// </summary>
        Mannequin,
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentPinnedIssueIssue1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentPinnedIssueIssue1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Member => "MEMBER",
                WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.None => "NONE",
                WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentPinnedIssueIssue1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Member,
                "NONE" => WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.None,
                "OWNER" => WebhookIssueCommentPinnedIssueIssue1AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}