
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotSetEnterpriseCodingAgentPolicyRequest
    {
        /// <summary>
        /// The policy state for Copilot cloud agent in the enterprise. Can be one of `enabled_for_all_orgs`, `disabled_for_all_orgs`, `enabled_for_selected_orgs`, or `configured_by_org_admins`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CopilotSetEnterpriseCodingAgentPolicyRequestPolicyStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState PolicyState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSetEnterpriseCodingAgentPolicyRequest" /> class.
        /// </summary>
        /// <param name="policyState">
        /// The policy state for Copilot cloud agent in the enterprise. Can be one of `enabled_for_all_orgs`, `disabled_for_all_orgs`, `enabled_for_selected_orgs`, or `configured_by_org_admins`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotSetEnterpriseCodingAgentPolicyRequest(
            global::tryAGI.GitHub.CopilotSetEnterpriseCodingAgentPolicyRequestPolicyState policyState)
        {
            this.PolicyState = policyState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotSetEnterpriseCodingAgentPolicyRequest" /> class.
        /// </summary>
        public CopilotSetEnterpriseCodingAgentPolicyRequest()
        {
        }

    }
}