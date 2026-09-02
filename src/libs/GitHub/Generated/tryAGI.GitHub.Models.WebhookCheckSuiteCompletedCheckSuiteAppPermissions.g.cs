
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookCheckSuiteCompletedCheckSuiteAppPermissions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActionsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActions? Actions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministrationJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecksJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferencesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContents? Contents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeploymentsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussionsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmailsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironmentsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssuesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeysJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembersJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembers? Members { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadataJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooksJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackagesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlanJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjectsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecretsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackagesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPagesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPages? Pages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequestsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooksJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjectsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEventsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFileJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatusesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflowsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteCompletedCheckSuiteAppPermissions" /> class.
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
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissions(
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsActions? actions,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsAdministration? administration,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsChecks? checks,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContentReferences? contentReferences,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsContents? contents,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments? deployments,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDiscussions? discussions,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEmails? emails,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsEnvironments? environments,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsIssues? issues,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsKeys? keys,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMembers? members,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsMetadata? metadata,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationAdministration? organizationAdministration,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationHooks? organizationHooks,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPackages? organizationPackages,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationPlan? organizationPlan,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationProjects? organizationProjects,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSecrets? organizationSecrets,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPackages? packages,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPages? pages,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsPullRequests? pullRequests,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryHooks? repositoryHooks,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsRepositoryProjects? repositoryProjects,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets? secrets,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityEvents? securityEvents,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSingleFile? singleFile,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsStatuses? statuses,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::tryAGI.GitHub.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsWorkflows? workflows)
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
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteCompletedCheckSuiteAppPermissions" /> class.
        /// </summary>
        public WebhookCheckSuiteCompletedCheckSuiteAppPermissions()
        {
        }

    }
}