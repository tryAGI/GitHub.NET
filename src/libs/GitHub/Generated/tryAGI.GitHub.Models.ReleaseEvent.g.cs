
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReleaseEvent
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
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.GitHub.JsonConverters.AllOfJsonConverter<global::tryAGI.GitHub.Release, global::tryAGI.GitHub.ReleaseEventRelease>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.Release, global::tryAGI.GitHub.ReleaseEventRelease> Release { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="release"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReleaseEvent(
            string action,
            global::tryAGI.GitHub.AllOf<global::tryAGI.GitHub.Release, global::tryAGI.GitHub.ReleaseEventRelease> release)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Release = release;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseEvent" /> class.
        /// </summary>
        public ReleaseEvent()
        {
        }

    }
}