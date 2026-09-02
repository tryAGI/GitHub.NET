
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RateLimitOverviewResources
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("core")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.RateLimit Core { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graphql")]
        public global::tryAGI.GitHub.RateLimit? Graphql { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.RateLimit Search { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_search")]
        public global::tryAGI.GitHub.RateLimit? CodeSearch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_import")]
        public global::tryAGI.GitHub.RateLimit? SourceImport { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_manifest")]
        public global::tryAGI.GitHub.RateLimit? IntegrationManifest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions_runner_registration")]
        public global::tryAGI.GitHub.RateLimit? ActionsRunnerRegistration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim")]
        public global::tryAGI.GitHub.RateLimit? Scim { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_snapshots")]
        public global::tryAGI.GitHub.RateLimit? DependencySnapshots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_sbom")]
        public global::tryAGI.GitHub.RateLimit? DependencySbom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_autofix")]
        public global::tryAGI.GitHub.RateLimit? CodeScanningAutofix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copilot_usage_records")]
        public global::tryAGI.GitHub.RateLimit? CopilotUsageRecords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverviewResources" /> class.
        /// </summary>
        /// <param name="core"></param>
        /// <param name="search"></param>
        /// <param name="graphql"></param>
        /// <param name="codeSearch"></param>
        /// <param name="sourceImport"></param>
        /// <param name="integrationManifest"></param>
        /// <param name="actionsRunnerRegistration"></param>
        /// <param name="scim"></param>
        /// <param name="dependencySnapshots"></param>
        /// <param name="dependencySbom"></param>
        /// <param name="codeScanningAutofix"></param>
        /// <param name="copilotUsageRecords"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitOverviewResources(
            global::tryAGI.GitHub.RateLimit core,
            global::tryAGI.GitHub.RateLimit search,
            global::tryAGI.GitHub.RateLimit? graphql,
            global::tryAGI.GitHub.RateLimit? codeSearch,
            global::tryAGI.GitHub.RateLimit? sourceImport,
            global::tryAGI.GitHub.RateLimit? integrationManifest,
            global::tryAGI.GitHub.RateLimit? actionsRunnerRegistration,
            global::tryAGI.GitHub.RateLimit? scim,
            global::tryAGI.GitHub.RateLimit? dependencySnapshots,
            global::tryAGI.GitHub.RateLimit? dependencySbom,
            global::tryAGI.GitHub.RateLimit? codeScanningAutofix,
            global::tryAGI.GitHub.RateLimit? copilotUsageRecords)
        {
            this.Core = core ?? throw new global::System.ArgumentNullException(nameof(core));
            this.Graphql = graphql;
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
            this.CodeSearch = codeSearch;
            this.SourceImport = sourceImport;
            this.IntegrationManifest = integrationManifest;
            this.ActionsRunnerRegistration = actionsRunnerRegistration;
            this.Scim = scim;
            this.DependencySnapshots = dependencySnapshots;
            this.DependencySbom = dependencySbom;
            this.CodeScanningAutofix = codeScanningAutofix;
            this.CopilotUsageRecords = copilotUsageRecords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverviewResources" /> class.
        /// </summary>
        public RateLimitOverviewResources()
        {
        }

    }
}