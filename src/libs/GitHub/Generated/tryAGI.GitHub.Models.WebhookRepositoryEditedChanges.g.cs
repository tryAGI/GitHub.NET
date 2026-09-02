
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookRepositoryEditedChanges
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_branch")]
        public global::tryAGI.GitHub.WebhookRepositoryEditedChangesDefaultBranch? DefaultBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public global::tryAGI.GitHub.WebhookRepositoryEditedChangesDescription? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("homepage")]
        public global::tryAGI.GitHub.WebhookRepositoryEditedChangesHomepage? Homepage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::tryAGI.GitHub.WebhookRepositoryEditedChangesTopics? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryEditedChanges" /> class.
        /// </summary>
        /// <param name="defaultBranch"></param>
        /// <param name="description"></param>
        /// <param name="homepage"></param>
        /// <param name="topics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRepositoryEditedChanges(
            global::tryAGI.GitHub.WebhookRepositoryEditedChangesDefaultBranch? defaultBranch,
            global::tryAGI.GitHub.WebhookRepositoryEditedChangesDescription? description,
            global::tryAGI.GitHub.WebhookRepositoryEditedChangesHomepage? homepage,
            global::tryAGI.GitHub.WebhookRepositoryEditedChangesTopics? topics)
        {
            this.DefaultBranch = defaultBranch;
            this.Description = description;
            this.Homepage = homepage;
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryEditedChanges" /> class.
        /// </summary>
        public WebhookRepositoryEditedChanges()
        {
        }

    }
}