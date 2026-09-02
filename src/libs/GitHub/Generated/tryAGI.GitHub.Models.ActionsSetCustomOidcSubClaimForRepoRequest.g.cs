
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Actions OIDC subject customization for a repository
    /// </summary>
    public sealed partial class ActionsSetCustomOidcSubClaimForRepoRequest
    {
        /// <summary>
        /// Whether to use the default template or not. If `true`, the `include_claim_keys` field is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UseDefault { get; set; }

        /// <summary>
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_claim_keys")]
        public global::System.Collections.Generic.IList<string>? IncludeClaimKeys { get; set; }

        /// <summary>
        /// Whether to opt in to the immutable OIDC subject claim format for this repository. When `true`, OIDC tokens will use a stable, repository-ID-based `sub` claim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_immutable_subject")]
        public bool? UseImmutableSubject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetCustomOidcSubClaimForRepoRequest" /> class.
        /// </summary>
        /// <param name="useDefault">
        /// Whether to use the default template or not. If `true`, the `include_claim_keys` field is ignored.
        /// </param>
        /// <param name="includeClaimKeys">
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </param>
        /// <param name="useImmutableSubject">
        /// Whether to opt in to the immutable OIDC subject claim format for this repository. When `true`, OIDC tokens will use a stable, repository-ID-based `sub` claim.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsSetCustomOidcSubClaimForRepoRequest(
            bool useDefault,
            global::System.Collections.Generic.IList<string>? includeClaimKeys,
            bool? useImmutableSubject)
        {
            this.UseDefault = useDefault;
            this.IncludeClaimKeys = includeClaimKeys;
            this.UseImmutableSubject = useImmutableSubject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetCustomOidcSubClaimForRepoRequest" /> class.
        /// </summary>
        public ActionsSetCustomOidcSubClaimForRepoRequest()
        {
        }

    }
}