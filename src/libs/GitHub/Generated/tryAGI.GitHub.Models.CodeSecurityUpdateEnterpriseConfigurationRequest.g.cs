
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeSecurityUpdateEnterpriseConfigurationRequest
    {
        /// <summary>
        /// The name of the code security configuration. Must be unique across the enterprise.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurityJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of GitHub Code Security features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurityJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity? CodeSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitActionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action_options")]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlertsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdatesJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// The enablement status of code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetupJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal? CodeScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of GitHub Secret Protection features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtectionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection? SecretProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtectionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecksJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non-provider patterns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatternsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of Copilot secret scanning<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_generic_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecretsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets? SecretScanningGenericSecrets { get; set; }

        /// <summary>
        /// The enablement status of secret scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningDelegatedAlertDismissal? SecretScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of secret scanning extended metadata<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_extended_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadataJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata? SecretScanningExtendedMetadata { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestPrivateVulnerabilityReportingJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityUpdateEnterpriseConfigurationRequestEnforcementJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement? Enforcement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateEnterpriseConfigurationRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique across the enterprise.
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
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non-provider patterns
        /// </param>
        /// <param name="secretScanningGenericSecrets">
        /// The enablement status of Copilot secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningDelegatedAlertDismissal">
        /// The enablement status of secret scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningExtendedMetadata">
        /// The enablement status of secret scanning extended metadata<br/>
        /// Default Value: disabled
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
        public CodeSecurityUpdateEnterpriseConfigurationRequest(
            string? name,
            string? description,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity? advancedSecurity,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeSecurity? codeSecurity,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraph? dependencyGraph,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts? dependabotAlerts,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? codeScanningDefaultSetupOptions,
            global::tryAGI.GitHub.CodeScanningOptions? codeScanningOptions,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestCodeScanningDelegatedAlertDismissal? codeScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretProtection? secretProtection,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning? secretScanning,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets? secretScanningGenericSecrets,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtendedMetadata? secretScanningExtendedMetadata,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::tryAGI.GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement? enforcement)
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
            this.CodeScanningDefaultSetup = codeScanningDefaultSetup;
            this.CodeScanningDefaultSetupOptions = codeScanningDefaultSetupOptions;
            this.CodeScanningOptions = codeScanningOptions;
            this.CodeScanningDelegatedAlertDismissal = codeScanningDelegatedAlertDismissal;
            this.SecretProtection = secretProtection;
            this.SecretScanning = secretScanning;
            this.SecretScanningPushProtection = secretScanningPushProtection;
            this.SecretScanningValidityChecks = secretScanningValidityChecks;
            this.SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns;
            this.SecretScanningGenericSecrets = secretScanningGenericSecrets;
            this.SecretScanningDelegatedAlertDismissal = secretScanningDelegatedAlertDismissal;
            this.SecretScanningExtendedMetadata = secretScanningExtendedMetadata;
            this.PrivateVulnerabilityReporting = privateVulnerabilityReporting;
            this.Enforcement = enforcement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityUpdateEnterpriseConfigurationRequest" /> class.
        /// </summary>
        public CodeSecurityUpdateEnterpriseConfigurationRequest()
        {
        }

    }
}