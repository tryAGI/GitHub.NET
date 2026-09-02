
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Information about an active dismissal request for this Dependabot alert.
    /// </summary>
    public sealed partial class DependabotAlertDismissalRequestSimple
    {
        /// <summary>
        /// The unique identifier of the dismissal request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The current status of the dismissal request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.DependabotAlertDismissalRequestSimpleStatusJsonConverter))]
        public global::tryAGI.GitHub.DependabotAlertDismissalRequestSimpleStatus? Status { get; set; }

        /// <summary>
        /// The user who requested the dismissal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requester")]
        public global::tryAGI.GitHub.DependabotAlertDismissalRequestSimpleRequester? Requester { get; set; }

        /// <summary>
        /// The date and time when the dismissal request was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The API URL to get more information about this dismissal request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertDismissalRequestSimple" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the dismissal request.
        /// </param>
        /// <param name="status">
        /// The current status of the dismissal request.
        /// </param>
        /// <param name="requester">
        /// The user who requested the dismissal.
        /// </param>
        /// <param name="createdAt">
        /// The date and time when the dismissal request was created.
        /// </param>
        /// <param name="url">
        /// The API URL to get more information about this dismissal request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotAlertDismissalRequestSimple(
            int? id,
            global::tryAGI.GitHub.DependabotAlertDismissalRequestSimpleStatus? status,
            global::tryAGI.GitHub.DependabotAlertDismissalRequestSimpleRequester? requester,
            global::System.DateTime? createdAt,
            string? url)
        {
            this.Id = id;
            this.Status = status;
            this.Requester = requester;
            this.CreatedAt = createdAt;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertDismissalRequestSimple" /> class.
        /// </summary>
        public DependabotAlertDismissalRequestSimple()
        {
        }

    }
}