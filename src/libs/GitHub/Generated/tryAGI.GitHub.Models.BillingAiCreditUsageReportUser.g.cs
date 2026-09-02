
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingAiCreditUsageReportUser
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timePeriod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.BillingAiCreditUsageReportUserTimePeriod TimePeriod { get; set; }

        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// The product for the usage report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public string? Product { get; set; }

        /// <summary>
        /// The model for the usage report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.BillingAiCreditUsageReportUserUsageItem> UsageItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAiCreditUsageReportUser" /> class.
        /// </summary>
        /// <param name="timePeriod"></param>
        /// <param name="user">
        /// The unique identifier of the user.
        /// </param>
        /// <param name="usageItems"></param>
        /// <param name="product">
        /// The product for the usage report.
        /// </param>
        /// <param name="model">
        /// The model for the usage report.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingAiCreditUsageReportUser(
            global::tryAGI.GitHub.BillingAiCreditUsageReportUserTimePeriod timePeriod,
            string user,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.BillingAiCreditUsageReportUserUsageItem> usageItems,
            string? product,
            string? model)
        {
            this.TimePeriod = timePeriod ?? throw new global::System.ArgumentNullException(nameof(timePeriod));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Product = product;
            this.Model = model;
            this.UsageItems = usageItems ?? throw new global::System.ArgumentNullException(nameof(usageItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAiCreditUsageReportUser" /> class.
        /// </summary>
        public BillingAiCreditUsageReportUser()
        {
        }

    }
}