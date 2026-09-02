
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Actions OIDC Subject customization
    /// </summary>
    public sealed partial class OidcUpdateOidcCustomSubTemplateForOrgRequest
    {
        /// <summary>
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_claim_keys")]
        public global::System.Collections.Generic.IList<string>? IncludeClaimKeys { get; set; }

        /// <summary>
        /// Whether to opt in to the immutable OIDC subject claim format for the organization. When `true`, new OIDC tokens will use a stable, repository-ID-based `sub` claim instead of the name-based format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_immutable_subject")]
        public bool? UseImmutableSubject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcUpdateOidcCustomSubTemplateForOrgRequest" /> class.
        /// </summary>
        /// <param name="includeClaimKeys">
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </param>
        /// <param name="useImmutableSubject">
        /// Whether to opt in to the immutable OIDC subject claim format for the organization. When `true`, new OIDC tokens will use a stable, repository-ID-based `sub` claim instead of the name-based format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OidcUpdateOidcCustomSubTemplateForOrgRequest(
            global::System.Collections.Generic.IList<string>? includeClaimKeys,
            bool? useImmutableSubject)
        {
            this.IncludeClaimKeys = includeClaimKeys;
            this.UseImmutableSubject = useImmutableSubject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcUpdateOidcCustomSubTemplateForOrgRequest" /> class.
        /// </summary>
        public OidcUpdateOidcCustomSubTemplateForOrgRequest()
        {
        }

    }
}