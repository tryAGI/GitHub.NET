
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActionsListCustomImageVersionsForOrgResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.ActionsHostedRunnerCustomImageVersion> ImageVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListCustomImageVersionsForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="imageVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsListCustomImageVersionsForOrgResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ActionsHostedRunnerCustomImageVersion> imageVersions)
        {
            this.TotalCount = totalCount;
            this.ImageVersions = imageVersions ?? throw new global::System.ArgumentNullException(nameof(imageVersions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsListCustomImageVersionsForOrgResponse" /> class.
        /// </summary>
        public ActionsListCustomImageVersionsForOrgResponse()
        {
        }

    }
}