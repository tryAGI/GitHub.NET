
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeSecurityCreateConfigurationForEnterpriseRequest
    {
        /// <summary>
        /// The name of the code security configuration. Must be unique within the enterprise.
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurityJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// The enablement status of GitHub Code Security features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_security")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurityJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity? CodeSecurity { get; set; }

        /// <summary>
        /// The enablement status of Dependency Graph<br/>
        /// Default Value: enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph? DependencyGraph { get; set; }

        /// <summary>
        /// The enablement status of Automatic dependency submission<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction? DependencyGraphAutosubmitAction { get; set; }

        /// <summary>
        /// Feature options for Automatic dependency submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_autosubmit_action_options")]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionOptions? DependencyGraphAutosubmitActionOptions { get; set; }

        /// <summary>
        /// The enablement status of Dependabot alerts<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlertsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts? DependabotAlerts { get; set; }

        /// <summary>
        /// The enablement status of Dependabot security updates<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdatesJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetupJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup? CodeScanningDefaultSetup { get; set; }

        /// <summary>
        /// Feature options for code scanning default setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_default_setup_options")]
        public global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? CodeScanningDefaultSetupOptions { get; set; }

        /// <summary>
        /// The enablement status of code scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal? CodeScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of GitHub Secret Protection features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtectionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection? SecretProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// The enablement status of secret scanning push protection<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtectionJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// The enablement status of secret scanning validity checks<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_validity_checks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecksJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks? SecretScanningValidityChecks { get; set; }

        /// <summary>
        /// The enablement status of secret scanning non provider patterns<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatternsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// The enablement status of Copilot secret scanning<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_generic_secrets")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecretsJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets? SecretScanningGenericSecrets { get; set; }

        /// <summary>
        /// The enablement status of secret scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_alert_dismissal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissalJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal? SecretScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// The enablement status of secret scanning extended metadata<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_extended_metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadataJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata? SecretScanningExtendedMetadata { get; set; }

        /// <summary>
        /// The enablement status of private vulnerability reporting<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_vulnerability_reporting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestPrivateVulnerabilityReportingJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestPrivateVulnerabilityReporting? PrivateVulnerabilityReporting { get; set; }

        /// <summary>
        /// The enforcement status for a security configuration<br/>
        /// Default Value: enforced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeSecurityCreateConfigurationForEnterpriseRequestEnforcementJsonConverter))]
        public global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement? Enforcement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityCreateConfigurationForEnterpriseRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the code security configuration. Must be unique within the enterprise.
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
        /// Default Value: disabled
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
        /// The enablement status of secret scanning delegated alert dismissal<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="secretScanningExtendedMetadata">
        /// The enablement status of secret scanning extended metadata<br/>
        /// Default Value: disabled
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
        public CodeSecurityCreateConfigurationForEnterpriseRequest(
            string name,
            string? description,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity? advancedSecurity,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity? codeSecurity,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraph? dependencyGraph,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitAction? dependencyGraphAutosubmitAction,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionOptions? dependencyGraphAutosubmitActionOptions,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts? dependabotAlerts,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::tryAGI.GitHub.CodeScanningOptions? codeScanningOptions,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup? codeScanningDefaultSetup,
            global::tryAGI.GitHub.CodeScanningDefaultSetupOptions? codeScanningDefaultSetupOptions,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal? codeScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretProtection? secretProtection,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning? secretScanning,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection? secretScanningPushProtection,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks? secretScanningValidityChecks,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets? secretScanningGenericSecrets,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtendedMetadata? secretScanningExtendedMetadata,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestPrivateVulnerabilityReporting? privateVulnerabilityReporting,
            global::tryAGI.GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement? enforcement)
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
            this.CodeScanningOptions = codeScanningOptions;
            this.CodeScanningDefaultSetup = codeScanningDefaultSetup;
            this.CodeScanningDefaultSetupOptions = codeScanningDefaultSetupOptions;
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
        /// Initializes a new instance of the <see cref="CodeSecurityCreateConfigurationForEnterpriseRequest" /> class.
        /// </summary>
        public CodeSecurityCreateConfigurationForEnterpriseRequest()
        {
        }

    }
}