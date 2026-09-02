
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyRequestCustomPropertie
    {
        /// <summary>
        /// The name of the custom property to filter by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyName { get; set; }

        /// <summary>
        /// The values of the custom property to match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyRequestCustomPropertie" /> class.
        /// </summary>
        /// <param name="propertyName">
        /// The name of the custom property to filter by.
        /// </param>
        /// <param name="values">
        /// The values of the custom property to match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyRequestCustomPropertie(
            string propertyName,
            global::System.Collections.Generic.IList<string> values)
        {
            this.PropertyName = propertyName ?? throw new global::System.ArgumentNullException(nameof(propertyName));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyRequestCustomPropertie" /> class.
        /// </summary>
        public CopilotRemoveOrganizationsFromEnterpriseCodingAgentPolicyRequestCustomPropertie()
        {
        }

    }
}