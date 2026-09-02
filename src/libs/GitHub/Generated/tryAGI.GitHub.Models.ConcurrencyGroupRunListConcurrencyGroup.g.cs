
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConcurrencyGroupRunListConcurrencyGroup
    {
        /// <summary>
        /// The name of the concurrency group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupName { get; set; }

        /// <summary>
        /// API URL for this concurrency group. May return 404 if the group<br/>
        /// has no active items at the time it is requested, since the<br/>
        /// get-by-name endpoint reports the live repo-wide state of a group<br/>
        /// while this endpoint lists groups associated with a run by<br/>
        /// configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupUrl { get; set; }

        /// <summary>
        /// Items belonging to this workflow run that are either currently holding or<br/>
        /// waiting for the concurrency group lease. May be empty if the run no<br/>
        /// longer has any active or queued items in this group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.ConcurrencyGroupRunListConcurrencyGroupGroupMember> GroupMembers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupRunListConcurrencyGroup" /> class.
        /// </summary>
        /// <param name="groupName">
        /// The name of the concurrency group.
        /// </param>
        /// <param name="groupUrl">
        /// API URL for this concurrency group. May return 404 if the group<br/>
        /// has no active items at the time it is requested, since the<br/>
        /// get-by-name endpoint reports the live repo-wide state of a group<br/>
        /// while this endpoint lists groups associated with a run by<br/>
        /// configuration.
        /// </param>
        /// <param name="groupMembers">
        /// Items belonging to this workflow run that are either currently holding or<br/>
        /// waiting for the concurrency group lease. May be empty if the run no<br/>
        /// longer has any active or queued items in this group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyGroupRunListConcurrencyGroup(
            string groupName,
            string groupUrl,
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.ConcurrencyGroupRunListConcurrencyGroupGroupMember> groupMembers)
        {
            this.GroupName = groupName ?? throw new global::System.ArgumentNullException(nameof(groupName));
            this.GroupUrl = groupUrl ?? throw new global::System.ArgumentNullException(nameof(groupUrl));
            this.GroupMembers = groupMembers ?? throw new global::System.ArgumentNullException(nameof(groupMembers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupRunListConcurrencyGroup" /> class.
        /// </summary>
        public ConcurrencyGroupRunListConcurrencyGroup()
        {
        }

    }
}