
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeSecurityUpdateConfigurationRequest
    {
        /// <summary>
        /// The name of the code security configuration. Must be unique within the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestAdvancedSecurityJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of GitHub Code Security features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestCodeSecurityJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestCodeSecurity? CodeSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestDependencyGraphJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action_options")]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestDependabotAlertsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdatesJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// The enablement status of Dependabot delegated alert dismissal. Requires Dependabot alerts to be enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal? DependabotDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetupJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

        /// <summary>
        /// Feature options for code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup_options")]
        public global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? CodeScanningDefaultSetupOptions { get; set; }

        /// <summary>
        /// Security Configuration feature options for code scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_options")]
        public global::tryAGI.GitHub.CodeScanningOptions? CodeScanningOptions { get; set; }

        /// <summary>
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal? CodeScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of GitHub Secret Protection features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretProtectionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretProtection? SecretProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretScanningJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtectionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning delegated bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass? SecretScanningDelegatedBypass { get; set; }

        /// <summary>
        /// Feature options for secret scanning delegated bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass_options")]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptions? SecretScanningDelegatedBypassOptions { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecksJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non-provider patterns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatternsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of Copilot secret scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_generic_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecretsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets? SecretScanningGenericSecrets { get; set; }

        /// <summary>
        /// The enablement status of secret scanning delegated alert dismissal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal? SecretScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of secret scanning extended metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_extended_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadataJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata? SecretScanningExtendedMetadata { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestPrivateVulnerabilityReportingJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateConfigurationRequestEnforcementJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestEnforcement? Enforcement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the organization.
        /// </param>
        /// <param name="description">
        /// A description of the code security configuration
        /// </param>
        /// <param name="advancedSecurity">
        /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.
        /// </param>
        /// <param name="codeSecurity">
        /// The enablement status of GitHub Code Security features.
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
        /// The enablement status of Dependabot delegated alert dismissal. Requires Dependabot alerts to be enabled.
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup
        /// </param>
        /// <param name="codeScanningDefaultSetupOptions">
        /// Feature options for code scanning default setup
        /// </param>
        /// <param name="codeScanningOptions">
        /// Security Configuration feature options for code scanning
        /// </param>
        /// <param name="codeScanningDelegatedAlertDismissal">
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretProtection">
        /// The enablement status of GitHub Secret Protection features.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityUpdateConfigurationRequest(
            string? name,
            string? description,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestAdvancedSecurity? advancedSecurity,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestCodeSecurity? codeSecurity,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependencyGraph? dependencyGraph,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependabotAlerts? dependabotAlerts,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestDependabotDelegatedAlertDismissal? dependabotDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? codeScanningDefaultSetupOptions,
            global::tryAGI.GitHub.CodeScanningOptions? codeScanningOptions,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestCodeScanningDelegatedAlertDismissal? codeScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretProtection? secretProtection,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanning? secretScanning,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypass? secretScanningDelegatedBypass,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptions? secretScanningDelegatedBypassOptions,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningGenericSecrets? secretScanningGenericSecrets,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestSecretScanningExtendedMetadata? secretScanningExtendedMetadata,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::tryAGI.GitHub.CodeSecurityUpdateConfigurationRequestEnforcement? enforcement)
        {
            this.Name = name;
            this.Description = description;
            this.AdvancedSecurity = advancedSecurity;
            this.CodeSecurity = codeSecurity;
            this.DependencyGraph = dependencyGraph;
            this.DependencyGraphAutosubmitAction = dependencyGraphAutosubmitAction;
            this.DependencyGraphAutosubmitActionOptions = dependencyGraphAutosubmitActionOptions;
            this.DependabotAlerts = dependabotAlerts;
            this.DependabotSecurityUpdates = dependabotSecurityUpdates;
            this.DependabotDelegatedAlertDismissal = dependabotDelegatedAlertDismissal;
            this.CodeScanningDefaultSetup = codeScanningDefaultSetup;
            this.CodeScanningDefaultSetupOptions = codeScanningDefaultSetupOptions;
            this.CodeScanningOptions = codeScanningOptions;
            this.CodeScanningDelegatedAlertDismissal = codeScanningDelegatedAlertDismissal;
            this.SecretProtection = secretProtection;
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateConfigurationRequest" /> class.
        /// </summary>
        public CodeSecurityUpdateConfigurationRequest()
        {
        }

    }
}