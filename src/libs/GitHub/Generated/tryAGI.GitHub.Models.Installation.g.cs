
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Installation
    /// </summary>
    public sealed partial class Installation
    {
        /// <summary>
        /// The ID of the installation.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AnyOfJsonConverter<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.Enterprise>))]
        public global::tryAGI.GitHub.AnyOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.Enterprise>? Account { get; set; }

        /// <summary>
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.InstallationRepositorySelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.InstallationRepositorySelection RepositorySelection { get; set; }

        /// <summary>
        /// Example: https://api.github.com/app/installations/1/access_tokens
        /// </summary>
        /// <example>https://api.github.com/app/installations/1/access_tokens</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_tokens_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessTokensUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/installation/repositories
        /// </summary>
        /// <example>https://api.github.com/installation/repositories</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepositoriesUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/organizations/github/settings/installations/1
        /// </summary>
        /// <example>https://github.com/organizations/github/settings/installations/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AppId { get; set; }

        /// <summary>
        /// Example: Iv1.ab1112223334445c
        /// </summary>
        /// <example>Iv1.ab1112223334445c</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// The ID of the user or organization this token is being scoped to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetId { get; set; }

        /// <summary>
        /// Example: Organization
        /// </summary>
        /// <example>Organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetType { get; set; }

        /// <summary>
        /// The permissions granted to the fine-grained access token.<br/>
        /// Example: {"contents":"read","issues":"read","deployments":"write","single_file":"read"}
        /// </summary>
        /// <example>{"contents":"read","issues":"read","deployments":"write","single_file":"read"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.AppPermissions Permissions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Events { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Example: config.yaml
        /// </summary>
        /// <example>config.yaml</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_file_name")]
        public string? SingleFileName { get; set; }

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
        /// Example: github-actions
        /// </summary>
        /// <example>github-actions</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppSlug { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended_by")]
        public global::tryAGI.GitHub.NullableSimpleUser? SuspendedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended_at")]
        public global::System.DateTime? SuspendedAt { get; set; }

        /// <summary>
        /// Example: "test_13f1e99741e3e004@d7e1eb0bc0a1ba12.com"
        /// </summary>
        /// <example>"test_13f1e99741e3e004@d7e1eb0bc0a1ba12.com"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact_email")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Installation" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the installation.<br/>
        /// Example: 1
        /// </param>
        /// <param name="repositorySelection">
        /// Describe whether all repositories have been selected or there's a selection involved
        /// </param>
        /// <param name="accessTokensUrl">
        /// Example: https://api.github.com/app/installations/1/access_tokens
        /// </param>
        /// <param name="repositoriesUrl">
        /// Example: https://api.github.com/installation/repositories
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/organizations/github/settings/installations/1
        /// </param>
        /// <param name="appId">
        /// Example: 1
        /// </param>
        /// <param name="targetId">
        /// The ID of the user or organization this token is being scoped to.
        /// </param>
        /// <param name="targetType">
        /// Example: Organization
        /// </param>
        /// <param name="permissions">
        /// The permissions granted to the fine-grained access token.<br/>
        /// Example: {"contents":"read","issues":"read","deployments":"write","single_file":"read"}
        /// </param>
        /// <param name="events"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="appSlug">
        /// Example: github-actions
        /// </param>
        /// <param name="account"></param>
        /// <param name="clientId">
        /// Example: Iv1.ab1112223334445c
        /// </param>
        /// <param name="singleFileName">
        /// Example: config.yaml
        /// </param>
        /// <param name="hasMultipleSingleFiles">
        /// Example: true
        /// </param>
        /// <param name="singleFilePaths">
        /// Example: [config.yml, .github/issue_TEMPLATE.md]
        /// </param>
        /// <param name="suspendedBy">
        /// A GitHub user.
        /// </param>
        /// <param name="suspendedAt"></param>
        /// <param name="contactEmail">
        /// Example: "test_13f1e99741e3e004@d7e1eb0bc0a1ba12.com"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Installation(
            int id,
            global::tryAGI.GitHub.InstallationRepositorySelection repositorySelection,
            string accessTokensUrl,
            string repositoriesUrl,
            string htmlUrl,
            int appId,
            int targetId,
            string targetType,
            global::tryAGI.GitHub.AppPermissions permissions,
            global::System.Collections.Generic.IList<string> events,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string appSlug,
            global::tryAGI.GitHub.AnyOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.Enterprise>? account,
            string? clientId,
            string? singleFileName,
            bool? hasMultipleSingleFiles,
            global::System.Collections.Generic.IList<string>? singleFilePaths,
            global::tryAGI.GitHub.NullableSimpleUser? suspendedBy,
            global::System.DateTime? suspendedAt,
            string? contactEmail)
        {
            this.Id = id;
            this.Account = account;
            this.RepositorySelection = repositorySelection;
            this.AccessTokensUrl = accessTokensUrl ?? throw new global::System.ArgumentNullException(nameof(accessTokensUrl));
            this.RepositoriesUrl = repositoriesUrl ?? throw new global::System.ArgumentNullException(nameof(repositoriesUrl));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.AppId = appId;
            this.ClientId = clientId;
            this.TargetId = targetId;
            this.TargetType = targetType ?? throw new global::System.ArgumentNullException(nameof(targetType));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.SingleFileName = singleFileName;
            this.HasMultipleSingleFiles = hasMultipleSingleFiles;
            this.SingleFilePaths = singleFilePaths;
            this.AppSlug = appSlug ?? throw new global::System.ArgumentNullException(nameof(appSlug));
            this.SuspendedBy = suspendedBy;
            this.SuspendedAt = suspendedAt;
            this.ContactEmail = contactEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Installation" /> class.
        /// </summary>
        public Installation()
        {
        }

    }
}