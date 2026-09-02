
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretScanningBulkDeleteOrgCustomPatternsRequest
    {
        /// <summary>
        /// The list of custom patterns to delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patterns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPatternToDelete> Patterns { get; set; }

        /// <summary>
        /// What to do with alerts associated with the deleted patterns.<br/>
        /// `delete_alerts` permanently removes the alerts.<br/>
        /// `resolve_alerts` resolves the alerts as "pattern deleted".<br/>
        /// Defaults to `delete_alerts` when not specified.<br/>
        /// Default Value: delete_alerts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_delete_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteActionJsonConverter))]
        public global::tryAGI.GitHub.SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction? PostDeleteAction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkDeleteOrgCustomPatternsRequest" /> class.
        /// </summary>
        /// <param name="patterns">
        /// The list of custom patterns to delete.
        /// </param>
        /// <param name="postDeleteAction">
        /// What to do with alerts associated with the deleted patterns.<br/>
        /// `delete_alerts` permanently removes the alerts.<br/>
        /// `resolve_alerts` resolves the alerts as "pattern deleted".<br/>
        /// Defaults to `delete_alerts` when not specified.<br/>
        /// Default Value: delete_alerts
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretScanningBulkDeleteOrgCustomPatternsRequest(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.SecretScanningCustomPatternToDelete> patterns,
            global::tryAGI.GitHub.SecretScanningBulkDeleteOrgCustomPatternsRequestPostDeleteAction? postDeleteAction)
        {
            this.Patterns = patterns ?? throw new global::System.ArgumentNullException(nameof(patterns));
            this.PostDeleteAction = postDeleteAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningBulkDeleteOrgCustomPatternsRequest" /> class.
        /// </summary>
        public SecretScanningBulkDeleteOrgCustomPatternsRequest()
        {
        }

    }
}