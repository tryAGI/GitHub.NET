
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Context around who pinned an issue comment and when it was pinned.
    /// </summary>
    public sealed partial class NullablePinnedIssueComment
    {
        /// <summary>
        /// Example: 2011-04-14T16:00:49Z
        /// </summary>
        /// <example>2011-04-14T16:00:49Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PinnedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinned_by")]
        public global::tryAGI.GitHub.NullableSimpleUser? PinnedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullablePinnedIssueComment" /> class.
        /// </summary>
        /// <param name="pinnedAt">
        /// Example: 2011-04-14T16:00:49Z
        /// </param>
        /// <param name="pinnedBy">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NullablePinnedIssueComment(
            global::System.DateTime pinnedAt,
            global::tryAGI.GitHub.NullableSimpleUser? pinnedBy)
        {
            this.PinnedAt = pinnedAt;
            this.PinnedBy = pinnedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullablePinnedIssueComment" /> class.
        /// </summary>
        public NullablePinnedIssueComment()
        {
        }

    }
}