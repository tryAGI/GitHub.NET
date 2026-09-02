
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookProjectsV2ItemEdited
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookProjectsV2ItemEditedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookProjectsV2ItemEditedAction Action { get; set; }

        /// <summary>
        /// The changes made to the item may involve modifications in the item's fields and draft issue body.<br/>
        /// It includes altered values for text, number, date, single select, and iteration fields, along with the GraphQL node ID of the changed field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<global::tryAGI.GitHub.WebhookProjectsV2ItemEditedChangesVariant1, global::tryAGI.GitHub.WebhookProjectsV2ItemEditedChangesVariant2>))]
        public global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.WebhookProjectsV2ItemEditedChangesVariant1, global::tryAGI.GitHub.WebhookProjectsV2ItemEditedChangesVariant2>? Changes { get; set; }

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
        /// An item belonging to a project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_v2_item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ProjectsV2Item ProjectsV2Item { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEdited" /> class.
        /// </summary>
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="projectsV2Item">
        /// An item belonging to a project
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="action"></param>
        /// <param name="changes">
        /// The changes made to the item may involve modifications in the item's fields and draft issue body.<br/>
        /// It includes altered values for text, number, date, single select, and iteration fields, along with the GraphQL node ID of the changed field.
        /// </param>
        /// <param name="installation">
        /// The GitHub App installation. Webhook payloads contain the `installation` property when the event is configured<br/>
        /// for and sent to a GitHub App. For more information,<br/>
        /// see "[Using webhooks with GitHub Apps](https://docs.github.com/apps/creating-github-apps/registering-a-github-app/using-webhooks-with-github-apps)."
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookProjectsV2ItemEdited(
            global::tryAGI.GitHub.OrganizationSimpleWebhooks organization,
            global::tryAGI.GitHub.ProjectsV2Item projectsV2Item,
            global::tryAGI.GitHub.SimpleUser sender,
            global::tryAGI.GitHub.WebhookProjectsV2ItemEditedAction action,
            global::tryAGI.GitHub.OneOf<global::tryAGI.GitHub.WebhookProjectsV2ItemEditedChangesVariant1, global::tryAGI.GitHub.WebhookProjectsV2ItemEditedChangesVariant2>? changes,
            global::tryAGI.GitHub.SimpleInstallation? installation)
        {
            this.Action = action;
            this.Changes = changes;
            this.Installation = installation;
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.ProjectsV2Item = projectsV2Item ?? throw new global::System.ArgumentNullException(nameof(projectsV2Item));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEdited" /> class.
        /// </summary>
        public WebhookProjectsV2ItemEdited()
        {
        }

    }
}