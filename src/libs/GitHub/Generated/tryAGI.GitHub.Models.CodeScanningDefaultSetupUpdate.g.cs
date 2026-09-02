
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Configuration for code scanning default setup.
    /// </summary>
    public sealed partial class CodeScanningDefaultSetupUpdate
    {
        /// <summary>
        /// The desired state of code scanning default setup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeScanningDefaultSetupUpdateStateJsonConverter))]
        public global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateState? State { get; set; }

        /// <summary>
        /// Runner type to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeScanningDefaultSetupUpdateRunnerTypeJsonConverter))]
        public global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateRunnerType? RunnerType { get; set; }

        /// <summary>
        /// Runner label to be used if the runner type is labeled.<br/>
        /// Example: code-scanning
        /// </summary>
        /// <example>code-scanning</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_label")]
        public string? RunnerLabel { get; set; }

        /// <summary>
        /// CodeQL query suite to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_suite")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeScanningDefaultSetupUpdateQuerySuiteJsonConverter))]
        public global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateQuerySuite? QuerySuite { get; set; }

        /// <summary>
        /// Threat model to be used for code scanning analysis. Use `remote` to analyze only network sources and `remote_and_local` to include local sources like filesystem access, command-line arguments, database reads, environment variable and standard input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threat_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeScanningDefaultSetupUpdateThreatModelJsonConverter))]
        public global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateThreatModel? ThreatModel { get; set; }

        /// <summary>
        /// CodeQL languages to be analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateLanguage>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetupUpdate" /> class.
        /// </summary>
        /// <param name="state">
        /// The desired state of code scanning default setup.
        /// </param>
        /// <param name="runnerType">
        /// Runner type to be used.
        /// </param>
        /// <param name="runnerLabel">
        /// Runner label to be used if the runner type is labeled.<br/>
        /// Example: code-scanning
        /// </param>
        /// <param name="querySuite">
        /// CodeQL query suite to be used.
        /// </param>
        /// <param name="threatModel">
        /// Threat model to be used for code scanning analysis. Use `remote` to analyze only network sources and `remote_and_local` to include local sources like filesystem access, command-line arguments, database reads, environment variable and standard input.
        /// </param>
        /// <param name="languages">
        /// CodeQL languages to be analyzed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningDefaultSetupUpdate(
            global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateState? state,
            global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateRunnerType? runnerType,
            string? runnerLabel,
            global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateQuerySuite? querySuite,
            global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateThreatModel? threatModel,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeScanningDefaultSetupUpdateLanguage>? languages)
        {
            this.State = state;
            this.RunnerType = runnerType;
            this.RunnerLabel = runnerLabel;
            this.QuerySuite = querySuite;
            this.ThreatModel = threatModel;
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningDefaultSetupUpdate" /> class.
        /// </summary>
        public CodeScanningDefaultSetupUpdate()
        {
        }

    }
}