
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesEvent
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
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::tryAGI.GitHub.SimpleUser? Assignee { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>? Assignees { get; set; }

        /// <summary>
        /// Color-coded labels help you categorize and filter your issues (just like labels in Gmail).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public global::tryAGI.GitHub.Label? Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.Label>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="issue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        /// <param name="assignee">
        /// A GitHub user.
        /// </param>
        /// <param name="assignees"></param>
        /// <param name="label">
        /// Color-coded labels help you categorize and filter your issues (just like labels in Gmail).
        /// </param>
        /// <param name="labels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesEvent(
            string action,
            global::tryAGI.GitHub.Issue issue,
            global::tryAGI.GitHub.SimpleUser? assignee,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>? assignees,
            global::tryAGI.GitHub.Label? label,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.Label>? labels)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Issue = issue ?? throw new global::System.ArgumentNullException(nameof(issue));
            this.Assignee = assignee;
            this.Assignees = assignees;
            this.Label = label;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesEvent" /> class.
        /// </summary>
        public IssuesEvent()
        {
        }

    }
}