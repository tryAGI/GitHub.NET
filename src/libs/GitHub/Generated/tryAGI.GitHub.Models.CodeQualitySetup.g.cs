
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Configuration for code quality setup.
    /// </summary>
    public sealed partial class CodeQualitySetup
    {
        /// <summary>
        /// Code quality setup has been configured or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualitySetupStateJsonConverter))]
        public global::tryAGI.GitHub.CodeQualitySetupState? State { get; set; }

        /// <summary>
        /// Languages to be analyzed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeQualitySetupLanguage>? Languages { get; set; }

        /// <summary>
        /// Runner type to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualitySetupRunnerTypeJsonConverter))]
        public global::tryAGI.GitHub.CodeQualitySetupRunnerType? RunnerType { get; set; }

        /// <summary>
        /// Runner label to be used if the runner type is labeled.<br/>
        /// Example: code-scanning
        /// </summary>
        /// <example>code-scanning</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_label")]
        public string? RunnerLabel { get; set; }

        /// <summary>
        /// Timestamp of latest configuration update.<br/>
        /// Example: 2023-12-06T14:20:20.000Z
        /// </summary>
        /// <example>2023-12-06T14:20:20.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The frequency of the periodic analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualitySetupScheduleJsonConverter))]
        public global::tryAGI.GitHub.CodeQualitySetupSchedule? Schedule { get; set; }

        /// <summary>
        /// The AI findings configuration for the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_findings_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualitySetupAiFindingsOptionJsonConverter))]
        public global::tryAGI.GitHub.CodeQualitySetupAiFindingsOption? AiFindingsOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualitySetup" /> class.
        /// </summary>
        /// <param name="state">
        /// Code quality setup has been configured or not.
        /// </param>
        /// <param name="languages">
        /// Languages to be analyzed.
        /// </param>
        /// <param name="runnerType">
        /// Runner type to be used.
        /// </param>
        /// <param name="runnerLabel">
        /// Runner label to be used if the runner type is labeled.<br/>
        /// Example: code-scanning
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of latest configuration update.<br/>
        /// Example: 2023-12-06T14:20:20.000Z
        /// </param>
        /// <param name="schedule">
        /// The frequency of the periodic analysis.
        /// </param>
        /// <param name="aiFindingsOption">
        /// The AI findings configuration for the repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeQualitySetup(
            global::tryAGI.GitHub.CodeQualitySetupState? state,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.CodeQualitySetupLanguage>? languages,
            global::tryAGI.GitHub.CodeQualitySetupRunnerType? runnerType,
            string? runnerLabel,
            global::System.DateTime? updatedAt,
            global::tryAGI.GitHub.CodeQualitySetupSchedule? schedule,
            global::tryAGI.GitHub.CodeQualitySetupAiFindingsOption? aiFindingsOption)
        {
            this.State = state;
            this.Languages = languages;
            this.RunnerType = runnerType;
            this.RunnerLabel = runnerLabel;
            this.UpdatedAt = updatedAt;
            this.Schedule = schedule;
            this.AiFindingsOption = aiFindingsOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualitySetup" /> class.
        /// </summary>
        public CodeQualitySetup()
        {
        }

    }
}