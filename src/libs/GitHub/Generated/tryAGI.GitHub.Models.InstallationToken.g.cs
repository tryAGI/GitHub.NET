
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Authentication token for a GitHub App installed on a user or org.
    /// </summary>
    public sealed partial class InstallationToken
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// The permissions granted to the fine-grained access token.<br/>
        /// Example: {"contents":"read","issues":"read","deployments":"write","single_file":"read"}
        /// </summary>
        /// <example>{"contents":"read","issues":"read","deployments":"write","single_file":"read"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::tryAGI.GitHub.AppPermissions? Permissions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.InstallationTokenRepositorySelectionJsonConverter))]
        public global::tryAGI.GitHub.InstallationTokenRepositorySelection? RepositorySelection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.Repository>? Repositories { get; set; }

        /// <summary>
        /// Example: README.md
        /// </summary>
        /// <example>README.md</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file")]
        public string? SingleFile { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_multiple_single_files")]
        public bool? HasMultipleSingleFiles { get; set; }

        /// <summary>
        /// Example: [config.yml, .github/issue_TEMPLATE.md]
        /// </summary>
        /// <example>[config.yml, .github/issue_TEMPLATE.md]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file_paths")]
        public global::System.Collections.Generic.IList<string>? SingleFilePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationToken" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="expiresAt"></param>
        /// <param name="permissions">
        /// The permissions granted to the fine-grained access token.<br/>
        /// Example: {"contents":"read","issues":"read","deployments":"write","single_file":"read"}
        /// </param>
        /// <param name="repositorySelection"></param>
        /// <param name="repositories"></param>
        /// <param name="singleFile">
        /// Example: README.md
        /// </param>
        /// <param name="hasMultipleSingleFiles">
        /// Example: true
        /// </param>
        /// <param name="singleFilePaths">
        /// Example: [config.yml, .github/issue_TEMPLATE.md]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstallationToken(
            string token,
            string expiresAt,
            global::tryAGI.GitHub.AppPermissions? permissions,
            global::tryAGI.GitHub.InstallationTokenRepositorySelection? repositorySelection,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.Repository>? repositories,
            string? singleFile,
            bool? hasMultipleSingleFiles,
            global::System.Collections.Generic.IList<string>? singleFilePaths)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.Permissions = permissions;
            this.RepositorySelection = repositorySelection;
            this.Repositories = repositories;
            this.SingleFile = singleFile;
            this.HasMultipleSingleFiles = hasMultipleSingleFiles;
            this.SingleFilePaths = singleFilePaths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallationToken" /> class.
        /// </summary>
        public InstallationToken()
        {
        }

    }
}