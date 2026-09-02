
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeSecurityCreateConfigurationRequest
    {
        /// <summary>
        /// The name of the code security configuration. Must be unique within the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestAdvancedSecurityJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of GitHub Code Security features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestCodeSecurityJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestCodeSecurity? CodeSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestDependencyGraphJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action_options")]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestDependabotAlertsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdatesJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        /// The enablement status of Dependabot delegated alert dismissal. Requires Dependabot alerts to be enabled.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal? DependabotDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// Security Configuration feature options for code scanning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_options")]
        public global::tryAGI.GitHub.CodeScanningOptions? CodeScanningOptions { get; set; }

        /// <summary>
        /// The enablement status of code scanning default setup<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetupJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

        /// <summary>
        /// Feature options for code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup_options")]
        public global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? CodeScanningDefaultSetupOptions { get; set; }

        /// <summary>
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: not_set
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal? CodeScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of GitHub Secret Protection features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretProtectionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretProtection? SecretProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningPushProtectionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning delegated bypass<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass? SecretScanningDelegatedBypass { get; set; }

        /// <summary>
        /// Feature options for secret scanning delegated bypass
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass_options")]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptions? SecretScanningDelegatedBypassOptions { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecksJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non provider patterns<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatternsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of Copilot secret scanning<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_generic_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningGenericSecretsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets? SecretScanningGenericSecrets { get; set; }

        /// <summary>
        /// The enablement status of secret scanning delegated alert dismissal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal? SecretScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of secret scanning extended metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_extended_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadataJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata? SecretScanningExtendedMetadata { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReportingJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationRequestEnforcementJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestEnforcement? Enforcement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityCreateConfigurationRequest" /> class.
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
        /// &gt; `code_security` and `secret_protection` are deprecated values for this field. Prefer the individual `code_security` and `secret_protection` fields to set the status of these features.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeSecurity">
        /// The enablement status of GitHub Code Security features.
        /// </param>
        /// <param name="dependencyGraph">
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitAction">
        /// The enablement status of Automatic dependency submission<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependencyGraphAutosubmitActionOptions">
        /// Feature options for Automatic dependency submission
        /// </param>
        /// <param name="dependabotAlerts">
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependabotSecurityUpdates">
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="dependabotDelegatedAlertDismissal">
        /// The enablement status of Dependabot delegated alert dismissal. Requires Dependabot alerts to be enabled.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeScanningOptions">
        /// Security Configuration feature options for code scanning
        /// </param>
        /// <param name="codeScanningDefaultSetup">
        /// The enablement status of code scanning default setup<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="codeScanningDefaultSetupOptions">
        /// Feature options for code scanning default setup
        /// </param>
        /// <param name="codeScanningDelegatedAlertDismissal">
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: not_set
        /// </param>
        /// <param name="secretProtection">
        /// The enablement status of GitHub Secret Protection features.
        /// </param>
        /// <param name="secretScanning">
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningDelegatedBypass">
        /// The enablement status of secret scanning delegated bypass<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningDelegatedBypassOptions">
        /// Feature options for secret scanning delegated bypass
        /// </param>
        /// <param name="secretScanningValidityChecks">
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// The enablement status of secret scanning non provider patterns<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningGenericSecrets">
        /// The enablement status of Copilot secret scanning<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningDelegatedAlertDismissal">
        /// The enablement status of secret scanning delegated alert dismissal
        /// </param>
        /// <param name="secretScanningExtendedMetadata">
        /// The enablement status of secret scanning extended metadata
        /// </param>
        /// <param name="privateVulnerabilityReporting">
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="enforcement">
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityCreateConfigurationRequest(
            string name,
            string? description,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity? advancedSecurity,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestCodeSecurity? codeSecurity,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependencyGraph? dependencyGraph,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependabotAlerts? dependabotAlerts,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestDependabotDelegatedAlertDismissal? dependabotDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeScanningOptions? codeScanningOptions,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? codeScanningDefaultSetupOptions,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestCodeScanningDelegatedAlertDismissal? codeScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretProtection? secretProtection,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanning? secretScanning,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? secretScanningPushProtection,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass? secretScanningDelegatedBypass,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassOptions? secretScanningDelegatedBypassOptions,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? secretScanningValidityChecks,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningGenericSecrets? secretScanningGenericSecrets,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestSecretScanningExtendedMetadata? secretScanningExtendedMetadata,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationRequestEnforcement? enforcement)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.AdvancedSecurity = advancedSecurity;
            this.CodeSecurity = codeSecurity;
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
        /// Initializes a new instance of the <see cref="CodeSecurityCreateConfigurationRequest" /> class.
        /// </summary>
        public CodeSecurityCreateConfigurationRequest()
        {
        }

    }
}