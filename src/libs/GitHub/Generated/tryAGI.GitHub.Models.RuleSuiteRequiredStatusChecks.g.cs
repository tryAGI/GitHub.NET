
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Metadata for a required status checks rule evaluation result.
    /// </summary>
    public sealed partial class RuleSuiteRequiredStatusChecks
    {
        /// <summary>
        /// The status checks associated with the rule evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.RuleSuiteRequiredStatusChecksCheck>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuiteRequiredStatusChecks" /> class.
        /// </summary>
        /// <param name="checks">
        /// The status checks associated with the rule evaluation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleSuiteRequiredStatusChecks(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.RuleSuiteRequiredStatusChecksCheck>? checks)
        {
            this.Checks = checks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuiteRequiredStatusChecks" /> class.
        /// </summary>
        public RuleSuiteRequiredStatusChecks()
        {
        }

    }
}