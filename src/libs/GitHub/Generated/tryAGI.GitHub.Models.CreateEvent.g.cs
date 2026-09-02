
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RefType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullRef { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("master_branch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MasterBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PusherType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvent" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="refType"></param>
        /// <param name="fullRef"></param>
        /// <param name="masterBranch"></param>
        /// <param name="pusherType"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvent(
            string @ref,
            string refType,
            string fullRef,
            string masterBranch,
            string pusherType,
            string? description)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.RefType = refType ?? throw new global::System.ArgumentNullException(nameof(refType));
            this.FullRef = fullRef ?? throw new global::System.ArgumentNullException(nameof(fullRef));
            this.MasterBranch = masterBranch ?? throw new global::System.ArgumentNullException(nameof(masterBranch));
            this.Description = description;
            this.PusherType = pusherType ?? throw new global::System.ArgumentNullException(nameof(pusherType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvent" /> class.
        /// </summary>
        public CreateEvent()
        {
        }

    }
}