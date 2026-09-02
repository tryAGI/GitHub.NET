
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Input for creating an OIDC custom property inclusion
    /// </summary>
    public sealed partial class OidcCustomPropertyInclusionInput
    {
        /// <summary>
        /// The name of the custom property to include in the OIDC token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomPropertyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcCustomPropertyInclusionInput" /> class.
        /// </summary>
        /// <param name="customPropertyName">
        /// The name of the custom property to include in the OIDC token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OidcCustomPropertyInclusionInput(
            string customPropertyName)
        {
            this.CustomPropertyName = customPropertyName ?? throw new global::System.ArgumentNullException(nameof(customPropertyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OidcCustomPropertyInclusionInput" /> class.
        /// </summary>
        public OidcCustomPropertyInclusionInput()
        {
        }

    }
}