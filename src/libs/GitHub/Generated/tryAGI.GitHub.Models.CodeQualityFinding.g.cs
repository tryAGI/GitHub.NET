
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Code quality finding
    /// </summary>
    public sealed partial class CodeQualityFinding
    {
        /// <summary>
        /// The finding number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// State of the code quality finding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeQualityFindingStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CodeQualityFindingState State { get; set; }

        /// <summary>
        /// The REST API URL of the code quality finding resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Code quality rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CodeQualityFindingRule Rule { get; set; }

        /// <summary>
        /// Code quality file location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CodeQualityFindingLocation Location { get; set; }

        /// <summary>
        /// Code quality finding message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CodeQualityFindingMessage Message { get; set; }

        /// <summary>
        /// The time the code quality finding was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualityFinding" /> class.
        /// </summary>
        /// <param name="number">
        /// The finding number.
        /// </param>
        /// <param name="state">
        /// State of the code quality finding.
        /// </param>
        /// <param name="url">
        /// The REST API URL of the code quality finding resource.
        /// </param>
        /// <param name="rule">
        /// Code quality rule
        /// </param>
        /// <param name="location">
        /// Code quality file location
        /// </param>
        /// <param name="message">
        /// Code quality finding message
        /// </param>
        /// <param name="createdAt">
        /// The time the code quality finding was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeQualityFinding(
            int number,
            global::tryAGI.GitHub.CodeQualityFindingState state,
            string url,
            global::tryAGI.GitHub.CodeQualityFindingRule rule,
            global::tryAGI.GitHub.CodeQualityFindingLocation location,
            global::tryAGI.GitHub.CodeQualityFindingMessage message,
            global::System.DateTime? createdAt)
        {
            this.Number = number;
            this.State = state;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Rule = rule ?? throw new global::System.ArgumentNullException(nameof(rule));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeQualityFinding" /> class.
        /// </summary>
        public CodeQualityFinding()
        {
        }

    }
}