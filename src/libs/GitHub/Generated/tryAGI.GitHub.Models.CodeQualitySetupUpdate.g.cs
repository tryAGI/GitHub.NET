
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Configuration for code quality setup.
    /// </summary>
    public sealed partial class CodeQualitySetupUpdate
    {
        /// <summary>
        /// The desired state of code quality setup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualitySetupUpdateStateJsonConverter))]
        public global::tryAGI.GitHub.CodeQualitySetupUpdateState? State { get; set; }

        /// <summary>
        /// Runner type to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualitySetupUpdateRunnerTypeJsonConverter))]
        public global::tryAGI.GitHub.CodeQualitySetupUpdateRunnerType? RunnerType { get; set; }

        /// <summary>
        /// Runner label to be used if the runner type is labeled.<br/>
        /// Example: code-scanning
        /// </summary>
        /// <example>code-scanning</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_label")]
        public string? RunnerLabel { get; set; }

        /// <summary>
        /// Languages to be analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeQualitySetupUpdateLanguage>? Languages { get; set; }

        /// <summary>
        /// Whether AI findings run for Code Quality on this repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_findings_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualitySetupUpdateAiFindingsOptionJsonConverter))]
        public global::tryAGI.GitHub.CodeQualitySetupUpdateAiFindingsOption? AiFindingsOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualitySetupUpdate" /> class.
        /// </summary>
        /// <param name="state">
        /// The desired state of code quality setup.
        /// </param>
        /// <param name="runnerType">
        /// Runner type to be used.
        /// </param>
        /// <param name="runnerLabel">
        /// Runner label to be used if the runner type is labeled.<br/>
        /// Example: code-scanning
        /// </param>
        /// <param name="languages">
        /// Languages to be analyzed.
        /// </param>
        /// <param name="aiFindingsOption">
        /// Whether AI findings run for Code Quality on this repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeQualitySetupUpdate(
            global::tryAGI.GitHub.CodeQualitySetupUpdateState? state,
            global::tryAGI.GitHub.CodeQualitySetupUpdateRunnerType? runnerType,
            string? runnerLabel,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeQualitySetupUpdateLanguage>? languages,
            global::tryAGI.GitHub.CodeQualitySetupUpdateAiFindingsOption? aiFindingsOption)
        {
            this.State = state;
            this.RunnerType = runnerType;
            this.RunnerLabel = runnerLabel;
            this.Languages = languages;
            this.AiFindingsOption = aiFindingsOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualitySetupUpdate" /> class.
        /// </summary>
        public CodeQualitySetupUpdate()
        {
        }

    }
}