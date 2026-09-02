
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookInstallationRepositoriesRemoved
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookInstallationRepositoriesRemovedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookInstallationRepositoriesRemovedAction Action { get; set; }

        /// <summary>
        /// An enterprise on GitHub. Webhook payloads contain the `enterprise` property when the webhook is configured<br/>
        /// on an enterprise account or an organization that's part of an enterprise account. For more information,<br/>
        /// see "[About enterprise accounts](https://docs.github.com/admin/overview/about-enterprise-accounts)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public global::tryAGI.GitHub.EnterpriseWebhooks? Enterprise { get; set; }

        /// <summary>
        /// Installation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.Installation Installation { get; set; }

        /// <summary>
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::tryAGI.GitHub.OrganizationSimpleWebhooks? Organization { get; set; }

        /// <summary>
        /// An array of repository objects, which were added to the installation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhooksRepositoriesAddedItem> RepositoriesAdded { get; set; }

        /// <summary>
        /// An array of repository objects, which were removed from the installation. When `repository_selection` changes from `all` to `selected`, this array is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_removed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookInstallationRepositoriesRemovedRepositoriesRemovedItem> RepositoriesRemoved { get; set; }

        /// <summary>
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public global::tryAGI.GitHub.RepositoryWebhooks? Repository { get; set; }

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhooksRepositorySelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhooksRepositorySelection RepositorySelection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester")]
        public global::tryAGI.GitHub.WebhooksUser? Requester { get; set; }

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
        /// Initializes a new instance of the <see cref="WebhookInstallationRepositoriesRemoved" /> class.
        /// </summary>
        /// <param name="installation">
        /// Installation
        /// </param>
        /// <param name="repositoriesAdded">
        /// An array of repository objects, which were added to the installation.
        /// </param>
        /// <param name="repositoriesRemoved">
        /// An array of repository objects, which were removed from the installation. When `repository_selection` changes from `all` to `selected`, this array is empty.
        /// </param>
        /// <param name="repositorySelection">
        /// Describe whether all repositories have been selected or there's a selection involved
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
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="requester"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookInstallationRepositoriesRemoved(
            global::tryAGI.GitHub.Installation installation,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhooksRepositoriesAddedItem> repositoriesAdded,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookInstallationRepositoriesRemovedRepositoriesRemovedItem> repositoriesRemoved,
            global::tryAGI.GitHub.WebhooksRepositorySelection repositorySelection,
            global::tryAGI.GitHub.SimpleUser sender,
            global::tryAGI.GitHub.WebhookInstallationRepositoriesRemovedAction action,
            global::tryAGI.GitHub.EnterpriseWebhooks? enterprise,
            global::tryAGI.GitHub.OrganizationSimpleWebhooks? organization,
            global::tryAGI.GitHub.RepositoryWebhooks? repository,
            global::tryAGI.GitHub.WebhooksUser? requester)
        {
            this.Action = action;
            this.Enterprise = enterprise;
            this.Installation = installation ?? throw new global::System.ArgumentNullException(nameof(installation));
            this.Organization = organization;
            this.RepositoriesAdded = repositoriesAdded ?? throw new global::System.ArgumentNullException(nameof(repositoriesAdded));
            this.RepositoriesRemoved = repositoriesRemoved ?? throw new global::System.ArgumentNullException(nameof(repositoriesRemoved));
            this.Repository = repository;
            this.RepositorySelection = repositorySelection;
            this.Requester = requester;
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInstallationRepositoriesRemoved" /> class.
        /// </summary>
        public WebhookInstallationRepositoriesRemoved()
        {
        }

    }
}