
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DependencyGraphGenerateSbomReportResponse
    {
        /// <summary>
        /// URL to poll for the SBOM export result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sbom_url")]
        public string? SbomUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphGenerateSbomReportResponse" /> class.
        /// </summary>
        /// <param name="sbomUrl">
        /// URL to poll for the SBOM export result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependencyGraphGenerateSbomReportResponse(
            string? sbomUrl)
        {
            this.SbomUrl = sbomUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyGraphGenerateSbomReportResponse" /> class.
        /// </summary>
        public DependencyGraphGenerateSbomReportResponse()
        {
        }

    }
}