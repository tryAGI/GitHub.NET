
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiscussionEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// A Discussion in a repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discussion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.Discussion Discussion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscussionEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="discussion">
        /// A Discussion in a repository.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscussionEvent(
            string action,
            global::tryAGI.GitHub.Discussion discussion)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Discussion = discussion ?? throw new global::System.ArgumentNullException(nameof(discussion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscussionEvent" /> class.
        /// </summary>
        public DiscussionEvent()
        {
        }

    }
}