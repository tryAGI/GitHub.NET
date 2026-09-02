
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecurityAndAnalysis
    {
        /// <summary>
        /// Enable or disable GitHub Advanced Security for the repository.<br/>
        /// For standalone Code Scanning or Secret Protection products, this parameter cannot be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        public global::tryAGI.GitHub.SecurityAndAnalysisAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_security")]
        public global::tryAGI.GitHub.SecurityAndAnalysisCodeSecurity? CodeSecurity { get; set; }

        /// <summary>
        /// Enable or disable Dependabot security updates for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates")]
        public global::tryAGI.GitHub.SecurityAndAnalysisDependabotSecurityUpdates? DependabotSecurityUpdates { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        public global::tryAGI.GitHub.SecurityAndAnalysisSecretScanning? SecretScanning { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        public global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        public global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_ai_detection")]
        public global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningAiDetection? SecretScanningAiDetection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_alert_dismissal")]
        public global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedAlertDismissal? SecretScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass")]
        public global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedBypass? SecretScanningDelegatedBypass { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass_options")]
        public global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedBypassOptions? SecretScanningDelegatedBypassOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysis" /> class.
        /// </summary>
        /// <param name="advancedSecurity">
        /// Enable or disable GitHub Advanced Security for the repository.<br/>
        /// For standalone Code Scanning or Secret Protection products, this parameter cannot be used.
        /// </param>
        /// <param name="codeSecurity"></param>
        /// <param name="dependabotSecurityUpdates">
        /// Enable or disable Dependabot security updates for the repository.
        /// </param>
        /// <param name="secretScanning"></param>
        /// <param name="secretScanningPushProtection"></param>
        /// <param name="secretScanningNonProviderPatterns"></param>
        /// <param name="secretScanningAiDetection"></param>
        /// <param name="secretScanningDelegatedAlertDismissal"></param>
        /// <param name="secretScanningDelegatedBypass"></param>
        /// <param name="secretScanningDelegatedBypassOptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityAndAnalysis(
            global::tryAGI.GitHub.SecurityAndAnalysisAdvancedSecurity? advancedSecurity,
            global::tryAGI.GitHub.SecurityAndAnalysisCodeSecurity? codeSecurity,
            global::tryAGI.GitHub.SecurityAndAnalysisDependabotSecurityUpdates? dependabotSecurityUpdates,
            global::tryAGI.GitHub.SecurityAndAnalysisSecretScanning? secretScanning,
            global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningPushProtection? secretScanningPushProtection,
            global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningAiDetection? secretScanningAiDetection,
            global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedBypass? secretScanningDelegatedBypass,
            global::tryAGI.GitHub.SecurityAndAnalysisSecretScanningDelegatedBypassOptions? secretScanningDelegatedBypassOptions)
        {
            this.AdvancedSecurity = advancedSecurity;
            this.CodeSecurity = codeSecurity;
            this.DependabotSecurityUpdates = dependabotSecurityUpdates;
            this.SecretScanning = secretScanning;
            this.SecretScanningPushProtection = secretScanningPushProtection;
            this.SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns;
            this.SecretScanningAiDetection = secretScanningAiDetection;
            this.SecretScanningDelegatedAlertDismissal = secretScanningDelegatedAlertDismissal;
            this.SecretScanningDelegatedBypass = secretScanningDelegatedBypass;
            this.SecretScanningDelegatedBypassOptions = secretScanningDelegatedBypassOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityAndAnalysis" /> class.
        /// </summary>
        public SecurityAndAnalysis()
        {
        }

    }
}