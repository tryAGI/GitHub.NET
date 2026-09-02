
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MemberEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.GitHub.SimpleUser Member { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberEvent" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="member">
        /// A GitHub user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemberEvent(
            string action,
            global::tryAGI.GitHub.SimpleUser member)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Member = member ?? throw new global::System.ArgumentNullException(nameof(member));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberEvent" /> class.
        /// </summary>
        public MemberEvent()
        {
        }

    }
}