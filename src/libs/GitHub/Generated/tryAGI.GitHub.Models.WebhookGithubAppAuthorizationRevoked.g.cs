
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookGithubAppAuthorizationRevoked
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.WebhookGithubAppAuthorizationRevokedActionJsonConverter))]
        public global::tryAGI.GitHub.WebhookGithubAppAuthorizationRevokedAction Action { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Sender { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGithubAppAuthorizationRevoked" /> class.
        /// </summary>
        /// <param name="sender">
        /// A GitHub user.
        /// </param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookGithubAppAuthorizationRevoked(
            global::tryAGI.GitHub.SimpleUser sender,
            global::tryAGI.GitHub.WebhookGithubAppAuthorizationRevokedAction action)
        {
            this.Action = action;
            this.Sender = sender ?? throw new global::System.ArgumentNullException(nameof(sender));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookGithubAppAuthorizationRevoked" /> class.
        /// </summary>
        public WebhookGithubAppAuthorizationRevoked()
        {
        }

    }
}