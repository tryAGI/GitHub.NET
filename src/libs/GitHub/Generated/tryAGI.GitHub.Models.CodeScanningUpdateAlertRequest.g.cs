
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CodeScanningUpdateAlertRequest
    {
        /// <summary>
        /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeScanningAlertSetStateJsonConverter))]
        public global::tryAGI.GitHub.CodeScanningAlertSetState? State { get; set; }

        /// <summary>
        /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.CodeScanningAlertDismissedReasonJsonConverter))]
        public global::tryAGI.GitHub.CodeScanningAlertDismissedReason? DismissedReason { get; set; }

        /// <summary>
        /// The dismissal comment associated with the dismissal of the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissed_comment")]
        public string? DismissedComment { get; set; }

        /// <summary>
        /// If `true`, attempt to create an alert dismissal request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_request")]
        public bool? CreateRequest { get; set; }

        /// <summary>
        /// The list of users to assign to the code scanning alert. An empty array unassigns all previous assignees from the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignees")]
        public global::System.Collections.Generic.IList<string>? Assignees { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningUpdateAlertRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
        /// </param>
        /// <param name="dismissedReason">
        /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
        /// </param>
        /// <param name="dismissedComment">
        /// The dismissal comment associated with the dismissal of the alert.
        /// </param>
        /// <param name="createRequest">
        /// If `true`, attempt to create an alert dismissal request.
        /// </param>
        /// <param name="assignees">
        /// The list of users to assign to the code scanning alert. An empty array unassigns all previous assignees from the alert.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningUpdateAlertRequest(
            global::tryAGI.GitHub.CodeScanningAlertSetState? state,
            global::tryAGI.GitHub.CodeScanningAlertDismissedReason? dismissedReason,
            string? dismissedComment,
            bool? createRequest,
            global::System.Collections.Generic.IList<string>? assignees)
        {
            this.State = state;
            this.DismissedReason = dismissedReason;
            this.DismissedComment = dismissedComment;
            this.CreateRequest = createRequest;
            this.Assignees = assignees;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningUpdateAlertRequest" /> class.
        /// </summary>
        public CodeScanningUpdateAlertRequest()
        {
        }

    }
}