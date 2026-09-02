
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgsSetImmutableReleasesSettingsRequest
    {
        /// <summary>
        /// The policy that controls how immutable releases are enforced in the organization.<br/>
        /// Example: all
        /// </summary>
        /// <example>all</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforced_repositories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OrgsSetImmutableReleasesSettingsRequestEnforcedRepositoriesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories EnforcedRepositories { get; set; }

        /// <summary>
        /// An array of repository ids for which immutable releases enforcement should be applied. You can only provide a list of repository ids when the `enforced_repositories` is set to `selected`. You can add and remove individual repositories using the [Enable a selected repository for immutable releases in an organization](https://docs.github.com/rest/orgs/orgs#enable-a-selected-repository-for-immutable-releases-in-an-organization) and [Disable a selected repository for immutable releases in an organization](https://docs.github.com/rest/orgs/orgs#disable-a-selected-repository-for-immutable-releases-in-an-organization) endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repository_ids")]
        public global::System.Collections.Generic.IList<int>? SelectedRepositoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetImmutableReleasesSettingsRequest" /> class.
        /// </summary>
        /// <param name="enforcedRepositories">
        /// The policy that controls how immutable releases are enforced in the organization.<br/>
        /// Example: all
        /// </param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository ids for which immutable releases enforcement should be applied. You can only provide a list of repository ids when the `enforced_repositories` is set to `selected`. You can add and remove individual repositories using the [Enable a selected repository for immutable releases in an organization](https://docs.github.com/rest/orgs/orgs#enable-a-selected-repository-for-immutable-releases-in-an-organization) and [Disable a selected repository for immutable releases in an organization](https://docs.github.com/rest/orgs/orgs#disable-a-selected-repository-for-immutable-releases-in-an-organization) endpoints.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsSetImmutableReleasesSettingsRequest(
            global::tryAGI.GitHub.OrgsSetImmutableReleasesSettingsRequestEnforcedRepositories enforcedRepositories,
            global::System.Collections.Generic.IList<int>? selectedRepositoryIds)
        {
            this.EnforcedRepositories = enforcedRepositories;
            this.SelectedRepositoryIds = selectedRepositoryIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsSetImmutableReleasesSettingsRequest" /> class.
        /// </summary>
        public OrgsSetImmutableReleasesSettingsRequest()
        {
        }

    }
}