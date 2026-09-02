
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotGetCopilotCloudAgentConfigurationResponse
    {
        /// <summary>
        /// The user-supplied MCP server configuration for the repository, as a free-form JSON object. This will be set to `null` if no configuration has been set.<br/>
        /// The shape of a valid MCP configuration may evolve over time, so this property is intentionally not strictly typed. Clients should not assume a fixed schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_configuration")]
        public object? McpConfiguration { get; set; }

        /// <summary>
        /// The enabled review tools for Copilot cloud agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotGetCopilotCloudAgentConfigurationResponseEnabledTools EnabledTools { get; set; }

        /// <summary>
        /// Whether Actions workflow approval is required for Copilot cloud agent pull requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_actions_workflow_approval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireActionsWorkflowApproval { get; set; }

        /// <summary>
        /// Whether the firewall is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_firewall_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFirewallEnabled { get; set; }

        /// <summary>
        /// Whether the firewall recommended allowlist is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_firewall_recommended_allowlist_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFirewallRecommendedAllowlistEnabled { get; set; }

        /// <summary>
        /// A list of custom allowlist entries, as hosts or URLs, that the firewall will allow the Copilot cloud agent to access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_allowlist")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CustomAllowlist { get; set; }

        /// <summary>
        /// Whether automations are enabled in this repository. When true, users can create automations that automatically run agents on a schedule or in response to events like new issues or updated pull requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_automations_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAutomationsEnabled { get; set; }

        /// <summary>
        /// Whether write access is required for automation triggers. When true, automations will only run if the user triggering the event has write access to the repository. When false, users can create automations that listen for events triggered by users without write access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_write_access_for_automation_triggers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RequireWriteAccessForAutomationTriggers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotGetCopilotCloudAgentConfigurationResponse" /> class.
        /// </summary>
        /// <param name="enabledTools">
        /// The enabled review tools for Copilot cloud agent.
        /// </param>
        /// <param name="requireActionsWorkflowApproval">
        /// Whether Actions workflow approval is required for Copilot cloud agent pull requests.
        /// </param>
        /// <param name="isFirewallEnabled">
        /// Whether the firewall is enabled.
        /// </param>
        /// <param name="isFirewallRecommendedAllowlistEnabled">
        /// Whether the firewall recommended allowlist is enabled.
        /// </param>
        /// <param name="customAllowlist">
        /// A list of custom allowlist entries, as hosts or URLs, that the firewall will allow the Copilot cloud agent to access.
        /// </param>
        /// <param name="isAutomationsEnabled">
        /// Whether automations are enabled in this repository. When true, users can create automations that automatically run agents on a schedule or in response to events like new issues or updated pull requests.
        /// </param>
        /// <param name="requireWriteAccessForAutomationTriggers">
        /// Whether write access is required for automation triggers. When true, automations will only run if the user triggering the event has write access to the repository. When false, users can create automations that listen for events triggered by users without write access.
        /// </param>
        /// <param name="mcpConfiguration">
        /// The user-supplied MCP server configuration for the repository, as a free-form JSON object. This will be set to `null` if no configuration has been set.<br/>
        /// The shape of a valid MCP configuration may evolve over time, so this property is intentionally not strictly typed. Clients should not assume a fixed schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotGetCopilotCloudAgentConfigurationResponse(
            global::tryAGI.GitHub.CopilotGetCopilotCloudAgentConfigurationResponseEnabledTools enabledTools,
            bool requireActionsWorkflowApproval,
            bool isFirewallEnabled,
            bool isFirewallRecommendedAllowlistEnabled,
            global::System.Collections.Generic.IList<string> customAllowlist,
            bool isAutomationsEnabled,
            bool requireWriteAccessForAutomationTriggers,
            object? mcpConfiguration)
        {
            this.McpConfiguration = mcpConfiguration;
            this.EnabledTools = enabledTools ?? throw new global::System.ArgumentNullException(nameof(enabledTools));
            this.RequireActionsWorkflowApproval = requireActionsWorkflowApproval;
            this.IsFirewallEnabled = isFirewallEnabled;
            this.IsFirewallRecommendedAllowlistEnabled = isFirewallRecommendedAllowlistEnabled;
            this.CustomAllowlist = customAllowlist ?? throw new global::System.ArgumentNullException(nameof(customAllowlist));
            this.IsAutomationsEnabled = isAutomationsEnabled;
            this.RequireWriteAccessForAutomationTriggers = requireWriteAccessForAutomationTriggers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotGetCopilotCloudAgentConfigurationResponse" /> class.
        /// </summary>
        public CopilotGetCopilotCloudAgentConfigurationResponse()
        {
        }

    }
}