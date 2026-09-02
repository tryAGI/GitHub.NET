
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestEvent
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
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pull_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.PullRequestMinimal PullRequest { get; set; }

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
        /// Initializes a new instance of the <see cref="PullRequestEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="number"></param>
        /// <param name="pullRequest"></param>
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
        public PullRequestEvent(
            string action,
            int number,
            global::tryAGI.GitHub.PullRequestMinimal pullRequest,
            global::tryAGI.GitHub.SimpleUser? assignee,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>? assignees,
            global::tryAGI.GitHub.Label? label,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.Label>? labels)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Number = number;
            this.PullRequest = pullRequest ?? throw new global::System.ArgumentNullException(nameof(pullRequest));
            this.Assignee = assignee;
            this.Assignees = assignees;
            this.Label = label;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestEvent" /> class.
        /// </summary>
        public PullRequestEvent()
        {
        }

    }
}