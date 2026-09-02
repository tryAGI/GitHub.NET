
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppsListReposAccessibleToInstallationResponseRepositorie
    {
        /// <summary>
        /// The custom properties that were defined for the repository. The keys are the custom property names, and the values are the corresponding custom property values. Present for org repos only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_properties")]
        public object? CustomProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsListReposAccessibleToInstallationResponseRepositorie" /> class.
        /// </summary>
        /// <param name="customProperties">
        /// The custom properties that were defined for the repository. The keys are the custom property names, and the values are the corresponding custom property values. Present for org repos only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppsListReposAccessibleToInstallationResponseRepositorie(
            object? customProperties)
        {
            this.CustomProperties = customProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsListReposAccessibleToInstallationResponseRepositorie" /> class.
        /// </summary>
        public AppsListReposAccessibleToInstallationResponseRepositorie()
        {
        }

    }
}