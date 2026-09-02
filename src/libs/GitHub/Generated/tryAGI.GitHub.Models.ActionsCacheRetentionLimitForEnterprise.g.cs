
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// GitHub Actions cache retention policy for an enterprise.
    /// </summary>
    public sealed partial class ActionsCacheRetentionLimitForEnterprise
    {
        /// <summary>
        /// For repositories &amp; organizations in an enterprise, the maximum duration, in days, for which caches in a repository may be retained.<br/>
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
        /// Initializes a new instance of the <see cref="ActionsCacheRetentionLimitForEnterprise" /> class.
        /// </summary>
        /// <param name="maxCacheRetentionDays">
        /// For repositories &amp; organizations in an enterprise, the maximum duration, in days, for which caches in a repository may be retained.<br/>
        /// Example: 14
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsCacheRetentionLimitForEnterprise(
            int? maxCacheRetentionDays)
        {
            this.MaxCacheRetentionDays = maxCacheRetentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsCacheRetentionLimitForEnterprise" /> class.
        /// </summary>
        public ActionsCacheRetentionLimitForEnterprise()
        {
        }

    }
}