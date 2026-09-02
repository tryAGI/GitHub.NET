
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Check immutable releases settings for an organization.
    /// </summary>
    public sealed partial class ImmutableReleasesOrganizationSettings
    {
        /// <summary>
        /// The policy that controls how immutable releases are enforced in the organization.<br/>
        /// Example: all
        /// </summary>
        /// <example>all</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced_repositories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.ImmutableReleasesOrganizationSettingsEnforcedRepositoriesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ImmutableReleasesOrganizationSettingsEnforcedRepositories EnforcedRepositories { get; set; }

        /// <summary>
        /// The API URL to use to get or set the selected repositories for immutable releases enforcement, when `enforced_repositories` is set to `selected`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImmutableReleasesOrganizationSettings" /> class.
        /// </summary>
        /// <param name="enforcedRepositories">
        /// The policy that controls how immutable releases are enforced in the organization.<br/>
        /// Example: all
        /// </param>
        /// <param name="selectedRepositoriesUrl">
        /// The API URL to use to get or set the selected repositories for immutable releases enforcement, when `enforced_repositories` is set to `selected`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImmutableReleasesOrganizationSettings(
            global::tryAGI.GitHub.ImmutableReleasesOrganizationSettingsEnforcedRepositories enforcedRepositories,
            string? selectedRepositoriesUrl)
        {
            this.EnforcedRepositories = enforcedRepositories;
            this.SelectedRepositoriesUrl = selectedRepositoriesUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImmutableReleasesOrganizationSettings" /> class.
        /// </summary>
        public ImmutableReleasesOrganizationSettings()
        {
        }

    }
}