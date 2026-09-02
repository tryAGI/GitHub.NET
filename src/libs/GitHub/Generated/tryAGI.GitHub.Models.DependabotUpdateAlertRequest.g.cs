
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DependabotUpdateAlertRequest
    {
        /// <summary>
        /// The state of the Dependabot alert.<br/>
        /// A `dismissed_reason` must be provided when setting the state to `dismissed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.DependabotUpdateAlertRequestStateJsonConverter))]
        public global::tryAGI.GitHub.DependabotUpdateAlertRequestState? State { get; set; }

        /// <summary>
        /// **Required when `state` is `dismissed`.** A reason for dismissing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.DependabotUpdateAlertRequestDismissedReasonJsonConverter))]
        public global::tryAGI.GitHub.DependabotUpdateAlertRequestDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// An optional comment associated with dismissing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        public string? DismissedComment { get; set; }

        /// <summary>
        /// Usernames to assign to this Dependabot Alert.<br/>
        /// Pass one or more user logins to _replace_ the set of assignees on this alert.<br/>
        /// Send an empty array (`[]`) to clear all assignees from the alert.<br/>
        /// To assign an AI agent, include the bot login (for example, `copilot-swe-agent[bot]`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<string>? Assignees { get; set; }

        /// <summary>
        /// Parameters for AI agent assignment. Only used when an agent bot login is<br/>
        /// included in `assignees`. Ignored when no agent is being assigned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_assignment")]
        public global::tryAGI.GitHub.DependabotUpdateAlertRequestAgentAssignment? AgentAssignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateAlertRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// The state of the Dependabot alert.<br/>
        /// A `dismissed_reason` must be provided when setting the state to `dismissed`.
        /// </param>
        /// <param name="dismissedReason">
        /// **Required when `state` is `dismissed`.** A reason for dismissing the alert.
        /// </param>
        /// <param name="dismissedComment">
        /// An optional comment associated with dismissing the alert.
        /// </param>
        /// <param name="assignees">
        /// Usernames to assign to this Dependabot Alert.<br/>
        /// Pass one or more user logins to _replace_ the set of assignees on this alert.<br/>
        /// Send an empty array (`[]`) to clear all assignees from the alert.<br/>
        /// To assign an AI agent, include the bot login (for example, `copilot-swe-agent[bot]`).
        /// </param>
        /// <param name="agentAssignment">
        /// Parameters for AI agent assignment. Only used when an agent bot login is<br/>
        /// included in `assignees`. Ignored when no agent is being assigned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotUpdateAlertRequest(
            global::tryAGI.GitHub.DependabotUpdateAlertRequestState? state,
            global::tryAGI.GitHub.DependabotUpdateAlertRequestDismissedReason? dismissedReason,
            string? dismissedComment,
            global::System.Collections.Generic.IList<string>? assignees,
            global::tryAGI.GitHub.DependabotUpdateAlertRequestAgentAssignment? agentAssignment)
        {
            this.State = state;
            this.DismissedReason = dismissedReason;
            this.DismissedComment = dismissedComment;
            this.Assignees = assignees;
            this.AgentAssignment = agentAssignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotUpdateAlertRequest" /> class.
        /// </summary>
        public DependabotUpdateAlertRequest()
        {
        }

    }
}