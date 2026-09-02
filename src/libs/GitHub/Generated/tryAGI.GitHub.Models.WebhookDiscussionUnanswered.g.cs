
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookDiscussionUnanswered
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookDiscussionUnansweredActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookDiscussionUnansweredAction Action { get; set; }

        /// <summary>
        /// A Discussion in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.Discussion Discussion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhooksAnswer OldAnswer { get; set; }

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
        public global::tryAGI.GitHub.SimpleUser? Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionUnanswered" /> class.
        /// </summary>
        /// <param name="discussion">
        /// A Discussion in a repository.
        /// </param>
        /// <param name="oldAnswer"></param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="action"></param>
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
        public WebhookDiscussionUnanswered(
            global::tryAGI.GitHub.Discussion discussion,
            global::tryAGI.GitHub.WebhooksAnswer oldAnswer,
            global::tryAGI.GitHub.RepositoryWebhooks repository,
            global::tryAGI.GitHub.WebhookDiscussionUnansweredAction action,
            global::tryAGI.GitHub.OrganizationSimpleWebhooks? organization,
            global::tryAGI.GitHub.SimpleUser? sender)
        {
            this.Action = action;
            this.Discussion = discussion ?? throw new global::System.ArgumentNullException(nameof(discussion));
            this.OldAnswer = oldAnswer ?? throw new global::System.ArgumentNullException(nameof(oldAnswer));
            this.Organization = organization;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDiscussionUnanswered" /> class.
        /// </summary>
        public WebhookDiscussionUnanswered()
        {
        }

    }
}