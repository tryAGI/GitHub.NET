
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Specify which security and analysis features to enable or disable for the repository.<br/>
    /// To use this parameter, you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."<br/>
    /// For example, to enable GitHub Advanced Security, use this data in the body of the `PATCH` request:<br/>
    /// `{ "security_and_analysis": {"advanced_security": { "status": "enabled" } } }`.<br/>
    /// You can check which security and analysis features are currently enabled by using a `GET /repos/{owner}/{repo}` request.
    /// </summary>
    public sealed partial class ReposUpdateRequestSecurityAndAnalysis
    {
        /// <summary>
        /// Use the `status` property to enable or disable GitHub Advanced Security for this repository.<br/>
        /// For more information, see "[About GitHub Advanced<br/>
        /// Security](/github/getting-started-with-github/learning-about-github/about-github-advanced-security)."<br/>
        /// For standalone Code Scanning or Secret Protection products, this parameter cannot be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security")]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity? AdvancedSecurity { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable GitHub Code Security for this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_security")]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisCodeSecurity? CodeSecurity { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning for this repository. For more information, see "[About secret scanning](/code-security/secret-security/about-secret-scanning)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning push protection for this repository. For more information, see "[Protecting pushes with secret scanning](/code-security/secret-scanning/protecting-pushes-with-secret-scanning)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection")]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection? SecretScanningPushProtection { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning AI detection for this repository. For more information, see "[Responsible detection of generic secrets with AI](https://docs.github.com/code-security/secret-scanning/using-advanced-secret-scanning-and-push-protection-features/generic-secret-detection/responsible-ai-generic-secrets)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_ai_detection")]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningAiDetection? SecretScanningAiDetection { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning non-provider patterns for this repository. For more information, see "[Supported secret scanning patterns](/code-security/secret-scanning/introduction/supported-secret-scanning-patterns#supported-secrets)."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_non_provider_patterns")]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningNonProviderPatterns? SecretScanningNonProviderPatterns { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning delegated alert dismissal for this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_alert_dismissal")]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedAlertDismissal? SecretScanningDelegatedAlertDismissal { get; set; }

        /// <summary>
        /// Use the `status` property to enable or disable secret scanning delegated bypass for this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass")]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypass? SecretScanningDelegatedBypass { get; set; }

        /// <summary>
        /// Feature options for secret scanning delegated bypass.<br/>
        /// This object is only honored when `security_and_analysis.secret_scanning_delegated_bypass.status` is set to `enabled`.<br/>
        /// You can send this object in the same request as `secret_scanning_delegated_bypass`, or update just the options in a separate request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_delegated_bypass_options")]
        public global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptions? SecretScanningDelegatedBypassOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysis" /> class.
        /// </summary>
        /// <param name="advancedSecurity">
        /// Use the `status` property to enable or disable GitHub Advanced Security for this repository.<br/>
        /// For more information, see "[About GitHub Advanced<br/>
        /// Security](/github/getting-started-with-github/learning-about-github/about-github-advanced-security)."<br/>
        /// For standalone Code Scanning or Secret Protection products, this parameter cannot be used.
        /// </param>
        /// <param name="codeSecurity">
        /// Use the `status` property to enable or disable GitHub Code Security for this repository.
        /// </param>
        /// <param name="secretScanning">
        /// Use the `status` property to enable or disable secret scanning for this repository. For more information, see "[About secret scanning](/code-security/secret-security/about-secret-scanning)."
        /// </param>
        /// <param name="secretScanningPushProtection">
        /// Use the `status` property to enable or disable secret scanning push protection for this repository. For more information, see "[Protecting pushes with secret scanning](/code-security/secret-scanning/protecting-pushes-with-secret-scanning)."
        /// </param>
        /// <param name="secretScanningAiDetection">
        /// Use the `status` property to enable or disable secret scanning AI detection for this repository. For more information, see "[Responsible detection of generic secrets with AI](https://docs.github.com/code-security/secret-scanning/using-advanced-secret-scanning-and-push-protection-features/generic-secret-detection/responsible-ai-generic-secrets)."
        /// </param>
        /// <param name="secretScanningNonProviderPatterns">
        /// Use the `status` property to enable or disable secret scanning non-provider patterns for this repository. For more information, see "[Supported secret scanning patterns](/code-security/secret-scanning/introduction/supported-secret-scanning-patterns#supported-secrets)."
        /// </param>
        /// <param name="secretScanningDelegatedAlertDismissal">
        /// Use the `status` property to enable or disable secret scanning delegated alert dismissal for this repository.
        /// </param>
        /// <param name="secretScanningDelegatedBypass">
        /// Use the `status` property to enable or disable secret scanning delegated bypass for this repository.
        /// </param>
        /// <param name="secretScanningDelegatedBypassOptions">
        /// Feature options for secret scanning delegated bypass.<br/>
        /// This object is only honored when `security_and_analysis.secret_scanning_delegated_bypass.status` is set to `enabled`.<br/>
        /// You can send this object in the same request as `secret_scanning_delegated_bypass`, or update just the options in a separate request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposUpdateRequestSecurityAndAnalysis(
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisAdvancedSecurity? advancedSecurity,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisCodeSecurity? codeSecurity,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanning? secretScanning,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection? secretScanningPushProtection,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningAiDetection? secretScanningAiDetection,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningNonProviderPatterns? secretScanningNonProviderPatterns,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedAlertDismissal? secretScanningDelegatedAlertDismissal,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypass? secretScanningDelegatedBypass,
            global::tryAGI.GitHub.ReposUpdateRequestSecurityAndAnalysisSecretScanningDelegatedBypassOptions? secretScanningDelegatedBypassOptions)
        {
            this.AdvancedSecurity = advancedSecurity;
            this.CodeSecurity = codeSecurity;
            this.SecretScanning = secretScanning;
            this.SecretScanningPushProtection = secretScanningPushProtection;
            this.SecretScanningAiDetection = secretScanningAiDetection;
            this.SecretScanningNonProviderPatterns = secretScanningNonProviderPatterns;
            this.SecretScanningDelegatedAlertDismissal = secretScanningDelegatedAlertDismissal;
            this.SecretScanningDelegatedBypass = secretScanningDelegatedBypass;
            this.SecretScanningDelegatedBypassOptions = secretScanningDelegatedBypassOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateRequestSecurityAndAnalysis" /> class.
        /// </summary>
        public ReposUpdateRequestSecurityAndAnalysis()
        {
        }

    }
}