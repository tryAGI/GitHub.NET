
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotAddOrganizationsToEnterpriseCodingAgentPolicyRequest
    {
        /// <summary>
        /// List of organization logins within the enterprise to enable Copilot cloud agent for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations")]
        public global::System.Collections.Generic.IList<string>? Organizations { get; set; }

        /// <summary>
        /// List of custom property filters to match organizations. Organizations matching any of the specified property name/value pairs will be included. This is a one-time operation, setting the property on an organization in the future will not automatically update its coding agent policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_properties")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotAddOrganizationsToEnterpriseCodingAgentPolicyRequestCustomPropertie>? CustomProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddOrganizationsToEnterpriseCodingAgentPolicyRequest" /> class.
        /// </summary>
        /// <param name="organizations">
        /// List of organization logins within the enterprise to enable Copilot cloud agent for.
        /// </param>
        /// <param name="customProperties">
        /// List of custom property filters to match organizations. Organizations matching any of the specified property name/value pairs will be included. This is a one-time operation, setting the property on an organization in the future will not automatically update its coding agent policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotAddOrganizationsToEnterpriseCodingAgentPolicyRequest(
            global::System.Collections.Generic.IList<string>? organizations,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CopilotAddOrganizationsToEnterpriseCodingAgentPolicyRequestCustomPropertie>? customProperties)
        {
            this.Organizations = organizations;
            this.CustomProperties = customProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddOrganizationsToEnterpriseCodingAgentPolicyRequest" /> class.
        /// </summary>
        public CopilotAddOrganizationsToEnterpriseCodingAgentPolicyRequest()
        {
        }

    }
}