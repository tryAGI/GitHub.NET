
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TeamsAddOrUpdateRepoPermissionsLegacyRequest
    {
        /// <summary>
        /// The permission to grant the team on this repository. If no permission is specified, the team's `permission` attribute will be used to determine what permission to grant the team on this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.TeamsAddOrUpdateRepoPermissionsLegacyRequestPermissionJsonConverter))]
        public global::tryAGI.GitHub.TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission? Permission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateRepoPermissionsLegacyRequest" /> class.
        /// </summary>
        /// <param name="permission">
        /// The permission to grant the team on this repository. If no permission is specified, the team's `permission` attribute will be used to determine what permission to grant the team on this repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsAddOrUpdateRepoPermissionsLegacyRequest(
            global::tryAGI.GitHub.TeamsAddOrUpdateRepoPermissionsLegacyRequestPermission? permission)
        {
            this.Permission = permission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsAddOrUpdateRepoPermissionsLegacyRequest" /> class.
        /// </summary>
        public TeamsAddOrUpdateRepoPermissionsLegacyRequest()
        {
        }

    }
}