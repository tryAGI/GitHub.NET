
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConcurrencyGroupListConcurrencyGroup
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
        [global::System.Text.Json.Serialization.JsonPropertyName("last_acquired_at")]
        public global::System.DateTime? LastAcquiredAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupListConcurrencyGroup" /> class.
        /// </summary>
        /// <param name="groupName">
        /// The name of the concurrency group.
        /// </param>
        /// <param name="groupUrl">
        /// API URL for this concurrency group.
        /// </param>
        /// <param name="lastAcquiredAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyGroupListConcurrencyGroup(
            string groupName,
            string groupUrl,
            global::System.DateTime? lastAcquiredAt)
        {
            this.GroupName = groupName ?? throw new global::System.ArgumentNullException(nameof(groupName));
            this.GroupUrl = groupUrl ?? throw new global::System.ArgumentNullException(nameof(groupUrl));
            this.LastAcquiredAt = lastAcquiredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyGroupListConcurrencyGroup" /> class.
        /// </summary>
        public ConcurrencyGroupListConcurrencyGroup()
        {
        }

    }
}