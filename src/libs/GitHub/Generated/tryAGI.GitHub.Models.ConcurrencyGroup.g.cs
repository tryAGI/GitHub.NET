
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    /// A concurrency group with the workflow runs and jobs that are either currently holding<br/>
    /// or waiting for the concurrency group lease.
    /// </summary>
    public sealed partial class ConcurrencyGroup
    {
        /// <summary>
        /// The name of the concurrency group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupName { get; set; }

        /// <summary>
        /// API URL for this concurrency group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.ConcurrencyGroupGroupMember> GroupMembers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroup" /> class.
        /// </summary>
        /// <param name="groupName">
        /// The name of the concurrency group.
        /// </param>
        /// <param name="groupUrl">
        /// API URL for this concurrency group.
        /// </param>
        /// <param name="totalCount"></param>
        /// <param name="groupMembers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyGroup(
            string groupName,
            string groupUrl,
            int totalCount,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ConcurrencyGroupGroupMember> groupMembers)
        {
            this.GroupName = groupName ?? throw new global::System.ArgumentNullException(nameof(groupName));
            this.GroupUrl = groupUrl ?? throw new global::System.ArgumentNullException(nameof(groupUrl));
            this.TotalCount = totalCount;
            this.GroupMembers = groupMembers ?? throw new global::System.ArgumentNullException(nameof(groupMembers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroup" /> class.
        /// </summary>
        public ConcurrencyGroup()
        {
        }

    }
}