
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PushEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepositoryId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("push_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PushId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Head { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Before { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PushEvent" /> class.
        /// </summary>
        /// <param name="repositoryId"></param>
        /// <param name="pushId"></param>
        /// <param name="ref"></param>
        /// <param name="head"></param>
        /// <param name="before"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PushEvent(
            int repositoryId,
            int pushId,
            string @ref,
            string head,
            string before)
        {
            this.RepositoryId = repositoryId;
            this.PushId = pushId;
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Head = head ?? throw new global::System.ArgumentNullException(nameof(head));
            this.Before = before ?? throw new global::System.ArgumentNullException(nameof(before));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PushEvent" /> class.
        /// </summary>
        public PushEvent()
        {
        }

    }
}