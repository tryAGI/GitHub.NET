
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
    /// </summary>
    public sealed partial class RepositoryRuleRequiredDeployments
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRuleRequiredDeploymentsTypeJsonConverter))]
        public global::tryAGI.GitHub.RepositoryRuleRequiredDeploymentsType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::tryAGI.GitHub.RepositoryRuleRequiredDeploymentsParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredDeployments" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleRequiredDeployments(
            global::tryAGI.GitHub.RepositoryRuleRequiredDeploymentsType type,
            global::tryAGI.GitHub.RepositoryRuleRequiredDeploymentsParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleRequiredDeployments" /> class.
        /// </summary>
        public RepositoryRuleRequiredDeployments()
        {
        }

    }
}