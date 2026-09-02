
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookIssueDependenciesBlockedByRemoved
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssueDependenciesBlockedByRemovedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssueDependenciesBlockedByRemovedAction Action { get; set; }

        /// <summary>
        /// The ID of the blocked issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_issue_id")]
        public double? BlockedIssueId { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_issue")]
        public global::tryAGI.GitHub.Issue? BlockedIssue { get; set; }

        /// <summary>
        /// The ID of the blocking issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking_issue_id")]
        public double? BlockingIssueId { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking_issue")]
        public global::tryAGI.GitHub.Issue? BlockingIssue { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking_issue_repo")]
        public global::tryAGI.GitHub.Repository? BlockingIssueRepo { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrganizationSimpleWebhooks Organization { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookIssueDependenciesBlockedByRemoved" /> class.
        /// </summary>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="action"></param>
        /// <param name="blockedIssueId">
        /// The ID of the blocked issue.
        /// </param>
        /// <param name="blockedIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="blockingIssueId">
        /// The ID of the blocking issue.
        /// </param>
        /// <param name="blockingIssue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="blockingIssueRepo">
        /// A repository on GitHub.
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssueDependenciesBlockedByRemoved(
            global::tryAGI.GitHub.OrganizationSimpleWebhooks organization,
            global::tryAGI.GitHub.RepositoryWebhooks repository,
            global::tryAGI.GitHub.SimpleUser sender,
            global::tryAGI.GitHub.WebhookIssueDependenciesBlockedByRemovedAction action,
            double? blockedIssueId,
            global::tryAGI.GitHub.Issue? blockedIssue,
            double? blockingIssueId,
            global::tryAGI.GitHub.Issue? blockingIssue,
            global::tryAGI.GitHub.Repository? blockingIssueRepo,
            global::tryAGI.GitHub.SimpleInstallation? installation)
        {
            this.Action = action;
            this.BlockedIssueId = blockedIssueId;
            this.BlockedIssue = blockedIssue;
            this.BlockingIssueId = blockingIssueId;
            this.BlockingIssue = blockingIssue;
            this.BlockingIssueRepo = blockingIssueRepo;
            this.Installation = installation;
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueDependenciesBlockedByRemoved" /> class.
        /// </summary>
        public WebhookIssueDependenciesBlockedByRemoved()
        {
        }

    }
}