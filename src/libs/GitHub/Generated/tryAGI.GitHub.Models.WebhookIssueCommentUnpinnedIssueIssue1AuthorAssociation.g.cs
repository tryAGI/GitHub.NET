
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation
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
    public static class WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Member => "MEMBER",
                WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.None => "NONE",
                WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Mannequin,
                "MEMBER" => WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Member,
                "NONE" => WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.None,
                "OWNER" => WebhookIssueCommentUnpinnedIssueIssue1AuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}