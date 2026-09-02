
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookDeploymentReviewRejected
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookDeploymentReviewRejectedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookDeploymentReviewRejectedAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approver")]
        public global::tryAGI.GitHub.WebhooksApprover? Approver { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

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
        /// The repository on GitHub where the event occurred. Webhook payloads contain the `repository` property<br/>
        /// when the event occurs from activity in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.RepositoryWebhooks Repository { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhooksReviewer>? Reviewers { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Sender { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Since { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_job_run")]
        public global::tryAGI.GitHub.WebhooksWorkflowJobRun? WorkflowJobRun { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_job_runs")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookDeploymentReviewRejectedWorkflowJobRun>? WorkflowJobRuns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run")]
        public global::tryAGI.GitHub.WebhookDeploymentReviewRejectedWorkflowRun? WorkflowRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRejected" /> class.
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
        /// <param name="since"></param>
        /// <param name="action"></param>
        /// <param name="approver"></param>
        /// <param name="comment"></param>
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
        /// <param name="reviewers"></param>
        /// <param name="workflowJobRun"></param>
        /// <param name="workflowJobRuns"></param>
        /// <param name="workflowRun"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookDeploymentReviewRejected(
            global::tryAGI.GitHub.OrganizationSimpleWebhooks organization,
            global::tryAGI.GitHub.RepositoryWebhooks repository,
            global::tryAGI.GitHub.SimpleUser sender,
            string since,
            global::tryAGI.GitHub.WebhookDeploymentReviewRejectedAction action,
            global::tryAGI.GitHub.WebhooksApprover? approver,
            string? comment,
            global::tryAGI.GitHub.EnterpriseWebhooks? enterprise,
            global::tryAGI.GitHub.SimpleInstallation? installation,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhooksReviewer>? reviewers,
            global::tryAGI.GitHub.WebhooksWorkflowJobRun? workflowJobRun,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookDeploymentReviewRejectedWorkflowJobRun>? workflowJobRuns,
            global::tryAGI.GitHub.WebhookDeploymentReviewRejectedWorkflowRun? workflowRun)
        {
            this.Action = action;
            this.Approver = approver;
            this.Comment = comment;
            this.Enterprise = enterprise;
            this.Installation = installation;
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.Reviewers = reviewers;
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
            this.Since = since ?? throw new global::System.ArgumentNullException(nameof(since));
            this.WorkflowJobRun = workflowJobRun;
            this.WorkflowJobRuns = workflowJobRuns;
            this.WorkflowRun = workflowRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeploymentReviewRejected" /> class.
        /// </summary>
        public WebhookDeploymentReviewRejected()
        {
        }

    }
}