
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookIssuesFieldRemoved
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesFieldRemovedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesFieldRemovedAction Action { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public global::tryAGI.GitHub.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        public global::tryAGI.GitHub.SimpleInstallation? Installation { get; set; }

        /// <summary>
        /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhooksIssue Issue { get; set; }

        /// <summary>
        /// The issue field whose value was cleared from the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookIssuesFieldRemovedIssueField IssueField { get; set; }

        /// <summary>
        /// The value that was cleared from the issue field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field_value")]
        public global::tryAGI.GitHub.WebhookIssuesFieldRemovedIssueFieldValue? IssueFieldValue { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldRemoved" /> class.
        /// </summary>
        /// <param name="issue">
        /// The [issue](https://docs.github.com/rest/issues/issues#get-an-issue) itself.
        /// </param>
        /// <param name="issueField">
        /// The issue field whose value was cleared from the issue.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="action"></param>
        /// <param name="enterprise">
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
        /// <param name="issueFieldValue">
        /// The value that was cleared from the issue field.
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesFieldRemoved(
            global::tryAGI.GitHub.WebhooksIssue issue,
            global::tryAGI.GitHub.WebhookIssuesFieldRemovedIssueField issueField,
            global::tryAGI.GitHub.RepositoryWebhooks repository,
            global::tryAGI.GitHub.SimpleUser sender,
            global::tryAGI.GitHub.WebhookIssuesFieldRemovedAction action,
            global::tryAGI.GitHub.EnterpriseWebhooks? enterprise,
            global::tryAGI.GitHub.SimpleInstallation? installation,
            global::tryAGI.GitHub.WebhookIssuesFieldRemovedIssueFieldValue? issueFieldValue,
            global::tryAGI.GitHub.OrganizationSimpleWebhooks? organization)
        {
            this.Action = action;
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Issue = issue ?? throw new global::System.ArgumentNullException(nameof(issue));
            this.IssueField = issueField ?? throw new global::System.ArgumentNullException(nameof(issueField));
            this.IssueFieldValue = issueFieldValue;
            this.Organization = organization;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesFieldRemoved" /> class.
        /// </summary>
        public WebhookIssuesFieldRemoved()
        {
        }

    }
}