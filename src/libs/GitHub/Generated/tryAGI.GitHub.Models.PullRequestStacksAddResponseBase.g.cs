
#nullable enable

namespace tryAGI.GitHub
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PullRequestStacksAddResponseBase
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStacksAddResponseBase" /> class.
        /// </summary>
        /// <param name="ref"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PullRequestStacksAddResponseBase(
            string @ref)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestStacksAddResponseBase" /> class.
        /// </summary>
        public PullRequestStacksAddResponseBase()
        {
        }

    }
}