
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A minimal reference to an issue linked from a timeline event (e.g. sub-issue, parent-issue, or dependency events).
    /// </summary>
    public sealed partial class NullableIssueReference
    {
        /// <summary>
        /// The number of the referenced issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// The title of the referenced issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The state of the referenced issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// The reason for the referenced issue's state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_reason")]
        public string? StateReason { get; set; }

        /// <summary>
        /// A GitHub repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleRepository Repository { get; set; }

        /// <summary>
        /// The type of the referenced issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_type")]
        public global::tryAGI.GitHub.NullableIssueReferenceIssueType? IssueType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssueReference" /> class.
        /// </summary>
        /// <param name="number">
        /// The number of the referenced issue.
        /// </param>
        /// <param name="title">
        /// The title of the referenced issue.
        /// </param>
        /// <param name="state">
        /// The state of the referenced issue.
        /// </param>
        /// <param name="repository">
        /// A GitHub repository.
        /// </param>
        /// <param name="stateReason">
        /// The reason for the referenced issue's state.
        /// </param>
        /// <param name="issueType">
        /// The type of the referenced issue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NullableIssueReference(
            int number,
            string title,
            string state,
            global::tryAGI.GitHub.SimpleRepository repository,
            string? stateReason,
            global::tryAGI.GitHub.NullableIssueReferenceIssueType? issueType)
        {
            this.Number = number;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.StateReason = stateReason;
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
            this.IssueType = issueType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssueReference" /> class.
        /// </summary>
        public NullableIssueReference()
        {
        }

    }
}