
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookSubIssuesParentIssueAdded
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookSubIssuesParentIssueAddedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookSubIssuesParentIssueAddedAction Action { get; set; }

        /// <summary>
        /// The ID of the parent issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_issue_id")]
        public double? ParentIssueId { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_issue")]
        public global::tryAGI.GitHub.Issue? ParentIssue { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_issue_repo")]
        public global::tryAGI.GitHub.Repository? ParentIssueRepo { get; set; }

        /// <summary>
        /// The ID of the sub-issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issue_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SubIssueId { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.Issue SubIssue { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::tryAGI.GitHub.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::tryAGI.GitHub.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.RepositoryWebhooks Repository { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubIssuesParentIssueAdded" /> class.
        /// </summary>
        /// <param name="subIssueId">
        /// The ID of the sub-issue.
        /// </param>
        /// <param name="subIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="action"></param>
        /// <param name="parentIssueId">
        /// The ID of the parent issue.
        /// </param>
        /// <param name="parentIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="parentIssueRepo">
        /// A repository on GitHub.
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSubIssuesParentIssueAdded(
            double subIssueId,
            global::tryAGI.GitHub.Issue subIssue,
            global::tryAGI.GitHub.RepositoryWebhooks repository,
            global::tryAGI.GitHub.SimpleUser sender,
            global::tryAGI.GitHub.WebhookSubIssuesParentIssueAddedAction action,
            double? parentIssueId,
            global::tryAGI.GitHub.Issue? parentIssue,
            global::tryAGI.GitHub.Repository? parentIssueRepo,
            global::tryAGI.GitHub.SimpleInstallation? installation,
            global::tryAGI.GitHub.OrganizationSimpleWebhooks? organization)
        {
            this.Action = action;
            this.ParentIssueId = parentIssueId;
            this.ParentIssue = parentIssue;
            this.ParentIssueRepo = parentIssueRepo;
            this.SubIssueId = subIssueId;
            this.SubIssue = subIssue ?? throw new global::System.ArgumentNullException(nameof(subIssue));
            this.Installation = installation;
            this.Organization = organization;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubIssuesParentIssueAdded" /> class.
        /// </summary>
        public WebhookSubIssuesParentIssueAdded()
        {
        }

    }
}