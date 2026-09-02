
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssueCommentEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.Issue Issue { get; set; }

        /// <summary>
        /// Comments provide a way for people to collaborate on an issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.IssueComment Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueCommentEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="issue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="comment">
        /// Comments provide a way for people to collaborate on an issue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueCommentEvent(
            string action,
            global::tryAGI.GitHub.Issue issue,
            global::tryAGI.GitHub.IssueComment comment)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Issue = issue ?? throw new global::System.ArgumentNullException(nameof(issue));
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueCommentEvent" /> class.
        /// </summary>
        public IssueCommentEvent()
        {
        }

    }
}