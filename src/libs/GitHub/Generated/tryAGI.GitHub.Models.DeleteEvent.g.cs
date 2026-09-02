
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteEvent
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
        [global::System.Text.Json.Serialization.JsonPropertyName("pusher_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PusherType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEvent" /> class.
        /// </summary>
        /// <param name="ref"></param>
        /// <param name="refType"></param>
        /// <param name="fullRef"></param>
        /// <param name="pusherType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteEvent(
            string @ref,
            string refType,
            string fullRef,
            string pusherType)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.RefType = refType ?? throw new global::System.ArgumentNullException(nameof(refType));
            this.FullRef = fullRef ?? throw new global::System.ArgumentNullException(nameof(fullRef));
            this.PusherType = pusherType ?? throw new global::System.ArgumentNullException(nameof(pusherType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteEvent" /> class.
        /// </summary>
        public DeleteEvent()
        {
        }

    }
}