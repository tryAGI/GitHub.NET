
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// An OIDC custom property inclusion for repository properties
    /// </summary>
    public sealed partial class OidcCustomPropertyInclusion
    {
        /// <summary>
        /// The name of the custom property that is included in the OIDC token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomPropertyName { get; set; }

        /// <summary>
        /// Whether the inclusion was defined at the organization or enterprise level<br/>
        /// Example: organization
        /// </summary>
        /// <example>organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inclusion_source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OidcCustomPropertyInclusionInclusionSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OidcCustomPropertyInclusionInclusionSource InclusionSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcCustomPropertyInclusion" /> class.
        /// </summary>
        /// <param name="customPropertyName">
        /// The name of the custom property that is included in the OIDC token
        /// </param>
        /// <param name="inclusionSource">
        /// Whether the inclusion was defined at the organization or enterprise level<br/>
        /// Example: organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OidcCustomPropertyInclusion(
            string customPropertyName,
            global::tryAGI.GitHub.OidcCustomPropertyInclusionInclusionSource inclusionSource)
        {
            this.CustomPropertyName = customPropertyName ?? throw new global::System.ArgumentNullException(nameof(customPropertyName));
            this.InclusionSource = inclusionSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcCustomPropertyInclusion" /> class.
        /// </summary>
        public OidcCustomPropertyInclusion()
        {
        }

    }
}