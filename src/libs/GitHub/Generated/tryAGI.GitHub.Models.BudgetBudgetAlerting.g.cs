
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BudgetBudgetAlerting
    {
        /// <summary>
        /// Whether alerts are enabled for this budget. Ignored for user-scope as alerting is disabled for them.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("will_alert")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WillAlert { get; set; }

        /// <summary>
        /// Array of user login names who will receive alerts. Ignored for user-scope as alerting is disabled for them.<br/>
        /// Example: [mona, lisa]
        /// </summary>
        /// <example>[mona, lisa]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AlertRecipients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetBudgetAlerting" /> class.
        /// </summary>
        /// <param name="willAlert">
        /// Whether alerts are enabled for this budget. Ignored for user-scope as alerting is disabled for them.<br/>
        /// Example: true
        /// </param>
        /// <param name="alertRecipients">
        /// Array of user login names who will receive alerts. Ignored for user-scope as alerting is disabled for them.<br/>
        /// Example: [mona, lisa]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BudgetBudgetAlerting(
            bool willAlert,
            global::System.Collections.Generic.IList<string> alertRecipients)
        {
            this.WillAlert = willAlert;
            this.AlertRecipients = alertRecipients ?? throw new global::System.ArgumentNullException(nameof(alertRecipients));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetBudgetAlerting" /> class.
        /// </summary>
        public BudgetBudgetAlerting()
        {
        }

    }
}