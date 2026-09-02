
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Code quality rule
    /// </summary>
    public sealed partial class CodeQualityFindingRule
    {
        /// <summary>
        /// A unique identifier for the rule used to detect the finding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the rule used to detect the finding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// A short description of the rule used to detect the finding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// A detailed description of the rule used to detect the finding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("help")]
        public string? Help { get; set; }

        /// <summary>
        /// The severity of the rule used to detect the finding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualityFindingRuleSeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CodeQualityFindingRuleSeverity Severity { get; set; }

        /// <summary>
        /// The category of the rule used to detect the finding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualityFindingRuleCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CodeQualityFindingRuleCategory Category { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualityFindingRule" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the rule used to detect the finding.
        /// </param>
        /// <param name="title">
        /// The name of the rule used to detect the finding.
        /// </param>
        /// <param name="description">
        /// A short description of the rule used to detect the finding.
        /// </param>
        /// <param name="severity">
        /// The severity of the rule used to detect the finding.
        /// </param>
        /// <param name="category">
        /// The category of the rule used to detect the finding.
        /// </param>
        /// <param name="help">
        /// A detailed description of the rule used to detect the finding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeQualityFindingRule(
            string id,
            string title,
            string description,
            global::tryAGI.GitHub.CodeQualityFindingRuleSeverity severity,
            global::tryAGI.GitHub.CodeQualityFindingRuleCategory category,
            string? help)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Help = help;
            this.Severity = severity;
            this.Category = category;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualityFindingRule" /> class.
        /// </summary>
        public CodeQualityFindingRule()
        {
        }

    }
}