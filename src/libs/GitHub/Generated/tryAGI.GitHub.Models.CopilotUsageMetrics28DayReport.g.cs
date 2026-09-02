
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Links to download the latest Copilot usage metrics report for an enterprise/organization.
    /// </summary>
    public sealed partial class CopilotUsageMetrics28DayReport
    {
        /// <summary>
        /// The URLs to download the latest Copilot usage metrics report for the enterprise/organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DownloadLinks { get; set; }

        /// <summary>
        /// The start date of the report period in `YYYY-MM-DD` format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_start_day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReportStartDay { get; set; }

        /// <summary>
        /// The end date of the report period in `YYYY-MM-DD` format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_end_day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReportEndDay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetrics28DayReport" /> class.
        /// </summary>
        /// <param name="downloadLinks">
        /// The URLs to download the latest Copilot usage metrics report for the enterprise/organization.
        /// </param>
        /// <param name="reportStartDay">
        /// The start date of the report period in `YYYY-MM-DD` format.
        /// </param>
        /// <param name="reportEndDay">
        /// The end date of the report period in `YYYY-MM-DD` format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotUsageMetrics28DayReport(
            global::System.Collections.Generic.IList<string> downloadLinks,
            global::System.DateTime reportStartDay,
            global::System.DateTime reportEndDay)
        {
            this.DownloadLinks = downloadLinks ?? throw new global::System.ArgumentNullException(nameof(downloadLinks));
            this.ReportStartDay = reportStartDay;
            this.ReportEndDay = reportEndDay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetrics28DayReport" /> class.
        /// </summary>
        public CopilotUsageMetrics28DayReport()
        {
        }

    }
}