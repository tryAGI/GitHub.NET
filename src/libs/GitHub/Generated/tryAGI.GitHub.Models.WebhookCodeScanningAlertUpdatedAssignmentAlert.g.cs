
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The code scanning alert involved in the event.
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertUpdatedAssignmentAlert
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>? Assignees { get; set; }

        /// <summary>
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ.`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_at")]
        public global::System.DateTime? DismissedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_by")]
        public global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedBy? DismissedBy { get; set; }

        /// <summary>
        /// The dismissal comment associated with the dismissal of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        public string? DismissedComment { get; set; }

        /// <summary>
        /// The reason for dismissing or closing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReasonJsonConverter))]
        public global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// The time that the alert was fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fixed_at")]
        public object? FixedAt { get; set; }

        /// <summary>
        /// The GitHub URL of the alert resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_instance")]
        public global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstance? MostRecentInstance { get; set; }

        /// <summary>
        /// The code scanning alert number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertRule Rule { get; set; }

        /// <summary>
        /// State of a code scanning alert. Events for alerts found outside the default branch will return a `null` value until they are dismissed or fixed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCodeScanningAlertUpdatedAssignmentAlertStateJsonConverter))]
        public global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertState? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertTool Tool { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertUpdatedAssignmentAlert" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ.`
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL of the alert resource.
        /// </param>
        /// <param name="number">
        /// The code scanning alert number.
        /// </param>
        /// <param name="rule"></param>
        /// <param name="tool"></param>
        /// <param name="url"></param>
        /// <param name="assignees"></param>
        /// <param name="dismissedAt">
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="dismissedBy"></param>
        /// <param name="dismissedComment">
        /// The dismissal comment associated with the dismissal of the alert.
        /// </param>
        /// <param name="dismissedReason">
        /// The reason for dismissing or closing the alert.
        /// </param>
        /// <param name="fixedAt">
        /// The time that the alert was fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="mostRecentInstance"></param>
        /// <param name="state">
        /// State of a code scanning alert. Events for alerts found outside the default branch will return a `null` value until they are dismissed or fixed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCodeScanningAlertUpdatedAssignmentAlert(
            global::System.DateTime createdAt,
            string htmlUrl,
            int number,
            global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertRule rule,
            global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertTool tool,
            string url,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>? assignees,
            global::System.DateTime? dismissedAt,
            global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedBy? dismissedBy,
            string? dismissedComment,
            global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertDismissedReason? dismissedReason,
            object? fixedAt,
            global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstance? mostRecentInstance,
            global::tryAGI.GitHub.WebhookCodeScanningAlertUpdatedAssignmentAlertState? state)
        {
            this.Assignees = assignees;
            this.CreatedAt = createdAt;
            this.DismissedAt = dismissedAt;
            this.DismissedBy = dismissedBy;
            this.DismissedComment = dismissedComment;
            this.DismissedReason = dismissedReason;
            this.FixedAt = fixedAt;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.MostRecentInstance = mostRecentInstance;
            this.Number = number;
            this.Rule = rule ?? throw new global::System.ArgumentNullException(nameof(rule));
            this.State = state;
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertUpdatedAssignmentAlert" /> class.
        /// </summary>
        public WebhookCodeScanningAlertUpdatedAssignmentAlert()
        {
        }

    }
}