
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The configuration for GitHub Pages for a repository.
    /// </summary>
    public sealed partial class Page
    {
        /// <summary>
        /// The API address for accessing this Page resource.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/pages
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/pages</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The status of the most recent build of the Page.<br/>
        /// Example: built
        /// </summary>
        /// <example>built</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PageStatusJsonConverter))]
        public global::tryAGI.GitHub.PageStatus? Status { get; set; }

        /// <summary>
        /// The Pages site's custom domain<br/>
        /// Example: example.com
        /// </summary>
        /// <example>example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cname")]
        public string? Cname { get; set; }

        /// <summary>
        /// The state if the domain is verified<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected_domain_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PageProtectedDomainStateJsonConverter))]
        public global::tryAGI.GitHub.PageProtectedDomainState? ProtectedDomainState { get; set; }

        /// <summary>
        /// The timestamp when a pending domain becomes unverified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_domain_unverified_at")]
        public global::System.DateTime? PendingDomainUnverifiedAt { get; set; }

        /// <summary>
        /// Whether the Page has a custom 404 page.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_404")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Custom404 { get; set; }

        /// <summary>
        /// The web address the Page can be accessed from.<br/>
        /// Example: https://example.com
        /// </summary>
        /// <example>https://example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// The process in which the Page will be built.<br/>
        /// Example: legacy
        /// </summary>
        /// <example>legacy</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("build_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.PageBuildTypeJsonConverter))]
        public global::tryAGI.GitHub.PageBuildType? BuildType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::tryAGI.GitHub.PagesSourceHash? Source { get; set; }

        /// <summary>
        /// Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("https_certificate")]
        public global::tryAGI.GitHub.PagesHttpsCertificate? HttpsCertificate { get; set; }

        /// <summary>
        /// Whether https is enabled on the domain<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("https_enforced")]
        public bool? HttpsEnforced { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
        /// </summary>
        /// <param name="url">
        /// The API address for accessing this Page resource.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/pages
        /// </param>
        /// <param name="custom404">
        /// Whether the Page has a custom 404 page.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="public">
        /// Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.<br/>
        /// Example: true
        /// </param>
        /// <param name="status">
        /// The status of the most recent build of the Page.<br/>
        /// Example: built
        /// </param>
        /// <param name="cname">
        /// The Pages site's custom domain<br/>
        /// Example: example.com
        /// </param>
        /// <param name="protectedDomainState">
        /// The state if the domain is verified<br/>
        /// Example: pending
        /// </param>
        /// <param name="pendingDomainUnverifiedAt">
        /// The timestamp when a pending domain becomes unverified.
        /// </param>
        /// <param name="htmlUrl">
        /// The web address the Page can be accessed from.<br/>
        /// Example: https://example.com
        /// </param>
        /// <param name="buildType">
        /// The process in which the Page will be built.<br/>
        /// Example: legacy
        /// </param>
        /// <param name="source"></param>
        /// <param name="httpsCertificate"></param>
        /// <param name="httpsEnforced">
        /// Whether https is enabled on the domain<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Page(
            string url,
            bool custom404,
            bool @public,
            global::tryAGI.GitHub.PageStatus? status,
            string? cname,
            global::tryAGI.GitHub.PageProtectedDomainState? protectedDomainState,
            global::System.DateTime? pendingDomainUnverifiedAt,
            string? htmlUrl,
            global::tryAGI.GitHub.PageBuildType? buildType,
            global::tryAGI.GitHub.PagesSourceHash? source,
            global::tryAGI.GitHub.PagesHttpsCertificate? httpsCertificate,
            bool? httpsEnforced)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Status = status;
            this.Cname = cname;
            this.ProtectedDomainState = protectedDomainState;
            this.PendingDomainUnverifiedAt = pendingDomainUnverifiedAt;
            this.Custom404 = custom404;
            this.HtmlUrl = htmlUrl;
            this.BuildType = buildType;
            this.Source = source;
            this.Public = @public;
            this.HttpsCertificate = httpsCertificate;
            this.HttpsEnforced = httpsEnforced;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
        /// </summary>
        public Page()
        {
        }

    }
}