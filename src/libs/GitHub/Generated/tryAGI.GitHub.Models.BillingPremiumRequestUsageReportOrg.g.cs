
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingPremiumRequestUsageReportOrg
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timePeriod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.BillingPremiumRequestUsageReportOrgTimePeriod TimePeriod { get; set; }

        /// <summary>
        /// The unique identifier of the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Organization { get; set; }

        /// <summary>
        /// The name of the user for the usage report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

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
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.BillingPremiumRequestUsageReportOrgUsageItem> UsageItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPremiumRequestUsageReportOrg" /> class.
        /// </summary>
        /// <param name="timePeriod"></param>
        /// <param name="organization">
        /// The unique identifier of the organization.
        /// </param>
        /// <param name="usageItems"></param>
        /// <param name="user">
        /// The name of the user for the usage report.
        /// </param>
        /// <param name="product">
        /// The product for the usage report.
        /// </param>
        /// <param name="model">
        /// The model for the usage report.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingPremiumRequestUsageReportOrg(
            global::tryAGI.GitHub.BillingPremiumRequestUsageReportOrgTimePeriod timePeriod,
            string organization,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.BillingPremiumRequestUsageReportOrgUsageItem> usageItems,
            string? user,
            string? product,
            string? model)
        {
            this.TimePeriod = timePeriod ?? throw new global::System.ArgumentNullException(nameof(timePeriod));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.User = user;
            this.Product = product;
            this.Model = model;
            this.UsageItems = usageItems ?? throw new global::System.ArgumentNullException(nameof(usageItems));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPremiumRequestUsageReportOrg" /> class.
        /// </summary>
        public BillingPremiumRequestUsageReportOrg()
        {
        }

    }
}