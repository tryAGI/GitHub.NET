
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The enabled review tools for Copilot cloud agent.
    /// </summary>
    public sealed partial class CopilotGetCopilotCloudAgentConfigurationResponseEnabledTools
    {
        /// <summary>
        /// Whether the CodeQL tool is enabled for the Copilot cloud agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeql")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Codeql { get; set; }

        /// <summary>
        /// Whether the Copilot code review tool is enabled for the Copilot cloud agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_code_review")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CopilotCodeReview { get; set; }

        /// <summary>
        /// Whether the secret scanning tool is enabled for the Copilot cloud agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SecretScanning { get; set; }

        /// <summary>
        /// Whether the dependency vulnerability checks tool is enabled for the Copilot cloud agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_vulnerability_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DependencyVulnerabilityChecks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotGetCopilotCloudAgentConfigurationResponseEnabledTools" /> class.
        /// </summary>
        /// <param name="codeql">
        /// Whether the CodeQL tool is enabled for the Copilot cloud agent.
        /// </param>
        /// <param name="copilotCodeReview">
        /// Whether the Copilot code review tool is enabled for the Copilot cloud agent.
        /// </param>
        /// <param name="secretScanning">
        /// Whether the secret scanning tool is enabled for the Copilot cloud agent.
        /// </param>
        /// <param name="dependencyVulnerabilityChecks">
        /// Whether the dependency vulnerability checks tool is enabled for the Copilot cloud agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotGetCopilotCloudAgentConfigurationResponseEnabledTools(
            bool codeql,
            bool copilotCodeReview,
            bool secretScanning,
            bool dependencyVulnerabilityChecks)
        {
            this.Codeql = codeql;
            this.CopilotCodeReview = copilotCodeReview;
            this.SecretScanning = secretScanning;
            this.DependencyVulnerabilityChecks = dependencyVulnerabilityChecks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotGetCopilotCloudAgentConfigurationResponseEnabledTools" /> class.
        /// </summary>
        public CopilotGetCopilotCloudAgentConfigurationResponseEnabledTools()
        {
        }

    }
}