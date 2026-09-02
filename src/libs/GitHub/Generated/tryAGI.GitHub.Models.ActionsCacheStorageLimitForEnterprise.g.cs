
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// GitHub Actions cache storage policy for an enterprise.
    /// </summary>
    public sealed partial class ActionsCacheStorageLimitForEnterprise
    {
        /// <summary>
        /// For repositories &amp; organizations in an enterprise, the maximum size limit for the sum of all caches in a repository, in gigabytes.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_cache_size_gb")]
        public long? MaxCacheSizeGb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheStorageLimitForEnterprise" /> class.
        /// </summary>
        /// <param name="maxCacheSizeGb">
        /// For repositories &amp; organizations in an enterprise, the maximum size limit for the sum of all caches in a repository, in gigabytes.<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsCacheStorageLimitForEnterprise(
            long? maxCacheSizeGb)
        {
            this.MaxCacheSizeGb = maxCacheSizeGb;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheStorageLimitForEnterprise" /> class.
        /// </summary>
        public ActionsCacheStorageLimitForEnterprise()
        {
        }

    }
}