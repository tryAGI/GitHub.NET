
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingUsageSummaryReportUser
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timePeriod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.BillingUsageSummaryReportUserTimePeriod TimePeriod { get; set; }

        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// The name of the repository for the usage report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public string? Repository { get; set; }

        /// <summary>
        /// The product for the usage report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        public string? Product { get; set; }

        /// <summary>
        /// The SKU for the usage report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        public string? Sku { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.BillingUsageSummaryReportUserUsageItem> UsageItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageSummaryReportUser" /> class.
        /// </summary>
        /// <param name="timePeriod"></param>
        /// <param name="user">
        /// The unique identifier of the user.
        /// </param>
        /// <param name="usageItems"></param>
        /// <param name="repository">
        /// The name of the repository for the usage report.
        /// </param>
        /// <param name="product">
        /// The product for the usage report.
        /// </param>
        /// <param name="sku">
        /// The SKU for the usage report.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUsageSummaryReportUser(
            global::tryAGI.GitHub.BillingUsageSummaryReportUserTimePeriod timePeriod,
            string user,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.BillingUsageSummaryReportUserUsageItem> usageItems,
            string? repository,
            string? product,
            string? sku)
        {
            this.TimePeriod = timePeriod ?? throw new global::System.ArgumentNullException(nameof(timePeriod));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Repository = repository;
            this.Product = product;
            this.Sku = sku;
            this.UsageItems = usageItems ?? throw new global::System.ArgumentNullException(nameof(usageItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageSummaryReportUser" /> class.
        /// </summary>
        public BillingUsageSummaryReportUser()
        {
        }

    }
}