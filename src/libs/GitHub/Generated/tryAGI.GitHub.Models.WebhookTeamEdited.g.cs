
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookTeamEdited
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookTeamEditedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookTeamEditedAction Action { get; set; }

        /// <summary>
        /// The changes to the team if the action was `edited`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookTeamEditedChanges Changes { get; set; }

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
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrganizationSimpleWebhooks Organization { get; set; }

        /// <summary>
        /// A git repository
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::tryAGI.GitHub.WebhookTeamEditedRepository? Repository { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Sender { get; set; }

        /// <summary>
        /// Groups of organization members that gives permissions on specified repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhooksTeam1 Team { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEdited" /> class.
        /// </summary>
        /// <param name="changes">
        /// The changes to the team if the action was `edited`.
        /// </param>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="team">
        /// Groups of organization members that gives permissions on specified repositories.
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
        /// <param name="repository">
        /// A git repository
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTeamEdited(
            global::tryAGI.GitHub.WebhookTeamEditedChanges changes,
            global::tryAGI.GitHub.OrganizationSimpleWebhooks organization,
            global::tryAGI.GitHub.SimpleUser sender,
            global::tryAGI.GitHub.WebhooksTeam1 team,
            global::tryAGI.GitHub.WebhookTeamEditedAction action,
            global::tryAGI.GitHub.EnterpriseWebhooks? enterprise,
            global::tryAGI.GitHub.SimpleInstallation? installation,
            global::tryAGI.GitHub.WebhookTeamEditedRepository? repository)
        {
            this.Action = action;
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Repository = repository;
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Team = team ?? throw new global::System.ArgumentNullException(nameof(team));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTeamEdited" /> class.
        /// </summary>
        public WebhookTeamEdited()
        {
        }

    }
}