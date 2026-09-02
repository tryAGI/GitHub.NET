
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GollumEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.GitHub.GollumEventPage> Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GollumEvent" /> class.
        /// </summary>
        /// <param name="pages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GollumEvent(
            global::System.Collections.Generic.IList<global::tryAGI.GitHub.GollumEventPage> pages)
        {
            this.Pages = pages ?? throw new global::System.ArgumentNullException(nameof(pages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GollumEvent" /> class.
        /// </summary>
        public GollumEvent()
        {
        }

    }
}