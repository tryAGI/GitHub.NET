
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActionsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions? Actions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsAdministrationJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsChecksJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentReferencesJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContents? Contents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDeploymentsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDiscussionsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEmailsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEnvironmentsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsIssuesJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsKeysJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMembersJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMembers? Members { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadataJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationHooksJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPackagesJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPlanJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationProjectsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSecretsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPackagesJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPagesJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPages? Pages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequestsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryHooksJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjectsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityEventsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFileJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsStatusesJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsWorkflowsJsonConverter))]
        public global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="administration"></param>
        /// <param name="checks"></param>
        /// <param name="contentReferences"></param>
        /// <param name="contents"></param>
        /// <param name="deployments"></param>
        /// <param name="discussions"></param>
        /// <param name="emails"></param>
        /// <param name="environments"></param>
        /// <param name="issues"></param>
        /// <param name="keys"></param>
        /// <param name="members"></param>
        /// <param name="metadata"></param>
        /// <param name="organizationAdministration"></param>
        /// <param name="organizationHooks"></param>
        /// <param name="organizationPackages"></param>
        /// <param name="organizationPlan"></param>
        /// <param name="organizationProjects"></param>
        /// <param name="organizationSecrets"></param>
        /// <param name="organizationSelfHostedRunners"></param>
        /// <param name="organizationUserBlocking"></param>
        /// <param name="packages"></param>
        /// <param name="pages"></param>
        /// <param name="pullRequests"></param>
        /// <param name="repositoryHooks"></param>
        /// <param name="repositoryProjects"></param>
        /// <param name="secretScanningAlerts"></param>
        /// <param name="secrets"></param>
        /// <param name="securityEvents"></param>
        /// <param name="securityScanningAlert"></param>
        /// <param name="singleFile"></param>
        /// <param name="statuses"></param>
        /// <param name="vulnerabilityAlerts"></param>
        /// <param name="workflows"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions(
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsActions? actions,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsAdministration? administration,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsChecks? checks,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContentReferences? contentReferences,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsContents? contents,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDeployments? deployments,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsDiscussions? discussions,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEmails? emails,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsEnvironments? environments,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsIssues? issues,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsKeys? keys,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMembers? members,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsMetadata? metadata,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationAdministration? organizationAdministration,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationHooks? organizationHooks,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPackages? organizationPackages,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationPlan? organizationPlan,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationProjects? organizationProjects,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSecrets? organizationSecrets,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPackages? packages,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPages? pages,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests? pullRequests,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryHooks? repositoryHooks,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsRepositoryProjects? repositoryProjects,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecrets? secrets,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityEvents? securityEvents,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsSingleFile? singleFile,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsStatuses? statuses,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::tryAGI.GitHub.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsWorkflows? workflows)
        {
            this.Actions = actions;
            this.Administration = administration;
            this.Checks = checks;
            this.ContentReferences = contentReferences;
            this.Contents = contents;
            this.Deployments = deployments;
            this.Discussions = discussions;
            this.Emails = emails;
            this.Environments = environments;
            this.Issues = issues;
            this.Keys = keys;
            this.Members = members;
            this.Metadata = metadata;
            this.OrganizationAdministration = organizationAdministration;
            this.OrganizationHooks = organizationHooks;
            this.OrganizationPackages = organizationPackages;
            this.OrganizationPlan = organizationPlan;
            this.OrganizationProjects = organizationProjects;
            this.OrganizationSecrets = organizationSecrets;
            this.OrganizationSelfHostedRunners = organizationSelfHostedRunners;
            this.OrganizationUserBlocking = organizationUserBlocking;
            this.Packages = packages;
            this.Pages = pages;
            this.PullRequests = pullRequests;
            this.RepositoryHooks = repositoryHooks;
            this.RepositoryProjects = repositoryProjects;
            this.SecretScanningAlerts = secretScanningAlerts;
            this.Secrets = secrets;
            this.SecurityEvents = securityEvents;
            this.SecurityScanningAlert = securityScanningAlert;
            this.SingleFile = singleFile;
            this.Statuses = statuses;
            this.VulnerabilityAlerts = vulnerabilityAlerts;
            this.Workflows = workflows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions" /> class.
        /// </summary>
        public WebhookIssuesLabeledIssuePerformedViaGithubAppPermissions()
        {
        }

    }
}