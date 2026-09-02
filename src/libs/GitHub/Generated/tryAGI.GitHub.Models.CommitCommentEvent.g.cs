
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CommitCommentEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.CommitCommentEventComment Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitCommentEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="comment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitCommentEvent(
            string action,
            global::tryAGI.GitHub.CommitCommentEventComment comment)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitCommentEvent" /> class.
        /// </summary>
        public CommitCommentEvent()
        {
        }

    }
}