
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceMessage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceMessage" /> class.
        /// </summary>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceMessage(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceMessage" /> class.
        /// </summary>
        public WebhookCodeScanningAlertUpdatedAssignmentAlertMostRecentInstanceMessage()
        {
        }

    }
}