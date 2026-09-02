
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Details about why an issue comment was minimized.
    /// </summary>
    public sealed partial class NullableIssueCommentMinimized
    {
        /// <summary>
        /// The reason the comment was minimized.<br/>
        /// Example: low-quality
        /// </summary>
        /// <example>low-quality</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssueCommentMinimized" /> class.
        /// </summary>
        /// <param name="reason">
        /// The reason the comment was minimized.<br/>
        /// Example: low-quality
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NullableIssueCommentMinimized(
            string? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableIssueCommentMinimized" /> class.
        /// </summary>
        public NullableIssueCommentMinimized()
        {
        }

    }
}