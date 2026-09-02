
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RuleSuiteRequiredStatusChecksCheck
    {
        /// <summary>
        /// The unique identifier of the status check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The context name of the status check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// The state of the status check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// The type of the status check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The GitHub App associated with the status check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::tryAGI.GitHub.RuleSuiteRequiredStatusChecksCheckApp? App { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuiteRequiredStatusChecksCheck" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the status check.
        /// </param>
        /// <param name="context">
        /// The context name of the status check.
        /// </param>
        /// <param name="state">
        /// The state of the status check.
        /// </param>
        /// <param name="type">
        /// The type of the status check.
        /// </param>
        /// <param name="app">
        /// The GitHub App associated with the status check.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleSuiteRequiredStatusChecksCheck(
            int? id,
            string? context,
            string? state,
            string? type,
            global::tryAGI.GitHub.RuleSuiteRequiredStatusChecksCheckApp? app)
        {
            this.Id = id;
            this.Context = context;
            this.State = state;
            this.Type = type;
            this.App = app;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuiteRequiredStatusChecksCheck" /> class.
        /// </summary>
        public RuleSuiteRequiredStatusChecksCheck()
        {
        }

    }
}