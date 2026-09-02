
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public sealed partial class WebhookCheckSuiteRequestedCheckSuiteAppPermissions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActionsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActions? Actions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministrationJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministration? Administration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsArtifactMetadataJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsArtifactMetadata? ArtifactMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attestations")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestationsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestations? Attestations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecksJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecks? Checks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsCodeQualityJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsCodeQuality? CodeQuality { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferencesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferences? ContentReferences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContents? Contents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsCopilotRequestsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsCopilotRequests? CopilotRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeploymentsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeployments? Deployments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussionsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions? Discussions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drives")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDrivesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDrives? Drives { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmailsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmails? Emails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironmentsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironments? Environments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssuesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssues? Issues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeysJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeys? Keys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembersJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembers? Members { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_queues")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMergeQueuesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMergeQueues? MergeQueues { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadataJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadata? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModelsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModels? Models { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_administration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministrationJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration? OrganizationAdministration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooksJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooks? OrganizationHooks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackagesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackages? OrganizationPackages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_plan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlanJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlan? OrganizationPlan { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjectsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjects? OrganizationProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecretsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecrets? OrganizationSecrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_self_hosted_runners")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? OrganizationSelfHostedRunners { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_user_blocking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlockingJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlocking? OrganizationUserBlocking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackagesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackages? Packages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPagesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPages? Pages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_requests")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequestsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequests? PullRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_hooks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooksJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooks? RepositoryHooks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_projects")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjectsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects? RepositoryProjects { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlertsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts? SecretScanningAlerts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecrets? Secrets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_events")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEventsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEvents? SecurityEvents { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security_scanning_alert")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlertJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlert? SecurityScanningAlert { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFileJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFile? SingleFile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatusesJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses? Statuses { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vulnerability_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlertsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlerts? VulnerabilityAlerts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflowsJsonConverter))]
        public global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflows? Workflows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuiteAppPermissions" /> class.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="administration"></param>
        /// <param name="artifactMetadata"></param>
        /// <param name="attestations"></param>
        /// <param name="checks"></param>
        /// <param name="codeQuality"></param>
        /// <param name="contentReferences"></param>
        /// <param name="contents"></param>
        /// <param name="copilotRequests"></param>
        /// <param name="deployments"></param>
        /// <param name="discussions"></param>
        /// <param name="drives"></param>
        /// <param name="emails"></param>
        /// <param name="environments"></param>
        /// <param name="issues"></param>
        /// <param name="keys"></param>
        /// <param name="members"></param>
        /// <param name="mergeQueues"></param>
        /// <param name="metadata"></param>
        /// <param name="models"></param>
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
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissions(
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsActions? actions,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAdministration? administration,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsArtifactMetadata? artifactMetadata,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsAttestations? attestations,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsChecks? checks,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsCodeQuality? codeQuality,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContentReferences? contentReferences,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsContents? contents,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsCopilotRequests? copilotRequests,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDeployments? deployments,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions? discussions,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDrives? drives,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEmails? emails,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsEnvironments? environments,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsIssues? issues,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsKeys? keys,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMembers? members,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMergeQueues? mergeQueues,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsMetadata? metadata,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsModels? models,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration? organizationAdministration,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationHooks? organizationHooks,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPackages? organizationPackages,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationPlan? organizationPlan,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationProjects? organizationProjects,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSecrets? organizationSecrets,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? organizationSelfHostedRunners,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationUserBlocking? organizationUserBlocking,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPackages? packages,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPages? pages,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsPullRequests? pullRequests,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryHooks? repositoryHooks,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsRepositoryProjects? repositoryProjects,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecretScanningAlerts? secretScanningAlerts,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecrets? secrets,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityEvents? securityEvents,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSecurityScanningAlert? securityScanningAlert,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsSingleFile? singleFile,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsStatuses? statuses,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsVulnerabilityAlerts? vulnerabilityAlerts,
            global::tryAGI.GitHub.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsWorkflows? workflows)
        {
            this.Actions = actions;
            this.Administration = administration;
            this.ArtifactMetadata = artifactMetadata;
            this.Attestations = attestations;
            this.Checks = checks;
            this.CodeQuality = codeQuality;
            this.ContentReferences = contentReferences;
            this.Contents = contents;
            this.CopilotRequests = copilotRequests;
            this.Deployments = deployments;
            this.Discussions = discussions;
            this.Drives = drives;
            this.Emails = emails;
            this.Environments = environments;
            this.Issues = issues;
            this.Keys = keys;
            this.Members = members;
            this.MergeQueues = mergeQueues;
            this.Metadata = metadata;
            this.Models = models;
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
        /// Initializes a new instance of the <see cref="WebhookCheckSuiteRequestedCheckSuiteAppPermissions" /> class.
        /// </summary>
        public WebhookCheckSuiteRequestedCheckSuiteAppPermissions()
        {
        }

    }
}