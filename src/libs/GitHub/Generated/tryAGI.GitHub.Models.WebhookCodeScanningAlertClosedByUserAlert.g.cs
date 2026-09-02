
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// The code scanning alert involved in the event.
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertClosedByUserAlert
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime DismissedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_by")]
        public global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissedBy? DismissedBy { get; set; }

        /// <summary>
        /// The dismissal comment associated with the dismissal of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        public string? DismissedComment { get; set; }

        /// <summary>
        /// The reason for dismissing or closing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCodeScanningAlertClosedByUserAlertDismissedReasonJsonConverter))]
        public global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissedReason? DismissedReason { get; set; }

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
        public global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertMostRecentInstance? MostRecentInstance { get; set; }

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
        public required global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertRule Rule { get; set; }

        /// <summary>
        /// State of a code scanning alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookCodeScanningAlertClosedByUserAlertStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertTool Tool { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissal_approved_by")]
        public global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedBy? DismissalApprovedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertClosedByUserAlert" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ.`
        /// </param>
        /// <param name="dismissedAt">
        /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
        /// </param>
        /// <param name="htmlUrl">
        /// The GitHub URL of the alert resource.
        /// </param>
        /// <param name="number">
        /// The code scanning alert number.
        /// </param>
        /// <param name="rule"></param>
        /// <param name="state">
        /// State of a code scanning alert.
        /// </param>
        /// <param name="tool"></param>
        /// <param name="url"></param>
        /// <param name="assignees"></param>
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
        /// <param name="dismissalApprovedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCodeScanningAlertClosedByUserAlert(
            global::System.DateTime createdAt,
            global::System.DateTime dismissedAt,
            string htmlUrl,
            int number,
            global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertRule rule,
            global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertState state,
            global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertTool tool,
            string url,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SimpleUser>? assignees,
            global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissedBy? dismissedBy,
            string? dismissedComment,
            global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissedReason? dismissedReason,
            object? fixedAt,
            global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertMostRecentInstance? mostRecentInstance,
            global::tryAGI.GitHub.WebhookCodeScanningAlertClosedByUserAlertDismissalApprovedBy? dismissalApprovedBy)
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
            this.DismissalApprovedBy = dismissalApprovedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertClosedByUserAlert" /> class.
        /// </summary>
        public WebhookCodeScanningAlertClosedByUserAlert()
        {
        }

    }
}