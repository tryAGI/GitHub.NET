
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookPullRequestDemilestoned
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookPullRequestDemilestonedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookPullRequestDemilestonedAction Action { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public global::tryAGI.GitHub.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// A collection of related issues and pull requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milestone")]
        public global::tryAGI.GitHub.Milestone? Milestone { get; set; }

        /// <summary>
        /// The pull request number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::tryAGI.GitHub.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhooksPullRequest5 PullRequest { get; set; }

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
        public global::tryAGI.GitHub.SimpleUser? Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestDemilestoned" /> class.
        /// </summary>
        /// <param name="number">
        /// The pull request number.
        /// </param>
        /// <param name="pullRequest"></param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="action"></param>
        /// <param name="enterprise">
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </param>
        /// <param name="milestone">
        /// A collection of related issues and pull requests.
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPullRequestDemilestoned(
            int number,
            global::tryAGI.GitHub.WebhooksPullRequest5 pullRequest,
            global::tryAGI.GitHub.RepositoryWebhooks repository,
            global::tryAGI.GitHub.WebhookPullRequestDemilestonedAction action,
            global::tryAGI.GitHub.EnterpriseWebhooks? enterprise,
            global::tryAGI.GitHub.Milestone? milestone,
            global::tryAGI.GitHub.OrganizationSimpleWebhooks? organization,
            global::tryAGI.GitHub.SimpleUser? sender)
        {
            this.Action = action;
            this.Enterprise = enterprise;
            this.Milestone = milestone;
            this.Number = number;
            this.Organization = organization;
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestDemilestoned" /> class.
        /// </summary>
        public WebhookPullRequestDemilestoned()
        {
        }

    }
}