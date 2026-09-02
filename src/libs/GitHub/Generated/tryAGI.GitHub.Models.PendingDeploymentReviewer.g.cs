
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PendingDeploymentReviewer
    {
        /// <summary>
        /// The type of reviewer.<br/>
        /// Example: User
        /// </summary>
        /// <example>User</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.DeploymentReviewerTypeJsonConverter))]
        public global::tryAGI.GitHub.DeploymentReviewerType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AnyOfJsonConverter<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.Team>))]
        public global::tryAGI.GitHub.AnyOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.Team>? Reviewer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingDeploymentReviewer" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of reviewer.<br/>
        /// Example: User
        /// </param>
        /// <param name="reviewer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PendingDeploymentReviewer(
            global::tryAGI.GitHub.DeploymentReviewerType? type,
            global::tryAGI.GitHub.AnyOf<global::tryAGI.GitHub.SimpleUser, global::tryAGI.GitHub.Team>? reviewer)
        {
            this.Type = type;
            this.Reviewer = reviewer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingDeploymentReviewer" /> class.
        /// </summary>
        public PendingDeploymentReviewer()
        {
        }

    }
}