
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretScanningUpdateAlertRequest
    {
        /// <summary>
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SecretScanningAlertStateJsonConverter))]
        public global::tryAGI.GitHub.SecretScanningAlertState? State { get; set; }

        /// <summary>
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SecretScanningAlertResolutionJsonConverter))]
        public global::tryAGI.GitHub.SecretScanningAlertResolution? Resolution { get; set; }

        /// <summary>
        /// An optional comment when closing or reopening an alert. Cannot be updated or deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution_comment")]
        public string? ResolutionComment { get; set; }

        /// <summary>
        /// The username of the user to assign to the alert. Set to `null` to unassign the alert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public string? Assignee { get; set; }

        /// <summary>
        /// Sets the validity of the secret scanning alert. Can be `active`, `inactive`, or `null` to clear the override.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SecretScanningUpdateAlertRequestValidityJsonConverter))]
        public global::tryAGI.GitHub.SecretScanningUpdateAlertRequestValidity? Validity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateAlertRequest" /> class.
        /// </summary>
        /// <param name="state">
        /// Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.
        /// </param>
        /// <param name="resolution">
        /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
        /// </param>
        /// <param name="resolutionComment">
        /// An optional comment when closing or reopening an alert. Cannot be updated or deleted.
        /// </param>
        /// <param name="assignee">
        /// The username of the user to assign to the alert. Set to `null` to unassign the alert.
        /// </param>
        /// <param name="validity">
        /// Sets the validity of the secret scanning alert. Can be `active`, `inactive`, or `null` to clear the override.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningUpdateAlertRequest(
            global::tryAGI.GitHub.SecretScanningAlertState? state,
            global::tryAGI.GitHub.SecretScanningAlertResolution? resolution,
            string? resolutionComment,
            string? assignee,
            global::tryAGI.GitHub.SecretScanningUpdateAlertRequestValidity? validity)
        {
            this.State = state;
            this.Resolution = resolution;
            this.ResolutionComment = resolutionComment;
            this.Assignee = assignee;
            this.Validity = validity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningUpdateAlertRequest" /> class.
        /// </summary>
        public SecretScanningUpdateAlertRequest()
        {
        }

    }
}