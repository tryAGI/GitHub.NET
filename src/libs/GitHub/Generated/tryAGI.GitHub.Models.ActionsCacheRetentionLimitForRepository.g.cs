
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// GitHub Actions cache retention policy for a repository.
    /// </summary>
    public sealed partial class ActionsCacheRetentionLimitForRepository
    {
        /// <summary>
        /// The maximum number of days to keep caches in this repository.<br/>
        /// Example: 14
        /// </summary>
        /// <example>14</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_cache_retention_days")]
        public int? MaxCacheRetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheRetentionLimitForRepository" /> class.
        /// </summary>
        /// <param name="maxCacheRetentionDays">
        /// The maximum number of days to keep caches in this repository.<br/>
        /// Example: 14
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsCacheRetentionLimitForRepository(
            int? maxCacheRetentionDays)
        {
            this.MaxCacheRetentionDays = maxCacheRetentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheRetentionLimitForRepository" /> class.
        /// </summary>
        public ActionsCacheRetentionLimitForRepository()
        {
        }

    }
}