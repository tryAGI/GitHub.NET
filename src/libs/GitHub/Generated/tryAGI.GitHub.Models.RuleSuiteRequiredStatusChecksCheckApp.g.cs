
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The GitHub App associated with the status check.
    /// </summary>
    public sealed partial class RuleSuiteRequiredStatusChecksCheckApp
    {
        /// <summary>
        /// The unique identifier of the GitHub App.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The slug of the GitHub App.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// The name of the GitHub App.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuiteRequiredStatusChecksCheckApp" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the GitHub App.
        /// </param>
        /// <param name="slug">
        /// The slug of the GitHub App.
        /// </param>
        /// <param name="name">
        /// The name of the GitHub App.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuleSuiteRequiredStatusChecksCheckApp(
            int? id,
            string? slug,
            string? name)
        {
            this.Id = id;
            this.Slug = slug;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuiteRequiredStatusChecksCheckApp" /> class.
        /// </summary>
        public RuleSuiteRequiredStatusChecksCheckApp()
        {
        }

    }
}