
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A list of active concurrency groups for a repository.
    /// </summary>
    public sealed partial class ConcurrencyGroupList
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
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.ConcurrencyGroupListConcurrencyGroup> ConcurrencyGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupList" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="concurrencyGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyGroupList(
            int totalCount,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ConcurrencyGroupListConcurrencyGroup> concurrencyGroups)
        {
            this.TotalCount = totalCount;
            this.ConcurrencyGroups = concurrencyGroups ?? throw new global::System.ArgumentNullException(nameof(concurrencyGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupList" /> class.
        /// </summary>
        public ConcurrencyGroupList()
        {
        }

    }
}