
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookDeploymentStatusCreated
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookDeploymentStatusCreatedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookDeploymentStatusCreatedAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_run")]
        public global::tryAGI.GitHub.WebhookDeploymentStatusCreatedCheckRun? CheckRun { get; set; }

        /// <summary>
        /// The [deployment](https://docs.github.com/rest/deployments/deployments#list-deployments).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookDeploymentStatusCreatedDeployment Deployment { get; set; }

        /// <summary>
        /// The [deployment status](https://docs.github.com/rest/deployments/statuses#list-deployment-statuses).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookDeploymentStatusCreatedDeploymentStatus DeploymentStatus { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::tryAGI.GitHub.WebhooksWorkflow? Workflow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run")]
        public global::tryAGI.GitHub.WebhookDeploymentStatusCreatedWorkflowRun? WorkflowRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentStatusCreated" /> class.
        /// </summary>
        /// <param name="deployment">
        /// The [deployment](https://docs.github.com/rest/deployments/deployments#list-deployments).
        /// </param>
        /// <param name="deploymentStatus">
        /// The [deployment status](https://docs.github.com/rest/deployments/statuses#list-deployment-statuses).
        /// </param>
        /// <param name="repository">
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </param>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="action"></param>
        /// <param name="checkRun"></param>
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
        /// <param name="organization">
        /// A GitHub organization. Webhook payloads contain the `organization` property when the webhook is configured for an<br/>
        /// organization, or when the event occurs from activity in a repository owned by an organization.
        /// </param>
        /// <param name="workflow"></param>
        /// <param name="workflowRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeploymentStatusCreated(
            global::tryAGI.GitHub.WebhookDeploymentStatusCreatedDeployment deployment,
            global::tryAGI.GitHub.WebhookDeploymentStatusCreatedDeploymentStatus deploymentStatus,
            global::tryAGI.GitHub.RepositoryWebhooks repository,
            global::tryAGI.GitHub.SimpleUser sender,
            global::tryAGI.GitHub.WebhookDeploymentStatusCreatedAction action,
            global::tryAGI.GitHub.WebhookDeploymentStatusCreatedCheckRun? checkRun,
            global::tryAGI.GitHub.EnterpriseWebhooks? enterprise,
            global::tryAGI.GitHub.SimpleInstallation? installation,
            global::tryAGI.GitHub.OrganizationSimpleWebhooks? organization,
            global::tryAGI.GitHub.WebhooksWorkflow? workflow,
            global::tryAGI.GitHub.WebhookDeploymentStatusCreatedWorkflowRun? workflowRun)
        {
            this.Action = action;
            this.CheckRun = checkRun;
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
            this.DeploymentStatus = deploymentStatus ?? throw new global::System.ArgumentNullException(nameof(deploymentStatus));
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Organization = organization;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Workflow = workflow;
            this.WorkflowRun = workflowRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentStatusCreated" /> class.
        /// </summary>
        public WebhookDeploymentStatusCreated()
        {
        }

    }
}