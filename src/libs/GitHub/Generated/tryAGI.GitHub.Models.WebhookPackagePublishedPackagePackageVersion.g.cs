
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookPackagePublishedPackagePackageVersion
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionAuthor? Author { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::tryAGI.GitHub.OneOf<string, object>? Body { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_metadata")]
        public global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionContainerMetadata? ContainerMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker_metadata")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionDockerMetadataItem>? DockerMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        public bool? Draft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_command")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstallationCommand { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        public string? Manifest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("npm_metadata")]
        public global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionNpmMetadata? NpmMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nuget_metadata")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionNugetMetadataItem>? NugetMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionPackageFile> PackageFiles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_url")]
        public string? PackageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prerelease")]
        public bool? Prerelease { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        public global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionRelease? Release { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubygems_metadata")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookRubygemsMetadata>? RubygemsMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        public string? TagName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_commitish")]
        public string? TargetCommitish { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_oid")]
        public string? TargetOid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersion" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="id"></param>
        /// <param name="installationCommand"></param>
        /// <param name="metadata"></param>
        /// <param name="name"></param>
        /// <param name="packageFiles"></param>
        /// <param name="summary"></param>
        /// <param name="version"></param>
        /// <param name="author"></param>
        /// <param name="body"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="containerMetadata"></param>
        /// <param name="createdAt"></param>
        /// <param name="dockerMetadata"></param>
        /// <param name="draft"></param>
        /// <param name="manifest"></param>
        /// <param name="npmMetadata"></param>
        /// <param name="nugetMetadata"></param>
        /// <param name="packageUrl"></param>
        /// <param name="prerelease"></param>
        /// <param name="release"></param>
        /// <param name="rubygemsMetadata"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="tagName"></param>
        /// <param name="targetCommitish"></param>
        /// <param name="targetOid"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookPackagePublishedPackagePackageVersion(
            string description,
            string htmlUrl,
            int id,
            string installationCommand,
            global::System.Collections.Generic.IList<object> metadata,
            string name,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionPackageFile> packageFiles,
            string summary,
            string version,
            global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionAuthor? author,
            global::tryAGI.GitHub.OneOf<string, object>? body,
            string? bodyHtml,
            global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionContainerMetadata? containerMetadata,
            string? createdAt,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionDockerMetadataItem>? dockerMetadata,
            bool? draft,
            string? manifest,
            global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionNpmMetadata? npmMetadata,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionNugetMetadataItem>? nugetMetadata,
            string? packageUrl,
            bool? prerelease,
            global::tryAGI.GitHub.WebhookPackagePublishedPackagePackageVersionRelease? release,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.WebhookRubygemsMetadata>? rubygemsMetadata,
            string? sourceUrl,
            string? tagName,
            string? targetCommitish,
            string? targetOid,
            string? updatedAt)
        {
            this.Author = author;
            this.Body = body;
            this.BodyHtml = bodyHtml;
            this.ContainerMetadata = containerMetadata;
            this.CreatedAt = createdAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.DockerMetadata = dockerMetadata;
            this.Draft = draft;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Id = id;
            this.InstallationCommand = installationCommand ?? throw new global::System.ArgumentNullException(nameof(installationCommand));
            this.Manifest = manifest;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NpmMetadata = npmMetadata;
            this.NugetMetadata = nugetMetadata;
            this.PackageFiles = packageFiles ?? throw new global::System.ArgumentNullException(nameof(packageFiles));
            this.PackageUrl = packageUrl;
            this.Prerelease = prerelease;
            this.Release = release;
            this.RubygemsMetadata = rubygemsMetadata;
            this.SourceUrl = sourceUrl;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.TagName = tagName;
            this.TargetCommitish = targetCommitish;
            this.TargetOid = targetOid;
            this.UpdatedAt = updatedAt;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPackagePublishedPackagePackageVersion" /> class.
        /// </summary>
        public WebhookPackagePublishedPackagePackageVersion()
        {
        }

    }
}