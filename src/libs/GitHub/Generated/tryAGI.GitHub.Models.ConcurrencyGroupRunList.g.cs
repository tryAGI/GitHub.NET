
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A list of concurrency groups associated with a workflow run.
    /// </summary>
    public sealed partial class ConcurrencyGroupRunList
    {
        /// <summary>
        /// The total number of concurrency groups this workflow run participates in,<br/>
        /// derived from the run's configuration. This count is not filtered by<br/>
        /// whether the run currently holds or is waiting in each group, so it can<br/>
        /// include groups whose `group_members` array is empty (for example, when<br/>
        /// the run has already released its lease in that group).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.ConcurrencyGroupRunListConcurrencyGroup> ConcurrencyGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupRunList" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// The total number of concurrency groups this workflow run participates in,<br/>
        /// derived from the run's configuration. This count is not filtered by<br/>
        /// whether the run currently holds or is waiting in each group, so it can<br/>
        /// include groups whose `group_members` array is empty (for example, when<br/>
        /// the run has already released its lease in that group).
        /// </param>
        /// <param name="concurrencyGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyGroupRunList(
            int totalCount,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ConcurrencyGroupRunListConcurrencyGroup> concurrencyGroups)
        {
            this.TotalCount = totalCount;
            this.ConcurrencyGroups = concurrencyGroups ?? throw new global::System.ArgumentNullException(nameof(concurrencyGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupRunList" /> class.
        /// </summary>
        public ConcurrencyGroupRunList()
        {
        }

    }
}