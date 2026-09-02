
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// Links to download the Copilot usage metrics report for an enterprise/organization for a specific day.
    /// </summary>
    public sealed partial class CopilotUsageMetrics1DayReport
    {
        /// <summary>
        /// The URLs to download the Copilot usage metrics report for the enterprise/organization for the specified day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DownloadLinks { get; set; }

        /// <summary>
        /// The day of the report in `YYYY-MM-DD` format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReportDay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetrics1DayReport" /> class.
        /// </summary>
        /// <param name="downloadLinks">
        /// The URLs to download the Copilot usage metrics report for the enterprise/organization for the specified day.
        /// </param>
        /// <param name="reportDay">
        /// The day of the report in `YYYY-MM-DD` format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotUsageMetrics1DayReport(
            global::System.Collections.Generic.IList<string> downloadLinks,
            global::System.DateTime reportDay)
        {
            this.DownloadLinks = downloadLinks ?? throw new global::System.ArgumentNullException(nameof(downloadLinks));
            this.ReportDay = reportDay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotUsageMetrics1DayReport" /> class.
        /// </summary>
        public CopilotUsageMetrics1DayReport()
        {
        }

    }
}