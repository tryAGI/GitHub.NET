
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A code security configuration
    /// </summary>
    public sealed partial class CodeSecurityConfiguration
    {
        /// <summary>
        /// The ID of the code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the code security configuration. Must be unique within the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the code security configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationTargetTypeJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationTargetType? TargetType { get; set; }

        /// <summary>
        /// A description of the code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The enablement status of GitHub Advanced Security
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationAdvancedSecurityJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationDependencyGraphJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationDependencyGraphAutosubmitActionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action_options")]
        public global::tryAGI.GitHub.CodeSecurityConfigurationDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationDependabotAlertsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationDependabotSecurityUpdatesJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// The enablement status of Dependabot delegated alert dismissal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationDependabotDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationDependabotDelegatedAlertDismissal? DependabotDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// Feature options for code scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_options")]
        public global::tryAGI.GitHub.CodeSecurityConfigurationCodeScanningOptions? CodeScanningOptions { get; set; }

        /// <summary>
        /// The enablement status of code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationCodeScanningDefaultSetupJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

        /// <summary>
        /// Feature options for code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup_options")]
        public global::tryAGI.GitHub.CodeSecurityConfigurationCodeScanningDefaultSetupOptions? CodeScanningDefaultSetupOptions { get; set; }

        /// <summary>
        /// The enablement status of code scanning delegated alert dismissal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationCodeScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal? CodeScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of secret scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationSecretScanningJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationSecretScanningPushProtectionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning delegated bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationSecretScanningDelegatedBypassJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningDelegatedBypass? SecretScanningDelegatedBypass { get; set; }

        /// <summary>
        /// Feature options for secret scanning delegated bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass_options")]
        public global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningDelegatedBypassOptions? SecretScanningDelegatedBypassOptions { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationSecretScanningValidityChecksJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non-provider patterns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationSecretScanningNonProviderPatternsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of Copilot secret scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_generic_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationSecretScanningGenericSecretsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningGenericSecrets? SecretScanningGenericSecrets { get; set; }

        /// <summary>
        /// The enablement status of secret scanning delegated alert dismissal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationSecretScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal? SecretScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of secret scanning extended metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_extended_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationSecretScanningExtendedMetadataJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningExtendedMetadata? SecretScanningExtendedMetadata { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationPrivateVulnerabilityReportingJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityConfigurationEnforcementJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityConfigurationEnforcement? Enforcement { get; set; }

        /// <summary>
        /// The URL of the configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The URL of the configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfiguration" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the code security configuration
        /// </param>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the organization.
        /// </param>
        /// <param name="targetType">
        /// The type of the code security configuration.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates
        /// </param>
        /// <param name="dependabotDelegatedAlertDismissal">
        /// The enablement status of Dependabot delegated alert dismissal
        /// </param>
        /// <param name="codeScanningOptions">
        /// Feature options for code scanning
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup
        /// </param>
        /// <param name="codeScanningDefaultSetupOptions">
        /// Feature options for code scanning default setup
        /// </param>
        /// <param name="codeScanningDelegatedAlertDismissal">
        /// The enablement status of code scanning delegated alert dismissal
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection
        /// </param>
        /// <param name="secretScanningDelegatedBypass">
        /// The enablement status of secret scanning delegated bypass
        /// </param>
        /// <param name="secretScanningDelegatedBypassOptions">
        /// Feature options for secret scanning delegated bypass
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non-provider patterns
        /// </param>
        /// <param name="secretScanningGenericSecrets">
        /// The enablement status of Copilot secret scanning
        /// </param>
        /// <param name="secretScanningDelegatedAlertDismissal">
        /// The enablement status of secret scanning delegated alert dismissal
        /// </param>
        /// <param name="secretScanningExtendedMetadata">
        /// The enablement status of secret scanning extended metadata
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration
        /// </param>
        /// <param name="url">
        /// The URL of the configuration
        /// </param>
        /// <param name="htmlUrl">
        /// The URL of the configuration
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityConfiguration(
            int? id,
            string? name,
            global::tryAGI.GitHub.CodeSecurityConfigurationTargetType? targetType,
            string? description,
            global::tryAGI.GitHub.CodeSecurityConfigurationAdvancedSecurity? advancedSecurity,
            global::tryAGI.GitHub.CodeSecurityConfigurationDependencyGraph? dependencyGraph,
            global::tryAGI.GitHub.CodeSecurityConfigurationDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::tryAGI.GitHub.CodeSecurityConfigurationDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::tryAGI.GitHub.CodeSecurityConfigurationDependabotAlerts? dependabotAlerts,
            global::tryAGI.GitHub.CodeSecurityConfigurationDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::tryAGI.GitHub.CodeSecurityConfigurationDependabotDelegatedAlertDismissal? dependabotDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityConfigurationCodeScanningOptions? codeScanningOptions,
            global::tryAGI.GitHub.CodeSecurityConfigurationCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::tryAGI.GitHub.CodeSecurityConfigurationCodeScanningDefaultSetupOptions? codeScanningDefaultSetupOptions,
            global::tryAGI.GitHub.CodeSecurityConfigurationCodeScanningDelegatedAlertDismissal? codeScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanning? secretScanning,
            global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningPushProtection? secretScanningPushProtection,
            global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningDelegatedBypass? secretScanningDelegatedBypass,
            global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningDelegatedBypassOptions? secretScanningDelegatedBypassOptions,
            global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningValidityChecks? secretScanningValidityChecks,
            global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningGenericSecrets? secretScanningGenericSecrets,
            global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityConfigurationSecretScanningExtendedMetadata? secretScanningExtendedMetadata,
            global::tryAGI.GitHub.CodeSecurityConfigurationPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::tryAGI.GitHub.CodeSecurityConfigurationEnforcement? enforcement,
            string? url,
            string? htmlUrl,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.TargetType = targetType;
            this.Description = description;
            this.AdvancedSecurity = advancedSecurity;
            this.DependencyGraph = dependencyGraph;
            this.DependencyGraphAutosubmitAction = dependencyGraphAutosubmitAction;
            this.DependencyGraphAutosubmitActionOptions = dependencyGraphAutosubmitActionOptions;
            this.DependabotAlerts = dependabotAlerts;
            this.DependabotSecurityUpdates = dependabotSecurityUpdates;
            this.DependabotDelegatedAlertDismissal = dependabotDelegatedAlertDismissal;
            this.CodeScanningOptions = codeScanningOptions;
            this.CodeScanningDefaultSetup = codeScanningDefaultSetup;
            this.CodeScanningDefaultSetupOptions = codeScanningDefaultSetupOptions;
            this.CodeScanningDelegatedAlertDismissal = codeScanningDelegatedAlertDismissal;
            this.SecretScanning = secretScanning;
            this.SecretScanningPushProtection = secretScanningPushProtection;
            this.SecretScanningDelegatedBypass = secretScanningDelegatedBypass;
            this.SecretScanningDelegatedBypassOptions = secretScanningDelegatedBypassOptions;
            this.SecretScanningValidityChecks = secretScanningValidityChecks;
            this.SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns;
            this.SecretScanningGenericSecrets = secretScanningGenericSecrets;
            this.SecretScanningDelegatedAlertDismissal = secretScanningDelegatedAlertDismissal;
            this.SecretScanningExtendedMetadata = secretScanningExtendedMetadata;
            this.PrivateVulnerabilityReporting = privateVulnerabilityReporting;
            this.Enforcement = enforcement;
            this.Url = url;
            this.HtmlUrl = htmlUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfiguration" /> class.
        /// </summary>
        public CodeSecurityConfiguration()
        {
        }

    }
}