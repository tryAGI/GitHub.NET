
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ForkEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forkee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.ForkEventForkee Forkee { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="forkee"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForkEvent(
            string action,
            global::tryAGI.GitHub.ForkEventForkee forkee)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Forkee = forkee ?? throw new global::System.ArgumentNullException(nameof(forkee));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForkEvent" /> class.
        /// </summary>
        public ForkEvent()
        {
        }

    }
}