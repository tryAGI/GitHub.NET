
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BillingUsageSummaryReportUserTimePeriod
    {
        /// <summary>
        /// The year for the usage report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("year")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Year { get; set; }

        /// <summary>
        /// The month for the usage report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("month")]
        public int? Month { get; set; }

        /// <summary>
        /// The day for the usage report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        public int? Day { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageSummaryReportUserTimePeriod" /> class.
        /// </summary>
        /// <param name="year">
        /// The year for the usage report.
        /// </param>
        /// <param name="month">
        /// The month for the usage report.
        /// </param>
        /// <param name="day">
        /// The day for the usage report.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUsageSummaryReportUserTimePeriod(
            int year,
            int? month,
            int? day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageSummaryReportUserTimePeriod" /> class.
        /// </summary>
        public BillingUsageSummaryReportUserTimePeriod()
        {
        }

    }
}