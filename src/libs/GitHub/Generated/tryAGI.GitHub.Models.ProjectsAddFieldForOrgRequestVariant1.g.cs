
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectsAddFieldForOrgRequestVariant1
    {
        /// <summary>
        /// The ID of the IssueField to create the field for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IssueFieldId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddFieldForOrgRequestVariant1" /> class.
        /// </summary>
        /// <param name="issueFieldId">
        /// The ID of the IssueField to create the field for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsAddFieldForOrgRequestVariant1(
            int issueFieldId)
        {
            this.IssueFieldId = issueFieldId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsAddFieldForOrgRequestVariant1" /> class.
        /// </summary>
        public ProjectsAddFieldForOrgRequestVariant1()
        {
        }

    }
}