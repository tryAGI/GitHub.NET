
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Require a fresh authentication before a pull request can be merged.
    /// </summary>
    public sealed partial class RepositoryRuleParamsProofOfPresence
    {
        /// <summary>
        /// The level of authentication required before a pull request can be merged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_authentication_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel RequiredAuthenticationLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsProofOfPresence" /> class.
        /// </summary>
        /// <param name="requiredAuthenticationLevel">
        /// The level of authentication required before a pull request can be merged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleParamsProofOfPresence(
            global::tryAGI.GitHub.RepositoryRuleParamsProofOfPresenceRequiredAuthenticationLevel requiredAuthenticationLevel)
        {
            this.RequiredAuthenticationLevel = requiredAuthenticationLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleParamsProofOfPresence" /> class.
        /// </summary>
        public RepositoryRuleParamsProofOfPresence()
        {
        }

    }
}